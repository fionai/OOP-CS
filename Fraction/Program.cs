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


        }
    }
}
