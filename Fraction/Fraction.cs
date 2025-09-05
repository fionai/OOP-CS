using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public void Print()
        {
            Console.Write($"{Numerator}/{Denominator}");
        }

        public int GCD() 
        {
            int big, small, buf;
            if (Numerator != 0 & Denominator != 0)
            {
                if (Numerator > Denominator)
                {
                    big = Numerator;
                    small = Denominator;
                }
                else if (Denominator > Numerator)
                {
                    big = Denominator;
                    small = Numerator;
                }
                else
                    return Numerator;
                while ((big % small) != 0)
                {
                    buf = big % small;
                    big = small;
                    small = buf;
                }
                return small; 
            }
            else return 1;
        }
        public Fraction Normal()
        {
            if (Numerator == 0)
            {
                Denominator = 1;
            }
            else
            {
                int gcd = GCD();
                Numerator /= gcd;
                Denominator /= gcd;
            }
            return this;
        }
        public Fraction Sum(Fraction other)
        {
            Fraction result = new Fraction();
            if (Denominator != 0 & other.Denominator != 0)
            {
                result.Numerator = Numerator * other.Denominator + other.Numerator * Denominator;
                result.Denominator = Denominator * other.Denominator;
                result.Normal();
                return result;
            }
            else
            {
                result.Numerator = 0;
                result.Denominator = 1;
                return result;
            }
        }
        public static Fraction operator+ (Fraction n1, Fraction other)
        {
            Fraction result = new Fraction();
            if (n1.Denominator != 0 & other.Denominator != 0)
            {
                result.Numerator = n1.Numerator * other.Denominator + other.Numerator * n1.Denominator;
                result.Denominator = n1.Denominator * other.Denominator;
                result.Normal();
                return result;
            }
            else
            {
                result.Numerator = 0;
                result.Denominator = 1;
                return result;
            }
        }
        public Fraction Sub(Fraction other)
        {
            Fraction result = new Fraction();
            if (Denominator != 0 & other.Denominator != 0)
            {
                result.Numerator = Numerator * other.Denominator - other.Numerator * Denominator;
                result.Denominator = Denominator * other.Denominator;
                result.Normal();
                return result;
            }
            else
            {
                result.Numerator = 0;
                result.Denominator = 1;
                return result;
            }
        }
        public static Fraction operator -(Fraction n1, Fraction other)
        {
            Fraction result = new Fraction();
            if (n1.Denominator != 0 & other.Denominator != 0)
            {
                result.Numerator = n1.Numerator * other.Denominator - other.Numerator * n1.Denominator;
                result.Denominator = n1.Denominator * other.Denominator;
                result.Normal();
                return result;
            }
            else
            {
                result.Numerator = 0;
                result.Denominator = 1;
                return result;
            }
        }

        public Fraction Mul(Fraction other)
        {
            Fraction result = new Fraction();
            if (Denominator != 0 & other.Denominator != 0)
            {
                result.Numerator = Numerator * other.Numerator;
                result.Denominator = Denominator * other.Denominator;
                result.Normal();
                return result;
            }
            else
            {
                result.Numerator = 0;
                result.Denominator = 1;
                return result;
            }
        }
        public static Fraction operator *(Fraction n1, Fraction other)
        {
            Fraction result = new Fraction();
            if (n1.Denominator != 0 & other.Denominator != 0)
            {
                result.Numerator = n1.Numerator * other.Numerator;
                result.Denominator = n1.Denominator * other.Denominator;
                result.Normal();
                return result;
            }
            else
            {
                result.Numerator = 0;
                result.Denominator = 1;
                return result;
            }
        }

        public Fraction Div(Fraction other)
        {
            Fraction result = new Fraction();
            if (Denominator != 0 & other.Denominator != 0)
            {
                result.Numerator = Numerator * other.Denominator;
                result.Denominator = Denominator * other.Numerator;
                result.Normal();
                return result;
            }
            else
            {
                result.Numerator = 0;
                result.Denominator = 1;
                return result;
            }
        }
        public static Fraction operator /(Fraction n1, Fraction other)
        {
            Fraction result = new Fraction();
            if (n1.Denominator != 0 & other.Denominator != 0)
            {
                result.Numerator = n1.Numerator * other.Denominator;
                result.Denominator = n1.Denominator * other.Numerator;
                result.Normal();
                return result;
            }
            else
            {
                result.Numerator = 0;
                result.Denominator = 1;
                return result;
            }
        }
    }//Fraction
}
