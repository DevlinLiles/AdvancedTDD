using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class FizzBuzz
    {
        public string GenerateNumberAnswer(int number)
        {
            if (number > 100 || number < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Range 1-100");
            }
            string result = string.Empty;
            if (number%3 == 0)
            {
                result += "Fizz";
            }
            if (number%5 == 0)
            {
                result += "Buzz";
            }
            if (string.IsNullOrEmpty(result))
            {
                result = number.ToString();
            }
            return result;
        }
    }
}
