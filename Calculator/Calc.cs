using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public int Add(int one, int two)
        {
            if (one == int.MaxValue || two == int.MaxValue)
            {
                throw new InvalidOperationException("Cannot Add to Max");
            }
            return one + two;
        }

        public int Subtract(int one, int two)
        {
            if (one == int.MinValue)
            {
                throw new InvalidOperationException("Cannot subtract from min");
            }
            return one - two;
        }

        public int Multiply(int one, int two)
        {
            if ((one == int.MaxValue || two == int.MaxValue) && one != 0 && Math.Abs(one) != 1 && two != 0 &&
                Math.Abs(two) != 1)
            {
                throw new InvalidOperationException("Overflow");
            }
            return one*two;
        }

        public double Divide(int one, int two)
        {
            return -1;
        }
    }
}
