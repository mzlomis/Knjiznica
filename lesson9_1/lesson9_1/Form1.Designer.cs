namespace lesson9_1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSideLength = new System.Windows.Forms.Label();
            this.txtSideLength = new System.Windows.Forms.TextBox();
            this.btnFindPerimiter = new System.Windows.Forms.Button();
            this.lblPerimeter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lesson9_1.Properties.Resources.square;
            this.pictureBox1.Location = new System.Drawing.Point(577, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(614, 654);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblSideLength
            // 
            this.lblSideLength.AutoSize = true;
            this.lblSideLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSideLength.Location = new System.Drawing.Point(408, 273);
            this.lblSideLength.Name = "lblSideLength";
            this.lblSideLength.Size = new System.Drawing.Size(0, 78);
            this.lblSideLength.TabIndex = 1;
            // 
            // txtSideLength
            // 
            this.txtSideLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSideLength.Location = new System.Drawing.Point(47, 25);
            this.txtSideLength.Name = "txtSideLength";
            this.txtSideLength.Size = new System.Drawing.Size(230, 83);
            this.txtSideLength.TabIndex = 2;
            this.txtSideLength.TextChanged += new System.EventHandler(this.txtSideLength_TextChanged);
            // 
            // btnFindPerimiter
            // 
            this.btnFindPerimiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFindPerimiter.Location = new System.Drawing.Point(47, 143);
            this.btnFindPerimiter.Name = "btnFindPerimiter";
            this.btnFindPerimiter.Size = new System.Drawing.Size(230, 117);
            this.btnFindPerimiter.TabIndex = 3;
            this.btnFindPerimiter.Text = "FIND";
            this.btnFindPerimiter.UseVisualStyleBackColor = true;
            this.btnFindPerimiter.Click += new System.EventHandler(this.btnFindPerimiter_Click);
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPerimeter.Location = new System.Drawing.Point(47, 345);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(0, 78);
            this.lblPerimeter.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 723);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.btnFindPerimiter);
            this.Controls.Add(this.txtSideLength);
            this.Controls.Add(this.lblSideLength);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSideLength;
        private System.Windows.Forms.TextBox txtSideLength;
        private System.Windows.Forms.Button btnFindPerimiter;
        private System.Windows.Forms.Label lblPerimeter;
    }
}

