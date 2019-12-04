namespace lecture_26_2
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
            this.rchInputBox = new System.Windows.Forms.RichTextBox();
            this.BtnFindVowels = new System.Windows.Forms.Button();
            this.rchVowelsBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchInputBox
            // 
            this.rchInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.rchInputBox.Location = new System.Drawing.Point(12, 12);
            this.rchInputBox.Name = "rchInputBox";
            this.rchInputBox.Size = new System.Drawing.Size(1123, 96);
            this.rchInputBox.TabIndex = 0;
            this.rchInputBox.Text = "";
            this.rchInputBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // BtnFindVowels
            // 
            this.BtnFindVowels.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.BtnFindVowels.Location = new System.Drawing.Point(12, 124);
            this.BtnFindVowels.Name = "BtnFindVowels";
            this.BtnFindVowels.Size = new System.Drawing.Size(1123, 83);
            this.BtnFindVowels.TabIndex = 1;
            this.BtnFindVowels.Text = "FIND THE VOWELS";
            this.BtnFindVowels.UseVisualStyleBackColor = true;
            this.BtnFindVowels.Click += new System.EventHandler(this.BtnFindVowels_Click);
            // 
            // rchVowelsBox
            // 
            this.rchVowelsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.rchVowelsBox.Location = new System.Drawing.Point(12, 225);
            this.rchVowelsBox.Name = "rchVowelsBox";
            this.rchVowelsBox.Size = new System.Drawing.Size(1123, 309);
            this.rchVowelsBox.TabIndex = 2;
            this.rchVowelsBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 546);
            this.Controls.Add(this.rchVowelsBox);
            this.Controls.Add(this.BtnFindVowels);
            this.Controls.Add(this.rchInputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchInputBox;
        private System.Windows.Forms.Button BtnFindVowels;
        private System.Windows.Forms.RichTextBox rchVowelsBox;
    }
}

