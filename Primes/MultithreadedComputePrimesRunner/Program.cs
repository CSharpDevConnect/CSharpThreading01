using System;

using ComputePrimes;

namespace ComputePrimesRunner
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ComputePrimes.ComputePrimes.Run(args, new PrimeRangeComputer());
        }
    }
}
