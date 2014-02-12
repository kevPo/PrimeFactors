using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public class PrimeFactors
    {
        public static List<Int32> Generate(Int32 number)
        {
            var primes = new List<Int32>();

            if (number > 1)
            {
                if (IsEven(number))
                {
                    primes.Add(2);
                    number /= 2;
                }
                if (number > 1)
                    primes.Add(number);
            }

            return primes;
        }

        private static Boolean IsEven(Int32 number)
        {
            return number % 2 == 0;
        }
    }
}
