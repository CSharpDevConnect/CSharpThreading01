using System;

namespace ComputePrimes
{
    public class PrimeRangeResult
    {
        public PrimeRangeResult(int lowerBound, int upperBound, int primeCount)
        {
            LowerBound = lowerBound;
            UpperBound = upperBound;
            PrimeCount = primeCount;
        }

        public int LowerBound { get; private set; }

        public int UpperBound { get; private set; }

        public int PrimeCount { get; private set; }
    }
}

