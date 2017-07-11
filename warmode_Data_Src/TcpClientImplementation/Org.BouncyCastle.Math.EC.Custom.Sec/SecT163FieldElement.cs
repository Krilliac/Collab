using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using System;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	internal class SecT163FieldElement : ECFieldElement
	{
		protected readonly ulong[] x;

		public override bool IsOne
		{
			get
			{
				return Nat192.IsOne64(this.x);
			}
		}

		public override bool IsZero
		{
			get
			{
				return Nat192.IsZero64(this.x);
			}
		}

		public override string FieldName
		{
			get
			{
				return "SecT163Field";
			}
		}

		public override int FieldSize
		{
			get
			{
				return 163;
			}
		}

		public virtual int Representation
		{
			get
			{
				return 3;
			}
		}

		public virtual int M
		{
			get
			{
				return 163;
			}
		}

		public virtual int K1
		{
			get
			{
				return 3;
			}
		}

		public virtual int K2
		{
			get
			{
				return 6;
			}
		}

		public virtual int K3
		{
			get
			{
				return 7;
			}
		}

		public SecT163FieldElement(BigInteger x)
		{
			if (x == null || x.SignValue < 0)
			{
				throw new ArgumentException("value invalid for SecT163FieldElement", "x");
			}
			this.x = SecT163Field.FromBigInteger(x);
		}

		public SecT163FieldElement()
		{
			this.x = Nat192.Create64();
		}

		protected internal SecT163FieldElement(ulong[] x)
		{
			this.x = x;
		}

		public override bool TestBitZero()
		{
			return (this.x[0] & 1uL) != 0uL;
		}

		public override BigInteger ToBigInteger()
		{
			return Nat192.ToBigInteger64(this.x);
		}

		public override ECFieldElement Add(ECFieldElement b)
		{
			ulong[] z = Nat192.Create64();
			SecT163Field.Add(this.x, ((SecT163FieldElement)b).x, z);
			return new SecT163FieldElement(z);
		}

		public override ECFieldElement AddOne()
		{
			ulong[] z = Nat192.Create64();
			SecT163Field.AddOne(this.x, z);
			return new SecT163FieldElement(z);
		}

		public override ECFieldElement Subtract(ECFieldElement b)
		{
			return this.Add(b);
		}

		public override ECFieldElement Multiply(ECFieldElement b)
		{
			ulong[] z = Nat192.Create64();
			SecT163Field.Multiply(this.x, ((SecT163FieldElement)b).x, z);
			return new SecT163FieldElement(z);
		}

		public override ECFieldElement MultiplyMinusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
		{
			return this.MultiplyPlusProduct(b, x, y);
		}

		public override ECFieldElement MultiplyPlusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
		{
			ulong[] array = this.x;
			ulong[] y2 = ((SecT163FieldElement)b).x;
			ulong[] array2 = ((SecT163FieldElement)x).x;
			ulong[] y3 = ((SecT163FieldElement)y).x;
			ulong[] array3 = Nat192.CreateExt64();
			SecT163Field.MultiplyAddToExt(array, y2, array3);
			SecT163Field.MultiplyAddToExt(array2, y3, array3);
			ulong[] z = Nat192.Create64();
			SecT163Field.Reduce(array3, z);
			return new SecT163FieldElement(z);
		}

		public override ECFieldElement Divide(ECFieldElement b)
		{
			return this.Multiply(b.Invert());
		}

		public override ECFieldElement Negate()
		{
			return this;
		}

		public override ECFieldElement Square()
		{
			ulong[] z = Nat192.Create64();
			SecT163Field.Square(this.x, z);
			return new SecT163FieldElement(z);
		}

		public override ECFieldElement SquareMinusProduct(ECFieldElement x, ECFieldElement y)
		{
			return this.SquarePlusProduct(x, y);
		}

		public override ECFieldElement SquarePlusProduct(ECFieldElement x, ECFieldElement y)
		{
			ulong[] array = this.x;
			ulong[] array2 = ((SecT163FieldElement)x).x;
			ulong[] y2 = ((SecT163FieldElement)y).x;
			ulong[] array3 = Nat192.CreateExt64();
			SecT163Field.SquareAddToExt(array, array3);
			SecT163Field.MultiplyAddToExt(array2, y2, array3);
			ulong[] z = Nat192.Create64();
			SecT163Field.Reduce(array3, z);
			return new SecT163FieldElement(z);
		}

		public override ECFieldElement SquarePow(int pow)
		{
			if (pow < 1)
			{
				return this;
			}
			ulong[] z = Nat192.Create64();
			SecT163Field.SquareN(this.x, pow, z);
			return new SecT163FieldElement(z);
		}

		public override ECFieldElement Invert()
		{
			return new SecT163FieldElement(AbstractF2mCurve.Inverse(163, new int[]
			{
				3,
				6,
				7
			}, this.ToBigInteger()));
		}

		public override ECFieldElement Sqrt()
		{
			return this.SquarePow(this.M - 1);
		}

		public override bool Equals(object obj)
		{
			return this.Equals(obj as SecT163FieldElement);
		}

		public override bool Equals(ECFieldElement other)
		{
			return this.Equals(other as SecT163FieldElement);
		}

		public virtual bool Equals(SecT163FieldElement other)
		{
			return this == other || (other != null && Nat192.Eq64(this.x, other.x));
		}

		public override int GetHashCode()
		{
			return 163763 ^ Arrays.GetHashCode(this.x, 0, 3);
		}
	}
}