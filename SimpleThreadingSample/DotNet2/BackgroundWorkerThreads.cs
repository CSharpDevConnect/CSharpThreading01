using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;

namespace DotNet2
{
    public class BackgroundWorkerThreads
    {
        #region Simple BackgroundWorker

        /// <summary>
        /// Creates a Background Worker and runs it asynchronously
        /// </summary>
        public void SimpleBackgroundWorker()
        {
            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += SimpleBackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += SimpleBackgroundWorker_RunWorkerCompleted;
            backgroundWorker.RunWorkerAsync();
        }

        void SimpleBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int result = Convert.ToInt32(e.Result);
            Console.WriteLine("Result of Background worker: " + result);

            var backgroundWorker = (BackgroundWorker)sender;
            backgroundWorker.Dispose();
        }

        private void SimpleBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int value = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
               value++;
            }

            e.Result = value;
        }

        #endregion

        #region Abort Thread

        /// <summary>
        /// Creates a Background worker, starts it, then aborts it after 50 milliseconds
        /// </summary>
        public void AbortBackgroundWorker()
        {
            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += AbortBackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += AbortBackgroundWorker_RunWorkerCompleted;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.RunWorkerAsync();

            Thread.Sleep(50);

            backgroundWorker.CancelAsync();
        }

        private void AbortBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;

            int value = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                value++;
                if (worker.CancellationPending)
                {
                    e.Result = value;
                    return;
                }
            }

            e.Result = value;
        }

        private void AbortBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                Console.WriteLine("Thread was cancelled.");
            }
            else
            {
                Console.WriteLine("Result of thread: " + e.Result);
            }

            var worker = (BackgroundWorker)sender;
            worker.Dispose();
        }
        
        #endregion

        #region Throws Exception

        /// <summary>
        /// Creates a Background worker, starts it, then the code being executed throws an exception.
        /// </summary>
        public void ExceptionBackgroundWorker()
        {
            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += ExceptionBackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += ExceptionBackgroundWorker_RunWorkerCompleted;
            backgroundWorker.RunWorkerAsync();
        }

        private void ExceptionBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new Exception("I broke it.");
        }

        private void ExceptionBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                Console.WriteLine("Thread was cancelled.");
            }
            else if (e.Error != null)
            {
                Console.WriteLine("There was an exception thrown while the thread was running: " + e.Error.Message);
            }
            else
            {
                Console.WriteLine("Result of thread: " + e.Result);
            }

            var worker = (BackgroundWorker)sender;
            worker.Dispose();
        }

        #endregion
    }
}
