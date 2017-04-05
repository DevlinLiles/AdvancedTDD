using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD
{
    public class Calculator
    {
        public long Add(long one, long two)
        {
            if (one == long.MaxValue || two == long.MaxValue)
            {
                throw new InvalidOperationException("Unable to add values");
            }
            return one + two;
        }

        public decimal Subtract(params decimal[] inputs)
        {
            decimal result = inputs[0];
            for (int i = 1; i < inputs.Length; i++)
            {
                result -= inputs[i];
            }
            return Math.Round(result, MidpointRounding.AwayFromZero);
        }
    }
}
