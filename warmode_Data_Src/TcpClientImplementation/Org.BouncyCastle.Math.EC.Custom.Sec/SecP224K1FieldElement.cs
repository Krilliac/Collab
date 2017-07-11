using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using System;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	internal class SecP224K1FieldElement : ECFieldElement
	{
		public static readonly BigInteger Q = SecP224K1Curve.q;

		private static readonly uint[] PRECOMP_POW2 = new uint[]
		{
			868209154u,
			3707425075u,
			579297866u,
			3280018344u,
			2824165628u,
			514782679u,
			2396984652u
		};

		protected internal readonly uint[] x;

		public override bool IsZero
		{
			get
			{
				return Nat224.IsZero(this.x);
			}
		}

		public override bool IsOne
		{
			get
			{
				return Nat224.IsOne(this.x);
			}
		}

		public override string FieldName
		{
			get
			{
				return "SecP224K1Field";
			}
		}

		public override int FieldSize
		{
			get
			{
				return SecP224K1FieldElement.Q.BitLength;
			}
		}

		public SecP224K1FieldElement(BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.CompareTo(SecP224K1FieldElement.Q) >= 0)
			{
				throw new ArgumentException("value invalid for SecP224K1FieldElement", "x");
			}
			this.x = SecP224K1Field.FromBigInteger(x);
		}

		public SecP224K1FieldElement()
		{
			this.x = Nat224.Create();
		}

		protected internal SecP224K1FieldElement(uint[] x)
		{
			this.x = x;
		}

		public override bool TestBitZero()
		{
			return Nat224.GetBit(this.x, 0) == 1u;
		}

		public override BigInteger ToBigInteger()
		{
			return Nat224.ToBigInteger(this.x);
		}

		public override ECFieldElement Add(ECFieldElement b)
		{
			uint[] z = Nat224.Create();
			SecP224K1Field.Add(this.x, ((SecP224K1FieldElement)b).x, z);
			return new SecP224K1FieldElement(z);
		}

		public override ECFieldElement AddOne()
		{
			uint[] z = Nat224.Create();
			SecP224K1Field.AddOne(this.x, z);
			return new SecP224K1FieldElement(z);
		}

		public override ECFieldElement Subtract(ECFieldElement b)
		{
			uint[] z = Nat224.Create();
			SecP224K1Field.Subtract(this.x, ((SecP224K1FieldElement)b).x, z);
			return new SecP224K1FieldElement(z);
		}

		public override ECFieldElement Multiply(ECFieldElement b)
		{
			uint[] z = Nat224.Create();
			SecP224K1Field.Multiply(this.x, ((SecP224K1FieldElement)b).x, z);
			return new SecP224K1FieldElement(z);
		}

		public override ECFieldElement Divide(ECFieldElement b)
		{
			uint[] z = Nat224.Create();
			Mod.Invert(SecP224K1Field.P, ((SecP224K1FieldElement)b).x, z);
			SecP224K1Field.Multiply(z, this.x, z);
			return new SecP224K1FieldElement(z);
		}

		public override ECFieldElement Negate()
		{
			uint[] z = Nat224.Create();
			SecP224K1Field.Negate(this.x, z);
			return new SecP224K1FieldElement(z);
		}

		public override ECFieldElement Square()
		{
			uint[] z = Nat224.Create();
			SecP224K1Field.Square(this.x, z);
			return new SecP224K1FieldElement(z);
		}

		public override ECFieldElement Invert()
		{
			uint[] z = Nat224.Create();
			Mod.Invert(SecP224K1Field.P, this.x, z);
			return new SecP224K1FieldElement(z);
		}

		public override ECFieldElement Sqrt()
		{
			uint[] y = this.x;
			if (Nat224.IsZero(y) || Nat224.IsOne(y))
			{
				return this;
			}
			uint[] array = Nat224.Create();
			SecP224K1Field.Square(y, array);
			SecP224K1Field.Multiply(array, y, array);
			uint[] array2 = array;
			SecP224K1Field.Square(array, array2);
			SecP224K1Field.Multiply(array2, y, array2);
			uint[] array3 = Nat224.Create();
			SecP224K1Field.Square(array2, array3);
			SecP224K1Field.Multiply(array3, y, array3);
			uint[] array4 = Nat224.Create();
			SecP224K1Field.SquareN(array3, 4, array4);
			SecP224K1Field.Multiply(array4, array3, array4);
			uint[] array5 = Nat224.Create();
			SecP224K1Field.SquareN(array4, 3, array5);
			SecP224K1Field.Multiply(array5, array2, array5);
			uint[] array6 = array5;
			SecP224K1Field.SquareN(array5, 8, array6);
			SecP224K1Field.Multiply(array6, array4, array6);
			uint[] array7 = array4;
			SecP224K1Field.SquareN(array6, 4, array7);
			SecP224K1Field.Multiply(array7, array3, array7);
			uint[] array8 = array3;
			SecP224K1Field.SquareN(array7, 19, array8);
			SecP224K1Field.Multiply(array8, array6, array8);
			uint[] array9 = Nat224.Create();
			SecP224K1Field.SquareN(array8, 42, array9);
			SecP224K1Field.Multiply(array9, array8, array9);
			uint[] z = array8;
			SecP224K1Field.SquareN(array9, 23, z);
			SecP224K1Field.Multiply(z, array7, z);
			uint[] array10 = array7;
			SecP224K1Field.SquareN(z, 84, array10);
			SecP224K1Field.Multiply(array10, array9, array10);
			uint[] z2 = array10;
			SecP224K1Field.SquareN(z2, 20, z2);
			SecP224K1Field.Multiply(z2, array6, z2);
			SecP224K1Field.SquareN(z2, 3, z2);
			SecP224K1Field.Multiply(z2, y, z2);
			SecP224K1Field.SquareN(z2, 2, z2);
			SecP224K1Field.Multiply(z2, y, z2);
			SecP224K1Field.SquareN(z2, 4, z2);
			SecP224K1Field.Multiply(z2, array2, z2);
			SecP224K1Field.Square(z2, z2);
			uint[] array11 = array9;
			SecP224K1Field.Square(z2, array11);
			if (Nat224.Eq(y, array11))
			{
				return new SecP224K1FieldElement(z2);
			}
			SecP224K1Field.Multiply(z2, SecP224K1FieldElement.PRECOMP_POW2, z2);
			SecP224K1Field.Square(z2, array11);
			if (Nat224.Eq(y, array11))
			{
				return new SecP224K1FieldElement(z2);
			}
			return null;
		}

		public override bool Equals(object obj)
		{
			return this.Equals(obj as SecP224K1FieldElement);
		}

		public override bool Equals(ECFieldElement other)
		{
			return this.Equals(other as SecP224K1FieldElement);
		}

		public virtual bool Equals(SecP224K1FieldElement other)
		{
			return this == other || (other != null && Nat224.Eq(this.x, other.x));
		}

		public override int GetHashCode()
		{
			return SecP224K1FieldElement.Q.GetHashCode() ^ Arrays.GetHashCode(this.x, 0, 7);
		}
	}
}