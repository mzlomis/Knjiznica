namespace leture_35
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
            this.nmrSecondNumber = new System.Windows.Forms.NumericUpDown();
            this.nmrThirdNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSummarize = new System.Windows.Forms.Button();
            this.lblSummary = new System.Windows.Forms.Label();
            this.nmrFirstNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSecondNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrThirdNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFirstNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrSecondNumber
            // 
            this.nmrSecondNumber.DecimalPlaces = 4;
            this.nmrSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.nmrSecondNumber.Location = new System.Drawing.Point(12, 84);
            this.nmrSecondNumber.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmrSecondNumber.Name = "nmrSecondNumber";
            this.nmrSecondNumber.Size = new System.Drawing.Size(255, 64);
            this.nmrSecondNumber.TabIndex = 1;
            // 
            // nmrThirdNumber
            // 
            this.nmrThirdNumber.DecimalPlaces = 4;
            this.nmrThirdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.nmrThirdNumber.Location = new System.Drawing.Point(12, 164);
            this.nmrThirdNumber.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmrThirdNumber.Name = "nmrThirdNumber";
            this.nmrThirdNumber.Size = new System.Drawing.Size(255, 64);
            this.nmrThirdNumber.TabIndex = 2;
            // 
            // btnSummarize
            // 
            this.btnSummarize.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnSummarize.Location = new System.Drawing.Point(12, 259);
            this.btnSummarize.Name = "btnSummarize";
            this.btnSummarize.Size = new System.Drawing.Size(297, 64);
            this.btnSummarize.TabIndex = 3;
            this.btnSummarize.Text = "Summarize";
            this.btnSummarize.UseVisualStyleBackColor = true;
            this.btnSummarize.Click += new System.EventHandler(this.btnSummarize_Click);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblSummary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSummary.Location = new System.Drawing.Point(13, 363);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(0, 76);
            this.lblSummary.TabIndex = 5;
            // 
            // nmrFirstNumber
            // 
            this.nmrFirstNumber.DecimalPlaces = 4;
            this.nmrFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.nmrFirstNumber.Location = new System.Drawing.Point(12, 2);
            this.nmrFirstNumber.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmrFirstNumber.Name = "nmrFirstNumber";
            this.nmrFirstNumber.Size = new System.Drawing.Size(255, 64);
            this.nmrFirstNumber.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 640);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.btnSummarize);
            this.Controls.Add(this.nmrThirdNumber);
            this.Controls.Add(this.nmrSecondNumber);
            this.Controls.Add(this.nmrFirstNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrSecondNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrThirdNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFirstNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrSecondNumber;
        private System.Windows.Forms.NumericUpDown nmrThirdNumber;
        private System.Windows.Forms.Button btnSummarize;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.NumericUpDown nmrFirstNumber;
    }
}

