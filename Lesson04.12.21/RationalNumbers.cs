using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._12._21
{
    class RationalNumbers
    {
        public int Numerator { get; set; } //Числитель
        public uint Denominator { get; set; } //Знаменатель
        public double Rational => ((double)Numerator) / ((double)Denominator);
        public RationalNumbers(int Numerator, uint Denominator)
        {
            if (Denominator <= 0)
            {
                throw new Exception("Знаменатель не может быть равен нулю!");
            }
            if (Numerator == 0)
            {
                this.Numerator = 0;
                this.Denominator = 1;
                return;
            }

            uint scd;

            if (Numerator > 0)
            {
                scd = SmallestCommonDivisor((uint)Numerator, Denominator);
            }
            else
            {
                scd = SmallestCommonDivisor((uint)-Numerator, Denominator);
            }

            this.Numerator = Numerator / ((int)scd);
            this.Denominator = Denominator / scd;
        }

        public static implicit operator double(RationalNumbers r1) => r1.Rational;
        public static implicit operator RationalNumbers(int r1) => new RationalNumbers(r1, 1);


        public static bool operator ==(RationalNumbers r1, RationalNumbers r2) //==
        {
            return (r1 - r2).Numerator == 0;
        }
        public static bool operator !=(RationalNumbers r1, RationalNumbers r2) //!=
        {
            return !(r1 == r2);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is RationalNumbers))
            {
                //Если obj не объект RationalNumbets, то возвращает false
                return false;
            }
            else
            {
                //Иначе возвращает число
                var number = (RationalNumbers)obj;
                return Numerator == number.Numerator &&
                       Denominator == number.Denominator;
            }
        }


        public static bool operator >(RationalNumbers r1, RationalNumbers r2) //>
        {
            return (r1.Numerator * r2.Denominator) > (r1.Denominator * r2.Numerator);
        }
        public static bool operator <(RationalNumbers r1, RationalNumbers r2) //<
        {
            return (r1.Numerator * r2.Denominator) < (r1.Denominator * r2.Numerator);
        }
        public static bool operator <=(RationalNumbers r1, RationalNumbers r2) //<=
        {
            return !(r1 > r2);
        }
        public static bool operator >=(RationalNumbers r1, RationalNumbers r2) //>=
        {
            return !(r1 < r2);
        }
        public static RationalNumbers operator -(RationalNumbers r1, RationalNumbers r2) //-
        {
            return (r1 + (-1 * r2));
        }
        public static RationalNumbers operator +(RationalNumbers r1, RationalNumbers r2) //+
        {
            return new RationalNumbers
                (
                    (int)(r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator),
                    r1.Denominator * r2.Denominator
                );
        }
        public static RationalNumbers operator ++(RationalNumbers r1) //++
        {
            return new RationalNumbers((int)(r1.Numerator + r1.Denominator), r1.Denominator);
        }

        public static RationalNumbers operator --(RationalNumbers r1) //--
        {
            return new RationalNumbers((int)(r1.Numerator - r1.Denominator), r1.Denominator);
        }
        public static RationalNumbers operator *(RationalNumbers r1, RationalNumbers r2) //*
        {
            return new RationalNumbers
                (
                    (int)(r1.Numerator * r2.Numerator),
                    (uint)(r1.Denominator * r2.Denominator)
                );
        }
        public static RationalNumbers operator /(RationalNumbers r1, RationalNumbers r2) //:
        {
            return r1.Numerator * r2.Numerator < 0
                ? new RationalNumbers((int)-r2.Denominator, (uint)-r2.Numerator)
                : new RationalNumbers((int)r2.Denominator, (uint)r2.Numerator);
        }
        public static RationalNumbers operator %(RationalNumbers x, RationalNumbers y) //%
        {
            return x - (RationalNumbers)(int)(x / y) * y;
        }


        public static explicit operator RationalNumbers(float r1)
        {
            int factor = (int)Math.Pow(10, GetDecimalDigitsCount(r1));
            return new RationalNumbers(Convert.ToInt32(r1 * factor), (uint)factor);
        }

        public static explicit operator float(RationalNumbers r1)
        {
            return Convert.ToSingle(r1.Numerator) / r1.Denominator;
        }

        public static explicit operator int(RationalNumbers r1)
        {
            return (int)(r1.Numerator / r1.Denominator);
        }



        /// <summary>Статический метод возвращающий НОД двух положительных чисел</summary>
        /// <param name="first">Первое число</param>
        /// <param name="second">Второе число</param>
        /// <returns>Ноль - если оба чисела равно нулю, в остальных случаях НОД</returns>
        public static uint SmallestCommonDivisor(uint first, uint second)
        {
            uint C = first;
            first = first > second ? first : second;
            second = C > second ? second : C;
            C = first % second;
            if (C == 0) return second;
            return SmallestCommonDivisor(second, C);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }


        public static int GetDecimalDigitsCount(float num)
        {
            string str = num.ToString();
            if (str.Contains(","))
            {
                return str.Length - str.IndexOf(',') - 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
