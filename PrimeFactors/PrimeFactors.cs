using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public class PrimeFactors
    {
        public static List<Int32> Generate(Int32 number)
        {
            var primes = new List<Int32>();
            
            for (var divisor = 2; number > 1; divisor++)
            {
                while (number % divisor == 0)
                {
                    primes.Add(divisor);
                    number /= divisor;
                }
            }
            
            return primes;
        }
    }
}
