using Org.BouncyCastle.Crypto.Utilities;
using System;

namespace Org.BouncyCastle.Math.Raw
{
	internal abstract class Nat256
	{
		private const ulong M = 4294967295uL;

		public static uint Add(uint[] x, uint[] y, uint[] z)
		{
			ulong num = 0uL;
			num += (ulong)x[0] + (ulong)y[0];
			z[0] = (uint)num;
			num >>= 32;
			num += (ulong)x[1] + (ulong)y[1];
			z[1] = (uint)num;
			num >>= 32;
			num += (ulong)x[2] + (ulong)y[2];
			z[2] = (uint)num;
			num >>= 32;
			num += (ulong)x[3] + (ulong)y[3];
			z[3] = (uint)num;
			num >>= 32;
			num += (ulong)x[4] + (ulong)y[4];
			z[4] = (uint)num;
			num >>= 32;
			num += (ulong)x[5] + (ulong)y[5];
			z[5] = (uint)num;
			num >>= 32;
			num += (ulong)x[6] + (ulong)y[6];
			z[6] = (uint)num;
			num >>= 32;
			num += (ulong)x[7] + (ulong)y[7];
			z[7] = (uint)num;
			num >>= 32;
			return (uint)num;
		}

		public static uint Add(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			ulong num = 0uL;
			num += (ulong)x[xOff] + (ulong)y[yOff];
			z[zOff] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 1] + (ulong)y[yOff + 1];
			z[zOff + 1] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 2] + (ulong)y[yOff + 2];
			z[zOff + 2] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 3] + (ulong)y[yOff + 3];
			z[zOff + 3] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 4] + (ulong)y[yOff + 4];
			z[zOff + 4] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 5] + (ulong)y[yOff + 5];
			z[zOff + 5] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 6] + (ulong)y[yOff + 6];
			z[zOff + 6] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 7] + (ulong)y[yOff + 7];
			z[zOff + 7] = (uint)num;
			num >>= 32;
			return (uint)num;
		}

		public static uint AddBothTo(uint[] x, uint[] y, uint[] z)
		{
			ulong num = 0uL;
			num += (ulong)x[0] + (ulong)y[0] + (ulong)z[0];
			z[0] = (uint)num;
			num >>= 32;
			num += (ulong)x[1] + (ulong)y[1] + (ulong)z[1];
			z[1] = (uint)num;
			num >>= 32;
			num += (ulong)x[2] + (ulong)y[2] + (ulong)z[2];
			z[2] = (uint)num;
			num >>= 32;
			num += (ulong)x[3] + (ulong)y[3] + (ulong)z[3];
			z[3] = (uint)num;
			num >>= 32;
			num += (ulong)x[4] + (ulong)y[4] + (ulong)z[4];
			z[4] = (uint)num;
			num >>= 32;
			num += (ulong)x[5] + (ulong)y[5] + (ulong)z[5];
			z[5] = (uint)num;
			num >>= 32;
			num += (ulong)x[6] + (ulong)y[6] + (ulong)z[6];
			z[6] = (uint)num;
			num >>= 32;
			num += (ulong)x[7] + (ulong)y[7] + (ulong)z[7];
			z[7] = (uint)num;
			num >>= 32;
			return (uint)num;
		}

		public static uint AddBothTo(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			ulong num = 0uL;
			num += (ulong)x[xOff] + (ulong)y[yOff] + (ulong)z[zOff];
			z[zOff] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 1] + (ulong)y[yOff + 1] + (ulong)z[zOff + 1];
			z[zOff + 1] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 2] + (ulong)y[yOff + 2] + (ulong)z[zOff + 2];
			z[zOff + 2] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 3] + (ulong)y[yOff + 3] + (ulong)z[zOff + 3];
			z[zOff + 3] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 4] + (ulong)y[yOff + 4] + (ulong)z[zOff + 4];
			z[zOff + 4] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 5] + (ulong)y[yOff + 5] + (ulong)z[zOff + 5];
			z[zOff + 5] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 6] + (ulong)y[yOff + 6] + (ulong)z[zOff + 6];
			z[zOff + 6] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 7] + (ulong)y[yOff + 7] + (ulong)z[zOff + 7];
			z[zOff + 7] = (uint)num;
			num >>= 32;
			return (uint)num;
		}

		public static uint AddTo(uint[] x, uint[] z)
		{
			ulong num = 0uL;
			num += (ulong)x[0] + (ulong)z[0];
			z[0] = (uint)num;
			num >>= 32;
			num += (ulong)x[1] + (ulong)z[1];
			z[1] = (uint)num;
			num >>= 32;
			num += (ulong)x[2] + (ulong)z[2];
			z[2] = (uint)num;
			num >>= 32;
			num += (ulong)x[3] + (ulong)z[3];
			z[3] = (uint)num;
			num >>= 32;
			num += (ulong)x[4] + (ulong)z[4];
			z[4] = (uint)num;
			num >>= 32;
			num += (ulong)x[5] + (ulong)z[5];
			z[5] = (uint)num;
			num >>= 32;
			num += (ulong)x[6] + (ulong)z[6];
			z[6] = (uint)num;
			num >>= 32;
			num += (ulong)x[7] + (ulong)z[7];
			z[7] = (uint)num;
			num >>= 32;
			return (uint)num;
		}

		public static uint AddTo(uint[] x, int xOff, uint[] z, int zOff, uint cIn)
		{
			ulong num = (ulong)cIn;
			num += (ulong)x[xOff] + (ulong)z[zOff];
			z[zOff] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 1] + (ulong)z[zOff + 1];
			z[zOff + 1] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 2] + (ulong)z[zOff + 2];
			z[zOff + 2] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 3] + (ulong)z[zOff + 3];
			z[zOff + 3] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 4] + (ulong)z[zOff + 4];
			z[zOff + 4] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 5] + (ulong)z[zOff + 5];
			z[zOff + 5] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 6] + (ulong)z[zOff + 6];
			z[zOff + 6] = (uint)num;
			num >>= 32;
			num += (ulong)x[xOff + 7] + (ulong)z[zOff + 7];
			z[zOff + 7] = (uint)num;
			num >>= 32;
			return (uint)num;
		}

		public static uint AddToEachOther(uint[] u, int uOff, uint[] v, int vOff)
		{
			ulong num = 0uL;
			num += (ulong)u[uOff] + (ulong)v[vOff];
			u[uOff] = (uint)num;
			v[vOff] = (uint)num;
			num >>= 32;
			num += (ulong)u[uOff + 1] + (ulong)v[vOff + 1];
			u[uOff + 1] = (uint)num;
			v[vOff + 1] = (uint)num;
			num >>= 32;
			num += (ulong)u[uOff + 2] + (ulong)v[vOff + 2];
			u[uOff + 2] = (uint)num;
			v[vOff + 2] = (uint)num;
			num >>= 32;
			num += (ulong)u[uOff + 3] + (ulong)v[vOff + 3];
			u[uOff + 3] = (uint)num;
			v[vOff + 3] = (uint)num;
			num >>= 32;
			num += (ulong)u[uOff + 4] + (ulong)v[vOff + 4];
			u[uOff + 4] = (uint)num;
			v[vOff + 4] = (uint)num;
			num >>= 32;
			num += (ulong)u[uOff + 5] + (ulong)v[vOff + 5];
			u[uOff + 5] = (uint)num;
			v[vOff + 5] = (uint)num;
			num >>= 32;
			num += (ulong)u[uOff + 6] + (ulong)v[vOff + 6];
			u[uOff + 6] = (uint)num;
			v[vOff + 6] = (uint)num;
			num >>= 32;
			num += (ulong)u[uOff + 7] + (ulong)v[vOff + 7];
			u[uOff + 7] = (uint)num;
			v[vOff + 7] = (uint)num;
			num >>= 32;
			return (uint)num;
		}

		public static void Copy(uint[] x, uint[] z)
		{
			z[0] = x[0];
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
			z[4] = x[4];
			z[5] = x[5];
			z[6] = x[6];
			z[7] = x[7];
		}

		public static void Copy64(ulong[] x, ulong[] z)
		{
			z[0] = x[0];
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
		}

		public static uint[] Create()
		{
			return new uint[8];
		}

		public static ulong[] Create64()
		{
			return new ulong[4];
		}

		public static uint[] CreateExt()
		{
			return new uint[16];
		}

		public static ulong[] CreateExt64()
		{
			return new ulong[8];
		}

		public static bool Diff(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			bool flag = Nat256.Gte(x, xOff, y, yOff);
			if (flag)
			{
				Nat256.Sub(x, xOff, y, yOff, z, zOff);
			}
			else
			{
				Nat256.Sub(y, yOff, x, xOff, z, zOff);
			}
			return flag;
		}

		public static bool Eq(uint[] x, uint[] y)
		{
			for (int i = 7; i >= 0; i--)
			{
				if (x[i] != y[i])
				{
					return false;
				}
			}
			return true;
		}

		public static bool Eq64(ulong[] x, ulong[] y)
		{
			for (int i = 3; i >= 0; i--)
			{
				if (x[i] != y[i])
				{
					return false;
				}
			}
			return true;
		}

		public static uint[] FromBigInteger(BigInteger x)
		{
			if (x.SignValue < 0 || x.BitLength > 256)
			{
				throw new ArgumentException();
			}
			uint[] array = Nat256.Create();
			int num = 0;
			while (x.SignValue != 0)
			{
				array[num++] = (uint)x.IntValue;
				x = x.ShiftRight(32);
			}
			return array;
		}

		public static ulong[] FromBigInteger64(BigInteger x)
		{
			if (x.SignValue < 0 || x.BitLength > 256)
			{
				throw new ArgumentException();
			}
			ulong[] array = Nat256.Create64();
			int num = 0;
			while (x.SignValue != 0)
			{
				array[num++] = (ulong)x.LongValue;
				x = x.ShiftRight(64);
			}
			return array;
		}

		public static uint GetBit(uint[] x, int bit)
		{
			if (bit == 0)
			{
				return x[0] & 1u;
			}
			if ((bit & 255) != bit)
			{
				return 0u;
			}
			int num = bit >> 5;
			int num2 = bit & 31;
			return x[num] >> num2 & 1u;
		}

		public static bool Gte(uint[] x, uint[] y)
		{
			for (int i = 7; i >= 0; i--)
			{
				uint num = x[i];
				uint num2 = y[i];
				if (num < num2)
				{
					return false;
				}
				if (num > num2)
				{
					return true;
				}
			}
			return true;
		}

		public static bool Gte(uint[] x, int xOff, uint[] y, int yOff)
		{
			for (int i = 7; i >= 0; i--)
			{
				uint num = x[xOff + i];
				uint num2 = y[yOff + i];
				if (num < num2)
				{
					return false;
				}
				if (num > num2)
				{
					return true;
				}
			}
			return true;
		}

		public static bool IsOne(uint[] x)
		{
			if (x[0] != 1u)
			{
				return false;
			}
			for (int i = 1; i < 8; i++)
			{
				if (x[i] != 0u)
				{
					return false;
				}
			}
			return true;
		}

		public static bool IsOne64(ulong[] x)
		{
			if (x[0] != 1uL)
			{
				return false;
			}
			for (int i = 1; i < 4; i++)
			{
				if (x[i] != 0uL)
				{
					return false;
				}
			}
			return true;
		}

		public static bool IsZero(uint[] x)
		{
			for (int i = 0; i < 8; i++)
			{
				if (x[i] != 0u)
				{
					return false;
				}
			}
			return true;
		}

		public static bool IsZero64(ulong[] x)
		{
			for (int i = 0; i < 4; i++)
			{
				if (x[i] != 0uL)
				{
					return false;
				}
			}
			return true;
		}

		public static void Mul(uint[] x, uint[] y, uint[] zz)
		{
			ulong num = (ulong)y[0];
			ulong num2 = (ulong)y[1];
			ulong num3 = (ulong)y[2];
			ulong num4 = (ulong)y[3];
			ulong num5 = (ulong)y[4];
			ulong num6 = (ulong)y[5];
			ulong num7 = (ulong)y[6];
			ulong num8 = (ulong)y[7];
			ulong num9 = 0uL;
			ulong num10 = (ulong)x[0];
			num9 += num10 * num;
			zz[0] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num2;
			zz[1] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num3;
			zz[2] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num4;
			zz[3] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num5;
			zz[4] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num6;
			zz[5] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num7;
			zz[6] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num8;
			zz[7] = (uint)num9;
			num9 >>= 32;
			zz[8] = (uint)num9;
			for (int i = 1; i < 8; i++)
			{
				ulong num11 = 0uL;
				ulong num12 = (ulong)x[i];
				num11 += num12 * num + (ulong)zz[i];
				zz[i] = (uint)num11;
				num11 >>= 32;
				num11 += num12 * num2 + (ulong)zz[i + 1];
				zz[i + 1] = (uint)num11;
				num11 >>= 32;
				num11 += num12 * num3 + (ulong)zz[i + 2];
				zz[i + 2] = (uint)num11;
				num11 >>= 32;
				num11 += num12 * num4 + (ulong)zz[i + 3];
				zz[i + 3] = (uint)num11;
				num11 >>= 32;
				num11 += num12 * num5 + (ulong)zz[i + 4];
				zz[i + 4] = (uint)num11;
				num11 >>= 32;
				num11 += num12 * num6 + (ulong)zz[i + 5];
				zz[i + 5] = (uint)num11;
				num11 >>= 32;
				num11 += num12 * num7 + (ulong)zz[i + 6];
				zz[i + 6] = (uint)num11;
				num11 >>= 32;
				num11 += num12 * num8 + (ulong)zz[i + 7];
				zz[i + 7] = (uint)num11;
				num11 >>= 32;
				zz[i + 8] = (uint)num11;
			}
		}

		public static void Mul(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			ulong num = (ulong)y[yOff];
			ulong num2 = (ulong)y[yOff + 1];
			ulong num3 = (ulong)y[yOff + 2];
			ulong num4 = (ulong)y[yOff + 3];
			ulong num5 = (ulong)y[yOff + 4];
			ulong num6 = (ulong)y[yOff + 5];
			ulong num7 = (ulong)y[yOff + 6];
			ulong num8 = (ulong)y[yOff + 7];
			ulong num9 = 0uL;
			ulong num10 = (ulong)x[xOff];
			num9 += num10 * num;
			zz[zzOff] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num2;
			zz[zzOff + 1] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num3;
			zz[zzOff + 2] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num4;
			zz[zzOff + 3] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num5;
			zz[zzOff + 4] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num6;
			zz[zzOff + 5] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num7;
			zz[zzOff + 6] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num8;
			zz[zzOff + 7] = (uint)num9;
			num9 >>= 32;
			zz[zzOff + 8] = (uint)num9;
			for (int i = 1; i < 8; i++)
			{
				zzOff++;
				ulong num11 = 0uL;
				ulong num12 = (ulong)x[xOff + i];
				num11 += num12 * num + (ulong)zz[zzOff];
				zz[zzOff] = (uint)num11;
				num11 >>= 32;
				num11 += num12 * num2 + (ulong)zz[zzOff + 1];
				zz[zzOff + 1] = (uint)num11;
				num11 >>= 32;
				num11 += num12 * num3 + (ulong)zz[zzOff + 2];
				zz[zzOff + 2] = (uint)num11;
				num11 >>= 32;
				num11 += num12 * num4 + (ulong)zz[zzOff + 3];
				zz[zzOff + 3] = (uint)num11;
				num11 >>= 32;
				num11 += num12 * num5 + (ulong)zz[zzOff + 4];
				zz[zzOff + 4] = (uint)num11;
				num11 >>= 32;
				num11 += num12 * num6 + (ulong)zz[zzOff + 5];
				zz[zzOff + 5] = (uint)num11;
				num11 >>= 32;
				num11 += num12 * num7 + (ulong)zz[zzOff + 6];
				zz[zzOff + 6] = (uint)num11;
				num11 >>= 32;
				num11 += num12 * num8 + (ulong)zz[zzOff + 7];
				zz[zzOff + 7] = (uint)num11;
				num11 >>= 32;
				zz[zzOff + 8] = (uint)num11;
			}
		}

		public static uint MulAddTo(uint[] x, uint[] y, uint[] zz)
		{
			ulong num = (ulong)y[0];
			ulong num2 = (ulong)y[1];
			ulong num3 = (ulong)y[2];
			ulong num4 = (ulong)y[3];
			ulong num5 = (ulong)y[4];
			ulong num6 = (ulong)y[5];
			ulong num7 = (ulong)y[6];
			ulong num8 = (ulong)y[7];
			ulong num9 = 0uL;
			for (int i = 0; i < 8; i++)
			{
				ulong num10 = 0uL;
				ulong num11 = (ulong)x[i];
				num10 += num11 * num + (ulong)zz[i];
				zz[i] = (uint)num10;
				num10 >>= 32;
				num10 += num11 * num2 + (ulong)zz[i + 1];
				zz[i + 1] = (uint)num10;
				num10 >>= 32;
				num10 += num11 * num3 + (ulong)zz[i + 2];
				zz[i + 2] = (uint)num10;
				num10 >>= 32;
				num10 += num11 * num4 + (ulong)zz[i + 3];
				zz[i + 3] = (uint)num10;
				num10 >>= 32;
				num10 += num11 * num5 + (ulong)zz[i + 4];
				zz[i + 4] = (uint)num10;
				num10 >>= 32;
				num10 += num11 * num6 + (ulong)zz[i + 5];
				zz[i + 5] = (uint)num10;
				num10 >>= 32;
				num10 += num11 * num7 + (ulong)zz[i + 6];
				zz[i + 6] = (uint)num10;
				num10 >>= 32;
				num10 += num11 * num8 + (ulong)zz[i + 7];
				zz[i + 7] = (uint)num10;
				num10 >>= 32;
				num10 += num9 + (ulong)zz[i + 8];
				zz[i + 8] = (uint)num10;
				num9 = num10 >> 32;
			}
			return (uint)num9;
		}

		public static uint MulAddTo(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			ulong num = (ulong)y[yOff];
			ulong num2 = (ulong)y[yOff + 1];
			ulong num3 = (ulong)y[yOff + 2];
			ulong num4 = (ulong)y[yOff + 3];
			ulong num5 = (ulong)y[yOff + 4];
			ulong num6 = (ulong)y[yOff + 5];
			ulong num7 = (ulong)y[yOff + 6];
			ulong num8 = (ulong)y[yOff + 7];
			ulong num9 = 0uL;
			for (int i = 0; i < 8; i++)
			{
				ulong num10 = 0uL;
				ulong num11 = (ulong)x[xOff + i];
				num10 += num11 * num + (ulong)zz[zzOff];
				zz[zzOff] = (uint)num10;
				num10 >>= 32;
				num10 += num11 * num2 + (ulong)zz[zzOff + 1];
				zz[zzOff + 1] = (uint)num10;
				num10 >>= 32;
				num10 += num11 * num3 + (ulong)zz[zzOff + 2];
				zz[zzOff + 2] = (uint)num10;
				num10 >>= 32;
				num10 += num11 * num4 + (ulong)zz[zzOff + 3];
				zz[zzOff + 3] = (uint)num10;
				num10 >>= 32;
				num10 += num11 * num5 + (ulong)zz[zzOff + 4];
				zz[zzOff + 4] = (uint)num10;
				num10 >>= 32;
				num10 += num11 * num6 + (ulong)zz[zzOff + 5];
				zz[zzOff + 5] = (uint)num10;
				num10 >>= 32;
				num10 += num11 * num7 + (ulong)zz[zzOff + 6];
				zz[zzOff + 6] = (uint)num10;
				num10 >>= 32;
				num10 += num11 * num8 + (ulong)zz[zzOff + 7];
				zz[zzOff + 7] = (uint)num10;
				num10 >>= 32;
				num10 += num9 + (ulong)zz[zzOff + 8];
				zz[zzOff + 8] = (uint)num10;
				num9 = num10 >> 32;
				zzOff++;
			}
			return (uint)num9;
		}

		public static ulong Mul33Add(uint w, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			ulong num = 0uL;
			ulong num2 = (ulong)w;
			ulong num3 = (ulong)x[xOff];
			num += num2 * num3 + (ulong)y[yOff];
			z[zOff] = (uint)num;
			num >>= 32;
			ulong num4 = (ulong)x[xOff + 1];
			num += num2 * num4 + num3 + (ulong)y[yOff + 1];
			z[zOff + 1] = (uint)num;
			num >>= 32;
			ulong num5 = (ulong)x[xOff + 2];
			num += num2 * num5 + num4 + (ulong)y[yOff + 2];
			z[zOff + 2] = (uint)num;
			num >>= 32;
			ulong num6 = (ulong)x[xOff + 3];
			num += num2 * num6 + num5 + (ulong)y[yOff + 3];
			z[zOff + 3] = (uint)num;
			num >>= 32;
			ulong num7 = (ulong)x[xOff + 4];
			num += num2 * num7 + num6 + (ulong)y[yOff + 4];
			z[zOff + 4] = (uint)num;
			num >>= 32;
			ulong num8 = (ulong)x[xOff + 5];
			num += num2 * num8 + num7 + (ulong)y[yOff + 5];
			z[zOff + 5] = (uint)num;
			num >>= 32;
			ulong num9 = (ulong)x[xOff + 6];
			num += num2 * num9 + num8 + (ulong)y[yOff + 6];
			z[zOff + 6] = (uint)num;
			num >>= 32;
			ulong num10 = (ulong)x[xOff + 7];
			num += num2 * num10 + num9 + (ulong)y[yOff + 7];
			z[zOff + 7] = (uint)num;
			num >>= 32;
			return num + num10;
		}

		public static uint MulByWord(uint x, uint[] z)
		{
			ulong num = 0uL;
			ulong num2 = (ulong)x;
			num += num2 * (ulong)z[0];
			z[0] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)z[1];
			z[1] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)z[2];
			z[2] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)z[3];
			z[3] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)z[4];
			z[4] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)z[5];
			z[5] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)z[6];
			z[6] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)z[7];
			z[7] = (uint)num;
			num >>= 32;
			return (uint)num;
		}

		public static uint MulByWordAddTo(uint x, uint[] y, uint[] z)
		{
			ulong num = 0uL;
			ulong num2 = (ulong)x;
			num += num2 * (ulong)z[0] + (ulong)y[0];
			z[0] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)z[1] + (ulong)y[1];
			z[1] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)z[2] + (ulong)y[2];
			z[2] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)z[3] + (ulong)y[3];
			z[3] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)z[4] + (ulong)y[4];
			z[4] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)z[5] + (ulong)y[5];
			z[5] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)z[6] + (ulong)y[6];
			z[6] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)z[7] + (ulong)y[7];
			z[7] = (uint)num;
			num >>= 32;
			return (uint)num;
		}

		public static uint MulWordAddTo(uint x, uint[] y, int yOff, uint[] z, int zOff)
		{
			ulong num = 0uL;
			ulong num2 = (ulong)x;
			num += num2 * (ulong)y[yOff] + (ulong)z[zOff];
			z[zOff] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)y[yOff + 1] + (ulong)z[zOff + 1];
			z[zOff + 1] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)y[yOff + 2] + (ulong)z[zOff + 2];
			z[zOff + 2] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)y[yOff + 3] + (ulong)z[zOff + 3];
			z[zOff + 3] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)y[yOff + 4] + (ulong)z[zOff + 4];
			z[zOff + 4] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)y[yOff + 5] + (ulong)z[zOff + 5];
			z[zOff + 5] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)y[yOff + 6] + (ulong)z[zOff + 6];
			z[zOff + 6] = (uint)num;
			num >>= 32;
			num += num2 * (ulong)y[yOff + 7] + (ulong)z[zOff + 7];
			z[zOff + 7] = (uint)num;
			num >>= 32;
			return (uint)num;
		}

		public static uint Mul33DWordAdd(uint x, ulong y, uint[] z, int zOff)
		{
			ulong num = 0uL;
			ulong num2 = (ulong)x;
			ulong num3 = y & (ulong)-1;
			num += num2 * num3 + (ulong)z[zOff];
			z[zOff] = (uint)num;
			num >>= 32;
			ulong num4 = y >> 32;
			num += num2 * num4 + num3 + (ulong)z[zOff + 1];
			z[zOff + 1] = (uint)num;
			num >>= 32;
			num += num4 + (ulong)z[zOff + 2];
			z[zOff + 2] = (uint)num;
			num >>= 32;
			num += (ulong)z[zOff + 3];
			z[zOff + 3] = (uint)num;
			num >>= 32;
			if (num != 0uL)
			{
				return Nat.IncAt(8, z, zOff, 4);
			}
			return 0u;
		}

		public static uint Mul33WordAdd(uint x, uint y, uint[] z, int zOff)
		{
			ulong num = 0uL;
			ulong num2 = (ulong)y;
			num += num2 * (ulong)x + (ulong)z[zOff];
			z[zOff] = (uint)num;
			num >>= 32;
			num += num2 + (ulong)z[zOff + 1];
			z[zOff + 1] = (uint)num;
			num >>= 32;
			num += (ulong)z[zOff + 2];
			z[zOff + 2] = (uint)num;
			num >>= 32;
			if (num != 0uL)
			{
				return Nat.IncAt(8, z, zOff, 3);
			}
			return 0u;
		}

		public static uint MulWordDwordAdd(uint x, ulong y, uint[] z, int zOff)
		{
			ulong num = 0uL;
			ulong num2 = (ulong)x;
			num += num2 * y + (ulong)z[zOff];
			z[zOff] = (uint)num;
			num >>= 32;
			num += num2 * (y >> 32) + (ulong)z[zOff + 1];
			z[zOff + 1] = (uint)num;
			num >>= 32;
			num += (ulong)z[zOff + 2];
			z[zOff + 2] = (uint)num;
			num >>= 32;
			if (num != 0uL)
			{
				return Nat.IncAt(8, z, zOff, 3);
			}
			return 0u;
		}

		public static uint MulWord(uint x, uint[] y, uint[] z, int zOff)
		{
			ulong num = 0uL;
			ulong num2 = (ulong)x;
			int num3 = 0;
			do
			{
				num += num2 * (ulong)y[num3];
				z[zOff + num3] = (uint)num;
				num >>= 32;
			}
			while (++num3 < 8);
			return (uint)num;
		}

		public static void Square(uint[] x, uint[] zz)
		{
			ulong num = (ulong)x[0];
			uint num2 = 0u;
			int num3 = 7;
			int num4 = 16;
			do
			{
				ulong num5 = (ulong)x[num3--];
				ulong num6 = num5 * num5;
				zz[--num4] = (num2 << 31 | (uint)(num6 >> 33));
				zz[--num4] = (uint)(num6 >> 1);
				num2 = (uint)num6;
			}
			while (num3 > 0);
			ulong num7 = num * num;
			ulong num8 = (ulong)((ulong)num2 << 31) | num7 >> 33;
			zz[0] = (uint)num7;
			num2 = ((uint)(num7 >> 32) & 1u);
			ulong num9 = (ulong)x[1];
			ulong num10 = (ulong)zz[2];
			num8 += num9 * num;
			uint num11 = (uint)num8;
			zz[1] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num10 += num8 >> 32;
			ulong num12 = (ulong)x[2];
			ulong num13 = (ulong)zz[3];
			ulong num14 = (ulong)zz[4];
			num10 += num12 * num;
			num11 = (uint)num10;
			zz[2] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num13 += (num10 >> 32) + num12 * num9;
			num14 += num13 >> 32;
			num13 &= (ulong)-1;
			ulong num15 = (ulong)x[3];
			ulong num16 = (ulong)zz[5];
			ulong num17 = (ulong)zz[6];
			num13 += num15 * num;
			num11 = (uint)num13;
			zz[3] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num14 += (num13 >> 32) + num15 * num9;
			num16 += (num14 >> 32) + num15 * num12;
			num14 &= (ulong)-1;
			num17 += num16 >> 32;
			num16 &= (ulong)-1;
			ulong num18 = (ulong)x[4];
			ulong num19 = (ulong)zz[7];
			ulong num20 = (ulong)zz[8];
			num14 += num18 * num;
			num11 = (uint)num14;
			zz[4] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num16 += (num14 >> 32) + num18 * num9;
			num17 += (num16 >> 32) + num18 * num12;
			num16 &= (ulong)-1;
			num19 += (num17 >> 32) + num18 * num15;
			num17 &= (ulong)-1;
			num20 += num19 >> 32;
			num19 &= (ulong)-1;
			ulong num21 = (ulong)x[5];
			ulong num22 = (ulong)zz[9];
			ulong num23 = (ulong)zz[10];
			num16 += num21 * num;
			num11 = (uint)num16;
			zz[5] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num17 += (num16 >> 32) + num21 * num9;
			num19 += (num17 >> 32) + num21 * num12;
			num17 &= (ulong)-1;
			num20 += (num19 >> 32) + num21 * num15;
			num19 &= (ulong)-1;
			num22 += (num20 >> 32) + num21 * num18;
			num20 &= (ulong)-1;
			num23 += num22 >> 32;
			num22 &= (ulong)-1;
			ulong num24 = (ulong)x[6];
			ulong num25 = (ulong)zz[11];
			ulong num26 = (ulong)zz[12];
			num17 += num24 * num;
			num11 = (uint)num17;
			zz[6] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num19 += (num17 >> 32) + num24 * num9;
			num20 += (num19 >> 32) + num24 * num12;
			num19 &= (ulong)-1;
			num22 += (num20 >> 32) + num24 * num15;
			num20 &= (ulong)-1;
			num23 += (num22 >> 32) + num24 * num18;
			num22 &= (ulong)-1;
			num25 += (num23 >> 32) + num24 * num21;
			num23 &= (ulong)-1;
			num26 += num25 >> 32;
			num25 &= (ulong)-1;
			ulong num27 = (ulong)x[7];
			ulong num28 = (ulong)zz[13];
			ulong num29 = (ulong)zz[14];
			num19 += num27 * num;
			num11 = (uint)num19;
			zz[7] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num20 += (num19 >> 32) + num27 * num9;
			num22 += (num20 >> 32) + num27 * num12;
			num23 += (num22 >> 32) + num27 * num15;
			num25 += (num23 >> 32) + num27 * num18;
			num26 += (num25 >> 32) + num27 * num21;
			num28 += (num26 >> 32) + num27 * num24;
			num29 += num28 >> 32;
			num11 = (uint)num20;
			zz[8] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num11 = (uint)num22;
			zz[9] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num11 = (uint)num23;
			zz[10] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num11 = (uint)num25;
			zz[11] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num11 = (uint)num26;
			zz[12] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num11 = (uint)num28;
			zz[13] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num11 = (uint)num29;
			zz[14] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num11 = zz[15] + (uint)(num29 >> 32);
			zz[15] = (num11 << 1 | num2);
		}

		public static void Square(uint[] x, int xOff, uint[] zz, int zzOff)
		{
			ulong num = (ulong)x[xOff];
			uint num2 = 0u;
			int num3 = 7;
			int num4 = 16;
			do
			{
				ulong num5 = (ulong)x[xOff + num3--];
				ulong num6 = num5 * num5;
				zz[zzOff + --num4] = (num2 << 31 | (uint)(num6 >> 33));
				zz[zzOff + --num4] = (uint)(num6 >> 1);
				num2 = (uint)num6;
			}
			while (num3 > 0);
			ulong num7 = num * num;
			ulong num8 = (ulong)((ulong)num2 << 31) | num7 >> 33;
			zz[zzOff] = (uint)num7;
			num2 = ((uint)(num7 >> 32) & 1u);
			ulong num9 = (ulong)x[xOff + 1];
			ulong num10 = (ulong)zz[zzOff + 2];
			num8 += num9 * num;
			uint num11 = (uint)num8;
			zz[zzOff + 1] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num10 += num8 >> 32;
			ulong num12 = (ulong)x[xOff + 2];
			ulong num13 = (ulong)zz[zzOff + 3];
			ulong num14 = (ulong)zz[zzOff + 4];
			num10 += num12 * num;
			num11 = (uint)num10;
			zz[zzOff + 2] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num13 += (num10 >> 32) + num12 * num9;
			num14 += num13 >> 32;
			num13 &= (ulong)-1;
			ulong num15 = (ulong)x[xOff + 3];
			ulong num16 = (ulong)zz[zzOff + 5];
			ulong num17 = (ulong)zz[zzOff + 6];
			num13 += num15 * num;
			num11 = (uint)num13;
			zz[zzOff + 3] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num14 += (num13 >> 32) + num15 * num9;
			num16 += (num14 >> 32) + num15 * num12;
			num14 &= (ulong)-1;
			num17 += num16 >> 32;
			num16 &= (ulong)-1;
			ulong num18 = (ulong)x[xOff + 4];
			ulong num19 = (ulong)zz[zzOff + 7];
			ulong num20 = (ulong)zz[zzOff + 8];
			num14 += num18 * num;
			num11 = (uint)num14;
			zz[zzOff + 4] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num16 += (num14 >> 32) + num18 * num9;
			num17 += (num16 >> 32) + num18 * num12;
			num16 &= (ulong)-1;
			num19 += (num17 >> 32) + num18 * num15;
			num17 &= (ulong)-1;
			num20 += num19 >> 32;
			num19 &= (ulong)-1;
			ulong num21 = (ulong)x[xOff + 5];
			ulong num22 = (ulong)zz[zzOff + 9];
			ulong num23 = (ulong)zz[zzOff + 10];
			num16 += num21 * num;
			num11 = (uint)num16;
			zz[zzOff + 5] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num17 += (num16 >> 32) + num21 * num9;
			num19 += (num17 >> 32) + num21 * num12;
			num17 &= (ulong)-1;
			num20 += (num19 >> 32) + num21 * num15;
			num19 &= (ulong)-1;
			num22 += (num20 >> 32) + num21 * num18;
			num20 &= (ulong)-1;
			num23 += num22 >> 32;
			num22 &= (ulong)-1;
			ulong num24 = (ulong)x[xOff + 6];
			ulong num25 = (ulong)zz[zzOff + 11];
			ulong num26 = (ulong)zz[zzOff + 12];
			num17 += num24 * num;
			num11 = (uint)num17;
			zz[zzOff + 6] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num19 += (num17 >> 32) + num24 * num9;
			num20 += (num19 >> 32) + num24 * num12;
			num19 &= (ulong)-1;
			num22 += (num20 >> 32) + num24 * num15;
			num20 &= (ulong)-1;
			num23 += (num22 >> 32) + num24 * num18;
			num22 &= (ulong)-1;
			num25 += (num23 >> 32) + num24 * num21;
			num23 &= (ulong)-1;
			num26 += num25 >> 32;
			num25 &= (ulong)-1;
			ulong num27 = (ulong)x[xOff + 7];
			ulong num28 = (ulong)zz[zzOff + 13];
			ulong num29 = (ulong)zz[zzOff + 14];
			num19 += num27 * num;
			num11 = (uint)num19;
			zz[zzOff + 7] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num20 += (num19 >> 32) + num27 * num9;
			num22 += (num20 >> 32) + num27 * num12;
			num23 += (num22 >> 32) + num27 * num15;
			num25 += (num23 >> 32) + num27 * num18;
			num26 += (num25 >> 32) + num27 * num21;
			num28 += (num26 >> 32) + num27 * num24;
			num29 += num28 >> 32;
			num11 = (uint)num20;
			zz[zzOff + 8] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num11 = (uint)num22;
			zz[zzOff + 9] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num11 = (uint)num23;
			zz[zzOff + 10] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num11 = (uint)num25;
			zz[zzOff + 11] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num11 = (uint)num26;
			zz[zzOff + 12] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num11 = (uint)num28;
			zz[zzOff + 13] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num11 = (uint)num29;
			zz[zzOff + 14] = (num11 << 1 | num2);
			num2 = num11 >> 31;
			num11 = zz[zzOff + 15] + (uint)(num29 >> 32);
			zz[zzOff + 15] = (num11 << 1 | num2);
		}

		public static int Sub(uint[] x, uint[] y, uint[] z)
		{
			long num = 0L;
			num += (long)((ulong)x[0] - (ulong)y[0]);
			z[0] = (uint)num;
			num >>= 32;
			num += (long)((ulong)x[1] - (ulong)y[1]);
			z[1] = (uint)num;
			num >>= 32;
			num += (long)((ulong)x[2] - (ulong)y[2]);
			z[2] = (uint)num;
			num >>= 32;
			num += (long)((ulong)x[3] - (ulong)y[3]);
			z[3] = (uint)num;
			num >>= 32;
			num += (long)((ulong)x[4] - (ulong)y[4]);
			z[4] = (uint)num;
			num >>= 32;
			num += (long)((ulong)x[5] - (ulong)y[5]);
			z[5] = (uint)num;
			num >>= 32;
			num += (long)((ulong)x[6] - (ulong)y[6]);
			z[6] = (uint)num;
			num >>= 32;
			num += (long)((ulong)x[7] - (ulong)y[7]);
			z[7] = (uint)num;
			num >>= 32;
			return (int)num;
		}

		public static int Sub(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			long num = 0L;
			num += (long)((ulong)x[xOff] - (ulong)y[yOff]);
			z[zOff] = (uint)num;
			num >>= 32;
			num += (long)((ulong)x[xOff + 1] - (ulong)y[yOff + 1]);
			z[zOff + 1] = (uint)num;
			num >>= 32;
			num += (long)((ulong)x[xOff + 2] - (ulong)y[yOff + 2]);
			z[zOff + 2] = (uint)num;
			num >>= 32;
			num += (long)((ulong)x[xOff + 3] - (ulong)y[yOff + 3]);
			z[zOff + 3] = (uint)num;
			num >>= 32;
			num += (long)((ulong)x[xOff + 4] - (ulong)y[yOff + 4]);
			z[zOff + 4] = (uint)num;
			num >>= 32;
			num += (long)((ulong)x[xOff + 5] - (ulong)y[yOff + 5]);
			z[zOff + 5] = (uint)num;
			num >>= 32;
			num += (long)((ulong)x[xOff + 6] - (ulong)y[yOff + 6]);
			z[zOff + 6] = (uint)num;
			num >>= 32;
			num += (long)((ulong)x[xOff + 7] - (ulong)y[yOff + 7]);
			z[zOff + 7] = (uint)num;
			num >>= 32;
			return (int)num;
		}

		public static int SubBothFrom(uint[] x, uint[] y, uint[] z)
		{
			long num = 0L;
			num += (long)((ulong)z[0] - (ulong)x[0] - (ulong)y[0]);
			z[0] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[1] - (ulong)x[1] - (ulong)y[1]);
			z[1] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[2] - (ulong)x[2] - (ulong)y[2]);
			z[2] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[3] - (ulong)x[3] - (ulong)y[3]);
			z[3] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[4] - (ulong)x[4] - (ulong)y[4]);
			z[4] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[5] - (ulong)x[5] - (ulong)y[5]);
			z[5] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[6] - (ulong)x[6] - (ulong)y[6]);
			z[6] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[7] - (ulong)x[7] - (ulong)y[7]);
			z[7] = (uint)num;
			num >>= 32;
			return (int)num;
		}

		public static int SubFrom(uint[] x, uint[] z)
		{
			long num = 0L;
			num += (long)((ulong)z[0] - (ulong)x[0]);
			z[0] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[1] - (ulong)x[1]);
			z[1] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[2] - (ulong)x[2]);
			z[2] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[3] - (ulong)x[3]);
			z[3] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[4] - (ulong)x[4]);
			z[4] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[5] - (ulong)x[5]);
			z[5] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[6] - (ulong)x[6]);
			z[6] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[7] - (ulong)x[7]);
			z[7] = (uint)num;
			num >>= 32;
			return (int)num;
		}

		public static int SubFrom(uint[] x, int xOff, uint[] z, int zOff)
		{
			long num = 0L;
			num += (long)((ulong)z[zOff] - (ulong)x[xOff]);
			z[zOff] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[zOff + 1] - (ulong)x[xOff + 1]);
			z[zOff + 1] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[zOff + 2] - (ulong)x[xOff + 2]);
			z[zOff + 2] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[zOff + 3] - (ulong)x[xOff + 3]);
			z[zOff + 3] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[zOff + 4] - (ulong)x[xOff + 4]);
			z[zOff + 4] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[zOff + 5] - (ulong)x[xOff + 5]);
			z[zOff + 5] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[zOff + 6] - (ulong)x[xOff + 6]);
			z[zOff + 6] = (uint)num;
			num >>= 32;
			num += (long)((ulong)z[zOff + 7] - (ulong)x[xOff + 7]);
			z[zOff + 7] = (uint)num;
			num >>= 32;
			return (int)num;
		}

		public static BigInteger ToBigInteger(uint[] x)
		{
			byte[] array = new byte[32];
			for (int i = 0; i < 8; i++)
			{
				uint num = x[i];
				if (num != 0u)
				{
					Pack.UInt32_To_BE(num, array, 7 - i << 2);
				}
			}
			return new BigInteger(1, array);
		}

		public static BigInteger ToBigInteger64(ulong[] x)
		{
			byte[] array = new byte[32];
			for (int i = 0; i < 4; i++)
			{
				ulong num = x[i];
				if (num != 0uL)
				{
					Pack.UInt64_To_BE(num, array, 3 - i << 3);
				}
			}
			return new BigInteger(1, array);
		}

		public static void Zero(uint[] z)
		{
			z[0] = 0u;
			z[1] = 0u;
			z[2] = 0u;
			z[3] = 0u;
			z[4] = 0u;
			z[5] = 0u;
			z[6] = 0u;
			z[7] = 0u;
		}
	}
}
