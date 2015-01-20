using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComputePrimes
{
    /// <summary>
    /// Interface for types that can compute the amount of prime numbers within a range.
    /// </summary>
    public interface IPrimeRangeComputer
    {
        /// <summary>
        /// Given an enumerable of ranges, computes the number of primes within each range and passes
        /// the result to the provided action (not necessarily in the same order they were provided).
        /// </summary>
        /// <param name="ranges">The ranges.</param>
        /// <param name="action">The action to run for each result.</param>
        void ComputePrimeCount(IEnumerable<Tuple<int, int>> ranges, Action<PrimeRangeResult> action);
    }
}
