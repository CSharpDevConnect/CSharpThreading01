using System;
using System.Collections.Generic;

namespace ComputePrimes
{
    /// <summary>
    /// Single-threaded implementation for computing the number of primes in ranges.
    /// </summary>
    public class PrimeRangeComputer : IPrimeRangeComputer
    {
        /// <summary>
        /// Given an enumerable of ranges, computes the number of primes within each range and passes
        /// the result to the provided action (not necessarily in the same order they were provided).
        /// </summary>
        /// <param name="ranges">The ranges.</param>
        /// <param name="action">The action to run for each result.</param>
        public void ComputePrimeCount(IEnumerable<Tuple<int, int>> ranges, Action<PrimeRangeResult> action)
        {
            foreach (var range in ranges)
            {
                action(Helpers.ComputePrimeCount(range.Item1, range.Item2));
            }
        }
    }
}

