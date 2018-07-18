namespace Sieves
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
            this.primesTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eulerTimeTextBox = new System.Windows.Forms.TextBox();
            this.eulerTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eratosthenesTimeTextBox = new System.Windows.Forms.TextBox();
            this.eratosthenesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isPrimeTimeTextBox = new System.Windows.Forms.TextBox();
            this.isPrimeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // primesTextBox
            // 
            this.primesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.primesTextBox.Location = new System.Drawing.Point(15, 209);
            this.primesTextBox.Multiline = true;
            this.primesTextBox.Name = "primesTextBox";
            this.primesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.primesTextBox.Size = new System.Drawing.Size(305, 162);
            this.primesTextBox.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Primes:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eulerTimeTextBox
            // 
            this.eulerTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eulerTimeTextBox.Location = new System.Drawing.Point(244, 153);
            this.eulerTimeTextBox.Name = "eulerTimeTextBox";
            this.eulerTimeTextBox.ReadOnly = true;
            this.eulerTimeTextBox.Size = new System.Drawing.Size(76, 22);
            this.eulerTimeTextBox.TabIndex = 34;
            this.eulerTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // eulerTextBox
            // 
            this.eulerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eulerTextBox.Location = new System.Drawing.Point(113, 153);
            this.eulerTextBox.Name = "eulerTextBox";
            this.eulerTextBox.ReadOnly = true;
            this.eulerTextBox.Size = new System.Drawing.Size(125, 22);
            this.eulerTextBox.TabIndex = 33;
            this.eulerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Euler:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Time (sec)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Biggest Prime";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eratosthenesTimeTextBox
            // 
            this.eratosthenesTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eratosthenesTimeTextBox.Location = new System.Drawing.Point(244, 123);
            this.eratosthenesTimeTextBox.Name = "eratosthenesTimeTextBox";
            this.eratosthenesTimeTextBox.ReadOnly = true;
            this.eratosthenesTimeTextBox.Size = new System.Drawing.Size(76, 22);
            this.eratosthenesTimeTextBox.TabIndex = 29;
            this.eratosthenesTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // eratosthenesTextBox
            // 
            this.eratosthenesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eratosthenesTextBox.Location = new System.Drawing.Point(113, 125);
            this.eratosthenesTextBox.Name = "eratosthenesTextBox";
            this.eratosthenesTextBox.ReadOnly = true;
            this.eratosthenesTextBox.Size = new System.Drawing.Size(125, 22);
            this.eratosthenesTextBox.TabIndex = 28;
            this.eratosthenesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Eratosthenes:";
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(245, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 26;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxTextBox.Location = new System.Drawing.Point(113, 12);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(125, 22);
            this.maxTextBox.TabIndex = 25;
            this.maxTextBox.Text = "10000000";
            this.maxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Max:";
            // 
            // isPrimeTimeTextBox
            // 
            this.isPrimeTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isPrimeTimeTextBox.Location = new System.Drawing.Point(244, 95);
            this.isPrimeTimeTextBox.Name = "isPrimeTimeTextBox";
            this.isPrimeTimeTextBox.ReadOnly = true;
            this.isPrimeTimeTextBox.Size = new System.Drawing.Size(76, 22);
            this.isPrimeTimeTextBox.TabIndex = 39;
            this.isPrimeTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // isPrimeTextBox
            // 
            this.isPrimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.isPrimeTextBox.Location = new System.Drawing.Point(113, 97);
            this.isPrimeTextBox.Name = "isPrimeTextBox";
            this.isPrimeTextBox.ReadOnly = true;
            this.isPrimeTextBox.Size = new System.Drawing.Size(125, 22);
            this.isPrimeTextBox.TabIndex = 38;
            this.isPrimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "IsPrime:";
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 383);
            this.Controls.Add(this.isPrimeTimeTextBox);
            this.Controls.Add(this.isPrimeTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.primesTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.eulerTimeTextBox);
            this.Controls.Add(this.eulerTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eratosthenesTimeTextBox);
            this.Controls.Add(this.eratosthenesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sieves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox primesTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox eulerTimeTextBox;
        private System.Windows.Forms.TextBox eulerTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eratosthenesTimeTextBox;
        private System.Windows.Forms.TextBox eratosthenesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isPrimeTimeTextBox;
        private System.Windows.Forms.TextBox isPrimeTextBox;
        private System.Windows.Forms.Label label7;
    }
}

