using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BestHTTP.Extensions
{
	public static class Extensions
	{
		public static string AsciiToString(this byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder(bytes.Length);
			for (int i = 0; i < bytes.Length; i++)
			{
				byte b = bytes[i];
				stringBuilder.Append((b > 127) ? '?' : ((char)b));
			}
			return stringBuilder.ToString();
		}

		public static byte[] GetASCIIBytes(this string str)
		{
			byte[] array = new byte[str.Length];
			for (int i = 0; i < str.Length; i++)
			{
				char c = str[i];
				array[i] = (byte)((c >= '\u0080') ? '?' : c);
			}
			return array;
		}

		public static void WriteLine(this FileStream fs)
		{
			fs.Write(HTTPRequest.EOL, 0, 2);
		}

		public static void WriteLine(this FileStream fs, string line)
		{
			byte[] aSCIIBytes = line.GetASCIIBytes();
			fs.Write(aSCIIBytes, 0, aSCIIBytes.Length);
			fs.WriteLine();
		}

		public static void WriteLine(this FileStream fs, string format, params object[] values)
		{
			byte[] aSCIIBytes = string.Format(format, values).GetASCIIBytes();
			fs.Write(aSCIIBytes, 0, aSCIIBytes.Length);
			fs.WriteLine();
		}

		public static string[] FindOption(this string str, string option)
		{
			string[] array = str.ToLower().Split(new char[]
			{
				','
			}, StringSplitOptions.RemoveEmptyEntries);
			option = option.ToLower();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Contains(option))
				{
					return array[i].Split(new char[]
					{
						'='
					}, StringSplitOptions.RemoveEmptyEntries);
				}
			}
			return null;
		}

		public static int ToInt32(this string str, int defaultValue = 0)
		{
			if (str == null)
			{
				return defaultValue;
			}
			int result;
			try
			{
				result = int.Parse(str);
			}
			catch
			{
				result = defaultValue;
			}
			return result;
		}

		public static long ToInt64(this string str, long defaultValue = 0L)
		{
			if (str == null)
			{
				return defaultValue;
			}
			long result;
			try
			{
				result = long.Parse(str);
			}
			catch
			{
				result = defaultValue;
			}
			return result;
		}

		public static DateTime ToDateTime(this string str, DateTime defaultValue = default(DateTime))
		{
			if (str == null)
			{
				return defaultValue;
			}
			DateTime result;
			try
			{
				DateTime.TryParse(str, out defaultValue);
				result = defaultValue.ToUniversalTime();
			}
			catch
			{
				result = defaultValue;
			}
			return result;
		}

		public static string ToStrOrEmpty(this string str)
		{
			if (str == null)
			{
				return string.Empty;
			}
			return str;
		}

		public static string CalculateMD5Hash(this string input)
		{
			return input.GetASCIIBytes().CalculateMD5Hash();
		}

		public static string CalculateMD5Hash(this byte[] input)
		{
			byte[] array = MD5.Create().ComputeHash(input);
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				byte b = array2[i];
				stringBuilder.Append(b.ToString("x2"));
			}
			return stringBuilder.ToString();
		}

		internal static string Read(this string str, ref int pos, char block, bool needResult = true)
		{
			return str.Read(ref pos, (char ch) => ch != block, needResult);
		}

		internal static string Read(this string str, ref int pos, Func<char, bool> block, bool needResult = true)
		{
			if (pos >= str.Length)
			{
				return string.Empty;
			}
			str.SkipWhiteSpace(ref pos);
			int num = pos;
			while (pos < str.Length && block(str[pos]))
			{
				pos++;
			}
			string result = (!needResult) ? null : str.Substring(num, pos - num);
			pos++;
			return result;
		}

		internal static string ReadQuotedText(this string str, ref int pos)
		{
			string result = string.Empty;
			if (str == null)
			{
				return result;
			}
			if (str[pos] == '"')
			{
				str.Read(ref pos, '"', false);
				result = str.Read(ref pos, '"', true);
				str.Read(ref pos, ',', false);
			}
			else
			{
				result = str.Read(ref pos, ',', true);
			}
			return result;
		}

		internal static void SkipWhiteSpace(this string str, ref int pos)
		{
			if (pos >= str.Length)
			{
				return;
			}
			while (pos < str.Length && char.IsWhiteSpace(str[pos]))
			{
				pos++;
			}
		}

		internal static string TrimAndLower(this string str)
		{
			if (str == null)
			{
				return null;
			}
			char[] array = new char[str.Length];
			int length = 0;
			for (int i = 0; i < str.Length; i++)
			{
				char c = str[i];
				if (!char.IsWhiteSpace(c) && !char.IsControl(c))
				{
					array[length++] = char.ToLowerInvariant(c);
				}
			}
			return new string(array, 0, length);
		}

		internal static List<KeyValuePair> ParseOptionalHeader(this string str)
		{
			List<KeyValuePair> list = new List<KeyValuePair>();
			if (str == null)
			{
				return list;
			}
			int i = 0;
			while (i < str.Length)
			{
				string key = str.Read(ref i, (char ch) => ch != '=' && ch != ',', true).TrimAndLower();
				KeyValuePair keyValuePair = new KeyValuePair(key);
				if (str[i - 1] == '=')
				{
					keyValuePair.Value = str.ReadQuotedText(ref i);
				}
				list.Add(keyValuePair);
			}
			return list;
		}

		internal static List<KeyValuePair> ParseQualityParams(this string str)
		{
			List<KeyValuePair> list = new List<KeyValuePair>();
			if (str == null)
			{
				return list;
			}
			int i = 0;
			while (i < str.Length)
			{
				string key = str.Read(ref i, (char ch) => ch != ',' && ch != ';', true).TrimAndLower();
				KeyValuePair keyValuePair = new KeyValuePair(key);
				if (str[i - 1] == ';')
				{
					str.Read(ref i, '=', false);
					keyValuePair.Value = str.Read(ref i, ',', true);
				}
				list.Add(keyValuePair);
			}
			return list;
		}

		public static void ReadBuffer(this Stream stream, byte[] buffer)
		{
			int num = 0;
			do
			{
				num += stream.Read(buffer, num, buffer.Length - num);
			}
			while (num < buffer.Length);
		}

		public static void WriteAll(this MemoryStream ms, byte[] buffer)
		{
			ms.Write(buffer, 0, buffer.Length);
		}

		public static void WriteString(this MemoryStream ms, string str)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(str);
			ms.WriteAll(bytes);
		}

		public static void WriteLine(this MemoryStream ms)
		{
			ms.WriteAll(HTTPRequest.EOL);
		}

		public static void WriteLine(this MemoryStream ms, string str)
		{
			ms.WriteString(str);
			ms.WriteLine();
		}
	}
}
