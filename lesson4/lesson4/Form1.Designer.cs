namespace lesson4
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
            this.msgLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.msgLabel.Location = new System.Drawing.Point(76, 45);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(260, 69);
            this.msgLabel.TabIndex = 0;
            this.msgLabel.Text = "Click me";
            this.msgLabel.Click += new System.EventHandler(this.msgLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 450);
            this.Controls.Add(this.msgLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgLabel;
    }
}

