using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComputePrimes
{
    /// <summary>
    /// Implementation of computing the number of primes in ranges, which uses Tasks to
    /// parallellize work.
    /// </summary>
    public class ParallelPrimeRangeComputer : IPrimeRangeComputer
    {
        /// <summary>
        /// Given an enumerable of ranges, computes the number of primes within each range and passes
        /// the result to the provided action (not necessarily in the same order they were provided).
        /// </summary>
        /// <param name="ranges">The ranges.</param>
        /// <param name="action">The action to run for each result.</param>
        public void ComputePrimeCount(IEnumerable<Tuple<int, int>> ranges, Action<PrimeRangeResult> action)
        {
            Parallel.ForEach(ranges, range => action(Helpers.ComputePrimeCount(range.Item1, range.Item2)));
        }
    }
}

