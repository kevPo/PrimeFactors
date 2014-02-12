using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public class PrimeFactors
    {
        public static IEnumerable<Int32> Generate(Int32 number)
        {
            for (var divisor = 2; number > 1; divisor++)
            {
                while (number % divisor == 0)
                {
                    yield return divisor;
                    number /= divisor;
                }
            }
        }
    }
}
