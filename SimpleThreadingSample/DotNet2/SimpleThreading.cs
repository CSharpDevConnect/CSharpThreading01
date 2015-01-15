using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DotNet2
{
    public class SimpleThreading
    {
        // Questions
        // What happens when we let the thread end successfully before pressing enter
        // What happens when we press enter before the thread has ended
        // What happens to the CPU usage with and without a Thread.Sleep(XXX)

        /// <summary>
        /// Spawns a thread that runs the method CountToFourBillion.
        /// </summary>
        public void SimpleThread()
        {
            var fourBillionCountThread = new Thread(new ThreadStart(CountToFourBillion));
            fourBillionCountThread.Name = "Four Billion Count Thread";
            fourBillionCountThread.IsBackground = true;
            fourBillionCountThread.Start();
        }

        /// <summary>
        /// Spawns a thread that runs the method CountToFourBillion and joins on that thread.
        /// </summary>
        public void SimpleThreadJoin()
        {
            var fourBillionCountThread = new Thread(new ThreadStart(CountToFourBillion));
            fourBillionCountThread.Name = "Four Billion Count Thread";
            fourBillionCountThread.Start();

            fourBillionCountThread.Join();
        }

        /// <summary>
        /// Spawns a thread that takes a parameter to the method that is run
        /// </summary>
        public void ParameterizedThread()
        {
            var twoBillionCountThread = new Thread(new ParameterizedThreadStart(CountToGivenValue));
            twoBillionCountThread.Name = "Two Billion Count Thread";
            twoBillionCountThread.Start(uint.MaxValue / 2);
        }

        /// <summary>
        /// Spawns a thread that uses an anonymous delegate instead of a ThreadStart method
        /// </summary>
        public void SimpleThreadAnonymousDelegate()
        {
            var twoBillionCountThread = new Thread(() => CountToFourBillion());
            twoBillionCountThread.Name = "Four Billion Count Thread";
            twoBillionCountThread.Start();
        }

        /// <summary>
        /// Spawns a thread that takes a parameter to the method that is run using an anonymous delegate
        /// </summary>
        public void ParameterizedThreadAnonymousDelegate()
        {
            var twoBillionCountThread = new Thread(() => CountToGivenValue(uint.MaxValue / 2));
            twoBillionCountThread.Name = "Two Billion Count Thread";
            twoBillionCountThread.Start();
        }

        /// <summary>
        /// Spawns a thread that takes a parameter to the method that is run using an anonymous delegate that does not contain a method
        /// </summary>
        public void ParameterizedThreadAnonymousDelegateNoMethodCall()
        {
            var twoBillionCountThread = new Thread(() =>
            {
                for (uint i = 0; i < uint.MaxValue; i++)
                {
                    int a = 1 + 1;
                }
            });

            twoBillionCountThread.Name = "Two Billion Count Thread";
            twoBillionCountThread.Start();
        }

        /// <summary>
        /// Spawns a thread, and then aborts it.
        /// </summary>
        public void AbortThread()
        {
            var fourBillionCountThread = new Thread(new ThreadStart(CountToFourBillion));
            fourBillionCountThread.Name = "Four Billion Count Thread";
            fourBillionCountThread.Start();

            Thread.Sleep(50);

            fourBillionCountThread.Abort();
        }

        /// <summary>
        /// Counts from 0 to the max value of a unsigned integer,
        /// </summary>
        private static void CountToFourBillion()
        {
            CountToGivenValue(uint.MaxValue);
        }

        /// <summary>
        /// Counts from 0 to the given value,
        /// </summary>
        /// <param name="value">The value to count to.</param>
        private static void CountToGivenValue(object parameter)
        {
            uint value;
            uint.TryParse(parameter.ToString(), out value);

            for (uint i = 0; i < value; i++)
            {
                int a = 1 + 1;
            }
        }
    }
}
