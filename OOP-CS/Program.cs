using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            //point.SetX(2);
            //point.SetY(3);
            // point1.Print();

            point1.X = 7;
            point1.Y = 8;
            Console.WriteLine($"p1: X = {point1.X}, Y = {point1.Y}");

            Point point2 = new Point();

            point2.X = 10;
            point2.Y = 12;
            Console.WriteLine($"p2: X = {point2.X}, Y = {point2.Y}");

            Console.WriteLine($"The distanse between points is equal {point1.Distance(point2)}");
        }
    }
}
