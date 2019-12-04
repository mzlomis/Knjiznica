namespace Knjiznica2
{
    partial class Prijava
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
            this.TxtKorIme = new System.Windows.Forms.TextBox();
            this.TxtLoz = new System.Windows.Forms.TextBox();
            this.LblKorIme = new System.Windows.Forms.Label();
            this.LblLoz = new System.Windows.Forms.Label();
            this.BtnPrijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtKorIme
            // 
            this.TxtKorIme.Location = new System.Drawing.Point(147, 27);
            this.TxtKorIme.Name = "TxtKorIme";
            this.TxtKorIme.Size = new System.Drawing.Size(170, 22);
            this.TxtKorIme.TabIndex = 0;
            // 
            // TxtLoz
            // 
            this.TxtLoz.Location = new System.Drawing.Point(147, 88);
            this.TxtLoz.Name = "TxtLoz";
            this.TxtLoz.PasswordChar = '*';
            this.TxtLoz.Size = new System.Drawing.Size(170, 22);
            this.TxtLoz.TabIndex = 1;
            // 
            // LblKorIme
            // 
            this.LblKorIme.AutoSize = true;
            this.LblKorIme.Location = new System.Drawing.Point(28, 27);
            this.LblKorIme.Name = "LblKorIme";
            this.LblKorIme.Size = new System.Drawing.Size(58, 17);
            this.LblKorIme.TabIndex = 2;
            this.LblKorIme.Text = "Korisnik";
            // 
            // LblLoz
            // 
            this.LblLoz.AutoSize = true;
            this.LblLoz.Location = new System.Drawing.Point(28, 88);
            this.LblLoz.Name = "LblLoz";
            this.LblLoz.Size = new System.Drawing.Size(57, 17);
            this.LblLoz.TabIndex = 3;
            this.LblLoz.Text = "Lozinka";
            // 
            // BtnPrijava
            // 
            this.BtnPrijava.Location = new System.Drawing.Point(147, 143);
            this.BtnPrijava.Name = "BtnPrijava";
            this.BtnPrijava.Size = new System.Drawing.Size(170, 31);
            this.BtnPrijava.TabIndex = 4;
            this.BtnPrijava.Text = "Prijava";
            this.BtnPrijava.UseVisualStyleBackColor = true;
            this.BtnPrijava.Click += new System.EventHandler(this.BtnPrijava_Click);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 240);
            this.Controls.Add(this.BtnPrijava);
            this.Controls.Add(this.LblLoz);
            this.Controls.Add(this.LblKorIme);
            this.Controls.Add(this.TxtLoz);
            this.Controls.Add(this.TxtKorIme);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtKorIme;
        private System.Windows.Forms.TextBox TxtLoz;
        private System.Windows.Forms.Label LblKorIme;
        private System.Windows.Forms.Label LblLoz;
        private System.Windows.Forms.Button BtnPrijava;
    }
}