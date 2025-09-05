using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction num1 = new Fraction();
            num1.Numerator = 2;
            num1.Denominator = 3;
            Console.Write("num1 = ");
            num1.Print();
            Console.WriteLine();

            Fraction num2 = new Fraction();
            num2.Numerator = 4;
            num2.Denominator = 5;
            Console.Write("num2 = ");
            num2.Print();
            Console.WriteLine();

            Fraction result = new Fraction();
            result = num1.Sum(num2);
            Console.Write($"{num1.Numerator}/{num1.Denominator} Sum {num2.Numerator}/{num2.Denominator} \t= ");
            result.Print();
            Console.WriteLine();

            result = num1 + num2;
            Console.Write($"{num1.Numerator}/{num1.Denominator} + {num2.Numerator}/{num2.Denominator} \t= ");
            result.Print();
            Console.WriteLine();

            result = num1.Sub(num2);
            Console.Write($"{num1.Numerator}/{num1.Denominator} Sub {num2.Numerator}/{num2.Denominator} \t= ");
            result.Print(); 
            Console.WriteLine();

            result = num1 - num2;
            Console.Write($"{num1.Numerator}/{num1.Denominator} - {num2.Numerator}/{num2.Denominator} \t= ");
            result.Print();
            Console.WriteLine();

            result = num1.Mul(num2);
            Console.Write($"{num1.Numerator}/{num1.Denominator} Mul {num2.Numerator}/{num2.Denominator} \t= ");
            result.Print();
            Console.WriteLine();

            result = num1 * num2;
            Console.Write($"{num1.Numerator}/{num1.Denominator} * {num2.Numerator}/{num2.Denominator} \t= ");
            result.Print();
            Console.WriteLine();

            result = num1.Div(num2);
            Console.Write($"{num1.Numerator}/{num1.Denominator} Div {num2.Numerator}/{num2.Denominator} \t= ");
            result.Print();
            Console.WriteLine();

            result = num1 / num2;
            Console.Write($"{num1.Numerator}/{num1.Denominator} / {num2.Numerator}/{num2.Denominator} \t= ");
            result.Print();
            Console.WriteLine();
        }
    }
}
