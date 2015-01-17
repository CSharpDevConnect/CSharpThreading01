using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ComputePrimes
{
    /// <summary>
    /// Static class for computing prime number counts.
    /// </summary>
    public static class ComputePrimes
    {
        /// <summary>
        /// Run the prime number calculations and output results.
        /// </summary>
        /// <param name="args">Arguments.</param>
        /// <param name="primeComputer">Prime computer.</param>
        public static void Run(string[] args, IPrimeRangeComputer primeComputer)
        {
            ValidateArgs(args);
            Tuple<int, int>[] pairs = ParsePairs(args);

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            primeComputer.ComputePrimeCount(pairs, result =>
            {
                Console.WriteLine("Number of primes between {0} and {1}: {2}", result.LowerBound, result.UpperBound, result.PrimeCount);
            });

            stopwatch.Stop();
            Console.WriteLine("Total time elapsed: {0}", stopwatch.Elapsed);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Validates the arguments, exiting if they are invalid.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void ValidateArgs(string[] args)
        {
            if (args.Length == 0 || args.Length % 2 == 1)
            {
                Console.WriteLine("Error: Please provide an even, nonzero number of integer parameters.");
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Parses a string array of even length into an array of int pairs,
        /// exiting if parsing fails.
        /// </summary>
        /// <returns>The pairs.</returns>
        /// <param name="args">The arguments.</param>
        private static Tuple<int, int>[] ParsePairs(string[] args)
        {
            int numPairs = args.Length / 2;
            var pairs = new Tuple<int, int>[numPairs];
            for (int pairIndex = 0; pairIndex < numPairs; pairIndex++)
            {
                pairs[pairIndex] = Tuple.Create(
                    ParseIntOrExit(args, 2 * pairIndex),
                    ParseIntOrExit(args, 2 * pairIndex + 1));
            }

            return pairs;
        }

        /// <summary>
        /// Parses an int from a string, exiting on failure.
        /// </summary>
        /// <returns>The parsed int.</returns>
        /// <param name="input">The input string.</param>
        /// <param name="index">The index of the number, used in the message printed on error.</param>
        private static int ParseIntOrExit(string[] input, int index)
        {
            int output;

            if (!Int32.TryParse(input[index], out output))
            {
                Console.WriteLine("Error: Supplied number at index {0} could not be converted to an integer.", index);
                Environment.Exit(1);
            }

            return output;
        }
    }
}
