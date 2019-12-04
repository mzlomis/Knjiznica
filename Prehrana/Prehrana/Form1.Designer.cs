namespace Prehrana
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
            this.LblSpol = new System.Windows.Forms.Label();
            this.LblVisina = new System.Windows.Forms.Label();
            this.CboSpol = new System.Windows.Forms.ComboBox();
            this.TxtTezina = new System.Windows.Forms.Label();
            this.LblGodine = new System.Windows.Forms.Label();
            this.LblAktivnost = new System.Windows.Forms.Label();
            this.CboAktivnost = new System.Windows.Forms.ComboBox();
            this.LblRezultat1 = new System.Windows.Forms.Label();
            this.LblRezultat2 = new System.Windows.Forms.Label();
            this.LblOdrzavanje = new System.Windows.Forms.Label();
            this.LblMrsavljenje = new System.Windows.Forms.Label();
            this.BtnIzracunaj = new System.Windows.Forms.Button();
            this.NudTezina = new System.Windows.Forms.NumericUpDown();
            this.NudVisina = new System.Windows.Forms.NumericUpDown();
            this.NudGodine = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NudTezina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudVisina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudGodine)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSpol
            // 
            this.LblSpol.AutoSize = true;
            this.LblSpol.Location = new System.Drawing.Point(12, 29);
            this.LblSpol.Name = "LblSpol";
            this.LblSpol.Size = new System.Drawing.Size(36, 17);
            this.LblSpol.TabIndex = 1;
            this.LblSpol.Text = "Spol";
            // 
            // LblVisina
            // 
            this.LblVisina.AutoSize = true;
            this.LblVisina.Location = new System.Drawing.Point(7, 127);
            this.LblVisina.Name = "LblVisina";
            this.LblVisina.Size = new System.Drawing.Size(46, 17);
            this.LblVisina.TabIndex = 2;
            this.LblVisina.Text = "Visina";
            // 
            // CboSpol
            // 
            this.CboSpol.FormattingEnabled = true;
            this.CboSpol.Items.AddRange(new object[] {
            "Muskarac",
            "Zena"});
            this.CboSpol.Location = new System.Drawing.Point(72, 26);
            this.CboSpol.Name = "CboSpol";
            this.CboSpol.Size = new System.Drawing.Size(121, 24);
            this.CboSpol.TabIndex = 3;
            // 
            // TxtTezina
            // 
            this.TxtTezina.AutoSize = true;
            this.TxtTezina.Location = new System.Drawing.Point(7, 80);
            this.TxtTezina.Name = "TxtTezina";
            this.TxtTezina.Size = new System.Drawing.Size(51, 17);
            this.TxtTezina.TabIndex = 4;
            this.TxtTezina.Text = "Tezina";
            // 
            // LblGodine
            // 
            this.LblGodine.AutoSize = true;
            this.LblGodine.Location = new System.Drawing.Point(7, 174);
            this.LblGodine.Name = "LblGodine";
            this.LblGodine.Size = new System.Drawing.Size(54, 17);
            this.LblGodine.TabIndex = 6;
            this.LblGodine.Text = "Godine";
            // 
            // LblAktivnost
            // 
            this.LblAktivnost.AutoSize = true;
            this.LblAktivnost.Location = new System.Drawing.Point(7, 221);
            this.LblAktivnost.Name = "LblAktivnost";
            this.LblAktivnost.Size = new System.Drawing.Size(65, 17);
            this.LblAktivnost.TabIndex = 8;
            this.LblAktivnost.Text = "Aktivnost";
            // 
            // CboAktivnost
            // 
            this.CboAktivnost.FormattingEnabled = true;
            this.CboAktivnost.Items.AddRange(new object[] {
            "Sjedilacki nacin zivota bez aktivnosti",
            "Malo dodatne aktivnosti",
            "Umjerena aktivnost",
            "Velika kolicina aktivnosti",
            "Jako puno aktivnosti"});
            this.CboAktivnost.Location = new System.Drawing.Point(72, 218);
            this.CboAktivnost.Name = "CboAktivnost";
            this.CboAktivnost.Size = new System.Drawing.Size(121, 24);
            this.CboAktivnost.TabIndex = 9;
            // 
            // LblRezultat1
            // 
            this.LblRezultat1.AutoSize = true;
            this.LblRezultat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblRezultat1.Location = new System.Drawing.Point(428, 29);
            this.LblRezultat1.Name = "LblRezultat1";
            this.LblRezultat1.Size = new System.Drawing.Size(0, 25);
            this.LblRezultat1.TabIndex = 10;
            // 
            // LblRezultat2
            // 
            this.LblRezultat2.AutoSize = true;
            this.LblRezultat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblRezultat2.Location = new System.Drawing.Point(428, 100);
            this.LblRezultat2.Name = "LblRezultat2";
            this.LblRezultat2.Size = new System.Drawing.Size(0, 25);
            this.LblRezultat2.TabIndex = 11;
            // 
            // LblOdrzavanje
            // 
            this.LblOdrzavanje.AutoSize = true;
            this.LblOdrzavanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblOdrzavanje.Location = new System.Drawing.Point(299, 29);
            this.LblOdrzavanje.Name = "LblOdrzavanje";
            this.LblOdrzavanje.Size = new System.Drawing.Size(113, 25);
            this.LblOdrzavanje.TabIndex = 12;
            this.LblOdrzavanje.Text = "Odrzavanje";
            // 
            // LblMrsavljenje
            // 
            this.LblMrsavljenje.AutoSize = true;
            this.LblMrsavljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblMrsavljenje.Location = new System.Drawing.Point(299, 100);
            this.LblMrsavljenje.Name = "LblMrsavljenje";
            this.LblMrsavljenje.Size = new System.Drawing.Size(111, 25);
            this.LblMrsavljenje.TabIndex = 13;
            this.LblMrsavljenje.Text = "Mrsavljenje";
            // 
            // BtnIzracunaj
            // 
            this.BtnIzracunaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnIzracunaj.Location = new System.Drawing.Point(304, 215);
            this.BtnIzracunaj.Name = "BtnIzracunaj";
            this.BtnIzracunaj.Size = new System.Drawing.Size(108, 27);
            this.BtnIzracunaj.TabIndex = 14;
            this.BtnIzracunaj.Text = "Izracunaj";
            this.BtnIzracunaj.UseVisualStyleBackColor = true;
            this.BtnIzracunaj.Click += new System.EventHandler(this.BtnIzracunaj_Click);
            // 
            // NudTezina
            // 
            this.NudTezina.Location = new System.Drawing.Point(73, 80);
            this.NudTezina.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudTezina.Name = "NudTezina";
            this.NudTezina.Size = new System.Drawing.Size(120, 22);
            this.NudTezina.TabIndex = 15;
            // 
            // NudVisina
            // 
            this.NudVisina.Location = new System.Drawing.Point(73, 127);
            this.NudVisina.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudVisina.Name = "NudVisina";
            this.NudVisina.Size = new System.Drawing.Size(120, 22);
            this.NudVisina.TabIndex = 16;
            // 
            // NudGodine
            // 
            this.NudGodine.Location = new System.Drawing.Point(73, 174);
            this.NudGodine.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudGodine.Name = "NudGodine";
            this.NudGodine.Size = new System.Drawing.Size(120, 22);
            this.NudGodine.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 359);
            this.Controls.Add(this.NudGodine);
            this.Controls.Add(this.NudVisina);
            this.Controls.Add(this.NudTezina);
            this.Controls.Add(this.BtnIzracunaj);
            this.Controls.Add(this.LblMrsavljenje);
            this.Controls.Add(this.LblOdrzavanje);
            this.Controls.Add(this.LblRezultat2);
            this.Controls.Add(this.LblRezultat1);
            this.Controls.Add(this.CboAktivnost);
            this.Controls.Add(this.LblAktivnost);
            this.Controls.Add(this.LblGodine);
            this.Controls.Add(this.TxtTezina);
            this.Controls.Add(this.CboSpol);
            this.Controls.Add(this.LblVisina);
            this.Controls.Add(this.LblSpol);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NudTezina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudVisina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudGodine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblSpol;
        private System.Windows.Forms.Label LblVisina;
        private System.Windows.Forms.ComboBox CboSpol;
        private System.Windows.Forms.Label TxtTezina;
        private System.Windows.Forms.Label LblGodine;
        private System.Windows.Forms.Label LblAktivnost;
        private System.Windows.Forms.ComboBox CboAktivnost;
        private System.Windows.Forms.Label LblRezultat1;
        private System.Windows.Forms.Label LblRezultat2;
        private System.Windows.Forms.Label LblOdrzavanje;
        private System.Windows.Forms.Label LblMrsavljenje;
        private System.Windows.Forms.Button BtnIzracunaj;
        private System.Windows.Forms.NumericUpDown NudTezina;
        private System.Windows.Forms.NumericUpDown NudVisina;
        private System.Windows.Forms.NumericUpDown NudGodine;
    }
}

