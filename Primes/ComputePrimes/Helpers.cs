using System;
using System.Collections.Generic;

namespace ComputePrimes
{
    /// <summary>
    /// Contains some helper methods for computing primes.
    /// </summary>
    public static class Helpers
    {
        /// <summary>
        /// Computes the number of primes within a range using the Sieve of Eratosthenes algorithm.
        /// </summary>
        /// <returns>The number of primes within the provided range.</returns>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="upperBound">Upper bound.</param>
        public static PrimeRangeResult ComputePrimeCount(int lowerBound, int upperBound)
        {
            var sieve = new bool[upperBound - 1];

            for (int num = 2; num <= Math.Sqrt(upperBound); num++)
            {
                if (sieve[num - 2] == true)
                {
                    continue;
                }

                for (int multiple = 2 * num; multiple <= upperBound; multiple += num)
                {
                    sieve[multiple - 2] = true;
                }
            }

            int primeCount = 0;

            for (int num = Math.Max(2, lowerBound); num <= upperBound; num++)
            {
                if (sieve[num - 2] == false)
                {
                    primeCount++;
                }
            }

            return new PrimeRangeResult(lowerBound, upperBound, primeCount);
        }
    }
}

