using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Point
    {
        //double x, y;

        //Properties:
        //public double X
        //{
        //    get { return x; }
        //    set { x = value; }
        //}
        //public double Y
        //{
        //    get { return y; }
        //    set { y = value; }
        //}
        //public double GetX()
        //{
        //    return x;
        //}
        //public double GetY()
        //{
        //    return y;
        //}
        //public void SetX(double x)
        //{
        //    this.x = x;
        //}
        //public void SetY(double y)
        //{
        //    this.y = y;
        //}

        public double X { get; set; }
        public double Y { get; set; }

        //methods
        public void Print()
        {
            Console.WriteLine($"X = {X}, Y = {Y}"); 
        }

        public double Distance(Point other)
        {
            return Math.Sqrt((this.X - other.X) * (this.X - other.X) + (this.Y - other.Y) * (this.Y - other.Y));
        }
    } //Point
}
