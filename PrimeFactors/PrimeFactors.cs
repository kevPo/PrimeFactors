using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public class PrimeFactors
    {
        public static List<Int32> Generate(Int32 number)
        {
            if (number > 1)
                return new List<Int32> { number };

            return new List<Int32>();
        }
    }
}
