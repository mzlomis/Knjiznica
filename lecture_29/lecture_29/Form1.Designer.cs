namespace lecture_29
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
            this.nmrFirstNumber = new System.Windows.Forms.NumericUpDown();
            this.nmrSecondNumber = new System.Windows.Forms.NumericUpDown();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFirstNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSecondNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrFirstNumber
            // 
            this.nmrFirstNumber.DecimalPlaces = 4;
            this.nmrFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.nmrFirstNumber.Location = new System.Drawing.Point(12, 12);
            this.nmrFirstNumber.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmrFirstNumber.Name = "nmrFirstNumber";
            this.nmrFirstNumber.Size = new System.Drawing.Size(240, 83);
            this.nmrFirstNumber.TabIndex = 0;
            this.nmrFirstNumber.ValueChanged += new System.EventHandler(this.nmrFirstNumber_ValueChanged);
            // 
            // nmrSecondNumber
            // 
            this.nmrSecondNumber.DecimalPlaces = 4;
            this.nmrSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.nmrSecondNumber.Location = new System.Drawing.Point(548, 12);
            this.nmrSecondNumber.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmrSecondNumber.Name = "nmrSecondNumber";
            this.nmrSecondNumber.Size = new System.Drawing.Size(240, 83);
            this.nmrSecondNumber.TabIndex = 1;
            this.nmrSecondNumber.ValueChanged += new System.EventHandler(this.nmrSecondNumber_ValueChanged);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblSum.Location = new System.Drawing.Point(12, 134);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 76);
            this.lblSum.TabIndex = 2;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblAverage.Location = new System.Drawing.Point(22, 270);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(0, 76);
            this.lblAverage.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.nmrSecondNumber);
            this.Controls.Add(this.nmrFirstNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrFirstNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSecondNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrFirstNumber;
        private System.Windows.Forms.NumericUpDown nmrSecondNumber;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblAverage;
    }
}

