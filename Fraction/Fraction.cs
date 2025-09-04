using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Fraction
    {
        public double Numerator {  get; set; }    
        public double Denominator { get; set; }

        public void Print ()
        {
            Console.Write($"{Numerator}/{Denominator}");
        }

    }//Fraction
}
