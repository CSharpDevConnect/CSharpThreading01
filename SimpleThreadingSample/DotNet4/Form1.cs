using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Synchronous

        /// <summary>
        /// Increment the progress bar by one until it is full, synchronously.
        /// </summary>
        private void SynchronousStartButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= SynchronousProgressBar.Maximum; i++)
            {
                SynchronousProgressBar.Value = i;
                Thread.Sleep(1);
            }
        }

        #endregion

        #region Async with no return value

        /// <summary>
        /// Increments the progress bar by one until it is full, asynchronously using Task.Delay()
        /// </summary>
        private async void AsyncTaskDelayStartButton_Click(object sender, EventArgs e)
        {
            await StartTaskDelayProgressBarAsync();
        }

        /// <summary>
        /// Increments the progress bar using Task.Delay()
        /// </summary>
        /// <returns>A Task object that is required for asynchronous methods.</returns>
        private async Task StartTaskDelayProgressBarAsync()
        {
            for (int i = 0; i <= AsyncSimpleProgressBar.Maximum; i++)
            {
                AsyncSimpleProgressBar.Value = i;
                await Task.Delay(1);
            }
        }

        #endregion

        #region Async with return value

        /// <summary>
        /// Increments the task bar by getting a value from an asynchronous method
        /// </summary>
        private async void AsyncTaskDelayReturnValueStartButton_Click(object sender, EventArgs e)
        {
            int value = await CountToMaxValueAsync();
            AsyncReturnValueProgressBar.Value = value;
        }

        /// <summary>
        /// Increments an integer to the max value of the progress bar
        /// </summary>
        /// <returns>The max value of the progress bar</returns>
        private async Task<int> CountToMaxValueAsync()
        {
            int counter = 0;
            for (counter = 0; counter <= AsyncReturnValueProgressBar.Maximum; counter++)
            {
                await Task.Delay(1);
            }

            return counter;
        }

        #endregion

        #region Asyc using Func

        /// <summary>
        /// Get the value of the progress bar from a synchronous method asynchronously, then assign the retrieved value to the progress bar
        /// </summary>
        private async void AsyncUsingFuncStartButton_Click(object sender, EventArgs e)
        {
            int value = await Task.Run(new Func<int>(CountToHighValue));
            AsyncUsingFuncProgressBar.Value = value;
        }

        /// <summary>
        /// Gets the maximum value of the progress bar by counting.
        /// </summary>
        /// <returns>The maximum value of the progress bar.</returns>
        private int CountToHighValue()
        {
            int value = 0;
            for (int i = 0; i <= AsyncUsingFuncProgressBar.Maximum; i++)
            {
                value = i;
            }

            return value;
        }

        /// <summary>
        /// Counts from 0 to the given value.
        /// </summary>
        /// <param name="maximumValue">The value to count to.</param>
        /// <returns>The given value.</returns>
        private void CountToGivenValue(int maximumValue)
        {
            int value = 0;
            for (int i = 0; i <= maximumValue; i++)
            {
                value = i;
            }
        }

        #endregion

        #region Cross Thread Violations

        // Creating a new Task and making it run a method that acesses the UI will cause a cross-thread exception
        // This is because a Task will start a new Thread, any only the UI thread may access UI elements.

        // A Task is essentially a stripped down Thread object from .NET 2.0

        private async void AsyncUsingActionStartButton_Click0(object sender, EventArgs e)
        {
            await Task.Run(new Action(AccessProgressBar));
        }

        private void AsyncUsingActionStartButton_Click1(object sender, EventArgs e)
        {
            Task countToTwoHundred = new Task(new Action(AccessProgressBar));
            countToTwoHundred.Start();
            countToTwoHundred.Wait();
        }

        private async void AsyncUsingActionStartButton_Click2(object sender, EventArgs e)
        {
            await Task.Factory.StartNew(new Action(AccessProgressBar));
        }

        private void AccessProgressBar()
        {
            AsyncUsingFuncProgressBar.Value = 1;
        }

        #endregion
    }
}
