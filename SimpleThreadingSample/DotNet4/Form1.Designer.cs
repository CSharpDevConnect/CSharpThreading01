namespace DotNet4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SynchronousProgressBar = new System.Windows.Forms.ProgressBar();
            this.SynchronousStartButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AsyncSimpleProgressBar = new System.Windows.Forms.ProgressBar();
            this.AsyncSimpleStartButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AsyncReturnValueProgressBar = new System.Windows.Forms.ProgressBar();
            this.AsyncReturnValueStartButton = new System.Windows.Forms.Button();
            this.AsyncUsingFuncProgressBar = new System.Windows.Forms.ProgressBar();
            this.AsyncUsingFuncStartButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SynchronousProgressBar);
            this.groupBox1.Controls.Add(this.SynchronousStartButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Synchronous";
            // 
            // SynchronousProgressBar
            // 
            this.SynchronousProgressBar.Location = new System.Drawing.Point(7, 20);
            this.SynchronousProgressBar.Maximum = 2000;
            this.SynchronousProgressBar.Name = "SynchronousProgressBar";
            this.SynchronousProgressBar.Size = new System.Drawing.Size(179, 23);
            this.SynchronousProgressBar.TabIndex = 2;
            // 
            // SynchronousStartButton
            // 
            this.SynchronousStartButton.Location = new System.Drawing.Point(7, 49);
            this.SynchronousStartButton.Name = "SynchronousStartButton";
            this.SynchronousStartButton.Size = new System.Drawing.Size(75, 23);
            this.SynchronousStartButton.TabIndex = 0;
            this.SynchronousStartButton.Text = "Start";
            this.SynchronousStartButton.UseVisualStyleBackColor = true;
            this.SynchronousStartButton.Click += new System.EventHandler(this.SynchronousStartButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AsyncSimpleProgressBar);
            this.groupBox2.Controls.Add(this.AsyncSimpleStartButton);
            this.groupBox2.Location = new System.Drawing.Point(213, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asynchronous Task Delay";
            // 
            // AsyncSimpleProgressBar
            // 
            this.AsyncSimpleProgressBar.Location = new System.Drawing.Point(6, 20);
            this.AsyncSimpleProgressBar.Maximum = 200;
            this.AsyncSimpleProgressBar.Name = "AsyncSimpleProgressBar";
            this.AsyncSimpleProgressBar.Size = new System.Drawing.Size(170, 23);
            this.AsyncSimpleProgressBar.TabIndex = 5;
            // 
            // AsyncSimpleStartButton
            // 
            this.AsyncSimpleStartButton.Location = new System.Drawing.Point(6, 49);
            this.AsyncSimpleStartButton.Name = "AsyncSimpleStartButton";
            this.AsyncSimpleStartButton.Size = new System.Drawing.Size(75, 23);
            this.AsyncSimpleStartButton.TabIndex = 3;
            this.AsyncSimpleStartButton.Text = "Start";
            this.AsyncSimpleStartButton.UseVisualStyleBackColor = true;
            this.AsyncSimpleStartButton.Click += new System.EventHandler(this.AsyncTaskDelayStartButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AsyncReturnValueProgressBar);
            this.groupBox3.Controls.Add(this.AsyncReturnValueStartButton);
            this.groupBox3.Location = new System.Drawing.Point(10, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 90);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asynchronous Return Value";
            // 
            // AsyncReturnValueProgressBar
            // 
            this.AsyncReturnValueProgressBar.Location = new System.Drawing.Point(6, 32);
            this.AsyncReturnValueProgressBar.Maximum = 200;
            this.AsyncReturnValueProgressBar.Name = "AsyncReturnValueProgressBar";
            this.AsyncReturnValueProgressBar.Size = new System.Drawing.Size(182, 23);
            this.AsyncReturnValueProgressBar.TabIndex = 5;
            // 
            // AsyncReturnValueStartButton
            // 
            this.AsyncReturnValueStartButton.Location = new System.Drawing.Point(6, 61);
            this.AsyncReturnValueStartButton.Name = "AsyncReturnValueStartButton";
            this.AsyncReturnValueStartButton.Size = new System.Drawing.Size(75, 23);
            this.AsyncReturnValueStartButton.TabIndex = 3;
            this.AsyncReturnValueStartButton.Text = "Start";
            this.AsyncReturnValueStartButton.UseVisualStyleBackColor = true;
            this.AsyncReturnValueStartButton.Click += new System.EventHandler(this.AsyncTaskDelayReturnValueStartButton_Click);
            // 
            // AsyncUsingFuncProgressBar
            // 
            this.AsyncUsingFuncProgressBar.Location = new System.Drawing.Point(6, 32);
            this.AsyncUsingFuncProgressBar.Maximum = 200000000;
            this.AsyncUsingFuncProgressBar.Name = "AsyncUsingFuncProgressBar";
            this.AsyncUsingFuncProgressBar.Size = new System.Drawing.Size(182, 23);
            this.AsyncUsingFuncProgressBar.TabIndex = 5;
            // 
            // AsyncUsingFuncStartButton
            // 
            this.AsyncUsingFuncStartButton.Location = new System.Drawing.Point(6, 61);
            this.AsyncUsingFuncStartButton.Name = "AsyncUsingFuncStartButton";
            this.AsyncUsingFuncStartButton.Size = new System.Drawing.Size(75, 23);
            this.AsyncUsingFuncStartButton.TabIndex = 3;
            this.AsyncUsingFuncStartButton.Text = "Start";
            this.AsyncUsingFuncStartButton.UseVisualStyleBackColor = true;
            this.AsyncUsingFuncStartButton.Click += new System.EventHandler(this.AsyncUsingFuncStartButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AsyncUsingFuncProgressBar);
            this.groupBox4.Controls.Add(this.AsyncUsingFuncStartButton);
            this.groupBox4.Location = new System.Drawing.Point(213, 99);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 90);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Asynchronous Using Func";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 360);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar SynchronousProgressBar;
        private System.Windows.Forms.Button SynchronousStartButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar AsyncSimpleProgressBar;
        private System.Windows.Forms.Button AsyncSimpleStartButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar AsyncReturnValueProgressBar;
        private System.Windows.Forms.Button AsyncReturnValueStartButton;
        private System.Windows.Forms.ProgressBar AsyncUsingFuncProgressBar;
        private System.Windows.Forms.Button AsyncUsingFuncStartButton;
        private System.Windows.Forms.GroupBox groupBox4;

    }
}

