namespace lecture_24
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
            this.chkExercise = new System.Windows.Forms.CheckBox();
            this.chkDiet = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkExercise
            // 
            this.chkExercise.AutoSize = true;
            this.chkExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.chkExercise.Location = new System.Drawing.Point(12, 12);
            this.chkExercise.Name = "chkExercise";
            this.chkExercise.Size = new System.Drawing.Size(312, 80);
            this.chkExercise.TabIndex = 0;
            this.chkExercise.Text = "Exercise";
            this.chkExercise.UseVisualStyleBackColor = true;
            // 
            // chkDiet
            // 
            this.chkDiet.AutoSize = true;
            this.chkDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.chkDiet.Location = new System.Drawing.Point(12, 117);
            this.chkDiet.Name = "chkDiet";
            this.chkDiet.Size = new System.Drawing.Size(173, 80);
            this.chkDiet.TabIndex = 1;
            this.chkDiet.Text = "Diet";
            this.chkDiet.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(370, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(534, 86);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check discounts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblResults.Location = new System.Drawing.Point(13, 259);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 76);
            this.lblResults.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkDiet);
            this.Controls.Add(this.chkExercise);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkExercise;
        private System.Windows.Forms.CheckBox chkDiet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResults;
    }
}

