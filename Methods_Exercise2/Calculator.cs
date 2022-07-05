using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Exercise2
{
    internal class Calculator
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Sum(int x, int y, int z)
        { 
            return x + y + z; 
        }

        public static int Sum(int a, int b, int c, int d, int e)
            { return a + b + c + d + e; }

        public static int Multiply(int x, int y)

        { return x * y; }

        public static int Divide(int x, int y)
            { return x / y; }
    }
}
