using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet2
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleThreading = new SimpleThreading();

            ////// Creates a thread and then aborts it after 50 milliseconds of execution
            ////simpleThreading.AbortThread();

            ////// Simple thread using a ThreadStart object
            ////simpleThreading.SimpleThread();

            ////// Simple thread using a ThreadStart object that has a join call
            ////simpleThreading.SimpleThreadJoin();

            ////// Simple thread using a ParameterizedThreadStart object that passes a value to the method used by the thread
            ////simpleThreading.ParameterizedThread();

            ////// Simple thread using an anonymous delegate
            ////simpleThreading.SimpleThreadAnonymousDelegate();

            ////// Simple thread using an anonymous delegate that passes a value to the method used by the thread
            ////simpleThreading.ParameterizedThreadAnonymousDelegate();

            ////// Simple thread using an anaonymous delete that executes straight code rather than call a method
            ////simpleThreading.ParameterizedThreadAnonymousDelegateNoMethodCall();

            var backgroundThreading = new BackgroundWorkerThreads();

            // Creates a background worker that counts to 4 billion then returns 4 billion
            backgroundThreading.SimpleBackgroundWorker();

            // Creates a background worker that starts processing, and then get cancelled
            backgroundThreading.AbortBackgroundWorker();

            // Creates a background worker that starting processing, but then an exception is thrown
            backgroundThreading.ExceptionBackgroundWorker();

            Console.WriteLine("Finished! Press the enter key to continue.");
            Console.ReadLine();
        }
    }
}
