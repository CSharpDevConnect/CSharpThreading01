using System;
using System.Collections.Generic;
using System.Threading;

namespace ComputePrimes
{
    /// <summary>
    /// Multithreaded implementation of computing the number of primes in ranges.
    /// Spawns a new thread for each range computation.
    /// </summary>
    public class MultithreadedPrimeRangeComputer : IPrimeRangeComputer
    {
        /// <summary>
        /// Given an enumerable of ranges, computes the number of primes within each range and passes
        /// the result to the provided action (not necessarily in the same order they were provided).
        /// </summary>
        /// <param name="ranges">The ranges.</param>
        /// <param name="action">The action to run for each result.</param>
        public void ComputePrimeCount(IEnumerable<Tuple<int, int>> ranges, Action<PrimeRangeResult> action)
        {
            var threads = new List<Thread>();

            foreach (var range in ranges)
            {
                var thread = new Thread(() => action(Helpers.ComputePrimeCount(range.Item1, range.Item2)));
                threads.Add(thread);
                thread.Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            };
        }
    }
}
