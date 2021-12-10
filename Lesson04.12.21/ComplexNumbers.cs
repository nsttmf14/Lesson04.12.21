using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._12._21
{
    public class ComplexNumbers
    {
        public double Real, Image;

        public ComplexNumbers(double real, double image)
        {
            Real = real;
            Image = image;
        }
        public static bool operator ==(ComplexNumbers r1, ComplexNumbers r2)
        {
            return r1.Real == r2.Real && r1.Image == r2.Image;
        }

        public static bool operator !=(ComplexNumbers r1, ComplexNumbers r2)
        {
            return !(r1.Real == r2.Real && r1.Image == r2.Image);
        }

        public static ComplexNumbers operator +(ComplexNumbers r1, ComplexNumbers r2) //+
        {
            return new ComplexNumbers(r1.Real + r2.Real, r1.Image + r2.Image);
        }

        public static ComplexNumbers operator -(ComplexNumbers r1, ComplexNumbers r2) //-
        {
            return new ComplexNumbers(r1.Real - r2.Real, r1.Image - r2.Image);
        }

        public static ComplexNumbers operator *(ComplexNumbers r1, ComplexNumbers r2) //*
        {
            return new ComplexNumbers(r1.Real * r2.Real - r1.Image * r2.Image,
                r1.Real * r2.Image + r1.Image * r2.Real);
        }
        public override bool Equals(object obj) //Сравнение
        {
            double number;
            if (obj is ComplexNumbers)
            {
                return Real == (obj as ComplexNumbers).Real && Image == (obj as ComplexNumbers).Image;
            }
            else if (Image == 0 && double.TryParse(obj.ToString(), out number))
            {
                return Real == number;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            double x = Real, y = Image;
            if (y == 0) return $"{x}";
            else if (y > 0) return $"{x} + {y}i";
            else return $"{x} - {-y}i";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
