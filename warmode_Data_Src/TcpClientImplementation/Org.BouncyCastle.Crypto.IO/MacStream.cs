using System;
using System.IO;

namespace Org.BouncyCastle.Crypto.IO
{
	public class MacStream : Stream
	{
		protected readonly Stream stream;

		protected readonly IMac inMac;

		protected readonly IMac outMac;

		public override bool CanRead
		{
			get
			{
				return this.stream.CanRead;
			}
		}

		public override bool CanWrite
		{
			get
			{
				return this.stream.CanWrite;
			}
		}

		public override bool CanSeek
		{
			get
			{
				return this.stream.CanSeek;
			}
		}

		public override long Length
		{
			get
			{
				return this.stream.Length;
			}
		}

		public override long Position
		{
			get
			{
				return this.stream.Position;
			}
			set
			{
				this.stream.Position = value;
			}
		}

		public MacStream(Stream stream, IMac readMac, IMac writeMac)
		{
			this.stream = stream;
			this.inMac = readMac;
			this.outMac = writeMac;
		}

		public virtual IMac ReadMac()
		{
			return this.inMac;
		}

		public virtual IMac WriteMac()
		{
			return this.outMac;
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			int num = this.stream.Read(buffer, offset, count);
			if (this.inMac != null && num > 0)
			{
				this.inMac.BlockUpdate(buffer, offset, num);
			}
			return num;
		}

		public override int ReadByte()
		{
			int num = this.stream.ReadByte();
			if (this.inMac != null && num >= 0)
			{
				this.inMac.Update((byte)num);
			}
			return num;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this.outMac != null && count > 0)
			{
				this.outMac.BlockUpdate(buffer, offset, count);
			}
			this.stream.Write(buffer, offset, count);
		}

		public override void WriteByte(byte b)
		{
			if (this.outMac != null)
			{
				this.outMac.Update(b);
			}
			this.stream.WriteByte(b);
		}

		public override void Close()
		{
			this.stream.Close();
		}

		public override void Flush()
		{
			this.stream.Flush();
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return this.stream.Seek(offset, origin);
		}

		public override void SetLength(long length)
		{
			this.stream.SetLength(length);
		}
	}
}
