using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitSamples
{
    public class Calculator
    {
        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }

        public int Add(int one, int two)
        {
            return one + two;
        }

        public int Addition(int v1, int v2, int v3)
        {
            return v1 + v2 + v3;
        }

        public int Multiplication(int v1, int v2, int v3)
        {
           return v1 * v2 * v3;
        }
    }
}
