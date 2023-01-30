using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Linear : Root
    {
        private double x;
        public Linear(double a, double b) : base (a, b)
        {
            A = a;
            B = b;
        }

        public override string getSquare()
        {
            return $"Square: {x = -B / A}";
        }
    }
}