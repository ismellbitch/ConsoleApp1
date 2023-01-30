using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Square : Root
    {
        private double d;
        public double x;
        public double y;
        public double c;
        public double C 
        { 
            get { return c; }
            set { c = value; }
        }
        public Square(double a, double b, double c) : base(a, b)
        {
            A = a;
            B = b;
            C = c;
        }

        public override string getSquare()
        {
            d = Math.Pow(B, 2) - 4 * A * C;
            if (d < 0) return "No solution?";
            else if (d == 0) return "x1 = 0, x2 = 0";
            else return $"x1 = {-B - Math.Sqrt(d) / 2 * A}, x2 = {-B + Math.Sqrt(d) / 2 * A}";
        }
    }
}