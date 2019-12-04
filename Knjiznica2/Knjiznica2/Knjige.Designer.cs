namespace Knjiznica2
{
    partial class Knjige
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
            this.components = new System.ComponentModel.Container();
            this.LblIsbn = new System.Windows.Forms.Label();
            this.LblZanr = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblNaslov = new System.Windows.Forms.Label();
            this.CboZanr = new System.Windows.Forms.ComboBox();
            this.CboAutor = new System.Windows.Forms.ComboBox();
            this.TxtISBN = new System.Windows.Forms.TextBox();
            this.TxtNaslov = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.BtnDodaj = new System.Windows.Forms.Button();
            this.BtnIzbrisi = new System.Windows.Forms.Button();
            this.BtnUredi = new System.Windows.Forms.Button();
            this.BtnPretrazi = new System.Windows.Forms.Button();
            this.CboPretrazi = new System.Windows.Forms.ComboBox();
            this.BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TxtPretrazi = new System.Windows.Forms.TextBox();
            this.BtnPrikaziSve = new System.Windows.Forms.Button();
            this.BtnSakrij = new System.Windows.Forms.Button();
            this.BtnIzvjestajZanrovi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblIsbn
            // 
            this.LblIsbn.AutoSize = true;
            this.LblIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblIsbn.Location = new System.Drawing.Point(12, 9);
            this.LblIsbn.Name = "LblIsbn";
            this.LblIsbn.Size = new System.Drawing.Size(48, 20);
            this.LblIsbn.TabIndex = 0;
            this.LblIsbn.Text = "ISBN";
            // 
            // LblZanr
            // 
            this.LblZanr.AutoSize = true;
            this.LblZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblZanr.Location = new System.Drawing.Point(211, 9);
            this.LblZanr.Name = "LblZanr";
            this.LblZanr.Size = new System.Drawing.Size(42, 20);
            this.LblZanr.TabIndex = 1;
            this.LblZanr.Text = "Zanr";
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblAutor.Location = new System.Drawing.Point(398, 9);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(49, 20);
            this.LblAutor.TabIndex = 2;
            this.LblAutor.Text = "Autor";
            // 
            // LblNaslov
            // 
            this.LblNaslov.AutoSize = true;
            this.LblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblNaslov.Location = new System.Drawing.Point(603, 9);
            this.LblNaslov.Name = "LblNaslov";
            this.LblNaslov.Size = new System.Drawing.Size(60, 20);
            this.LblNaslov.TabIndex = 3;
            this.LblNaslov.Text = "Naslov";
            // 
            // CboZanr
            // 
            this.CboZanr.FormattingEnabled = true;
            this.CboZanr.Location = new System.Drawing.Point(258, 9);
            this.CboZanr.Name = "CboZanr";
            this.CboZanr.Size = new System.Drawing.Size(121, 24);
            this.CboZanr.TabIndex = 4;
            this.CboZanr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboZanr_KeyDown);
            // 
            // CboAutor
            // 
            this.CboAutor.FormattingEnabled = true;
            this.CboAutor.Location = new System.Drawing.Point(453, 9);
            this.CboAutor.Name = "CboAutor";
            this.CboAutor.Size = new System.Drawing.Size(121, 24);
            this.CboAutor.TabIndex = 5;
            this.CboAutor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboAutor_KeyDown);
            // 
            // TxtISBN
            // 
            this.TxtISBN.Location = new System.Drawing.Point(66, 9);
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.Size = new System.Drawing.Size(121, 22);
            this.TxtISBN.TabIndex = 6;
            // 
            // TxtNaslov
            // 
            this.TxtNaslov.Location = new System.Drawing.Point(669, 9);
            this.TxtNaslov.Name = "TxtNaslov";
            this.TxtNaslov.Size = new System.Drawing.Size(121, 22);
            this.TxtNaslov.TabIndex = 7;
            // 
            // DataGridView
            // 
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(10, 291);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(778, 247);
            this.DataGridView.TabIndex = 8;
            this.DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDodaj.Location = new System.Drawing.Point(16, 70);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(237, 30);
            this.BtnDodaj.TabIndex = 9;
            this.BtnDodaj.Text = "Dodaj ";
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // BtnIzbrisi
            // 
            this.BtnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnIzbrisi.Location = new System.Drawing.Point(548, 70);
            this.BtnIzbrisi.Name = "BtnIzbrisi";
            this.BtnIzbrisi.Size = new System.Drawing.Size(240, 30);
            this.BtnIzbrisi.TabIndex = 10;
            this.BtnIzbrisi.Text = "Izbrisi";
            this.BtnIzbrisi.UseVisualStyleBackColor = true;
            this.BtnIzbrisi.Click += new System.EventHandler(this.BtnIzbrisi_Click);
            // 
            // BtnUredi
            // 
            this.BtnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnUredi.Location = new System.Drawing.Point(269, 70);
            this.BtnUredi.Name = "BtnUredi";
            this.BtnUredi.Size = new System.Drawing.Size(264, 30);
            this.BtnUredi.TabIndex = 11;
            this.BtnUredi.Text = "Uredi";
            this.BtnUredi.UseVisualStyleBackColor = true;
            this.BtnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // BtnPretrazi
            // 
            this.BtnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPretrazi.Location = new System.Drawing.Point(16, 149);
            this.BtnPretrazi.Name = "BtnPretrazi";
            this.BtnPretrazi.Size = new System.Drawing.Size(237, 30);
            this.BtnPretrazi.TabIndex = 12;
            this.BtnPretrazi.Text = "Pretrazi";
            this.BtnPretrazi.UseVisualStyleBackColor = true;
            this.BtnPretrazi.Click += new System.EventHandler(this.BtnPretrazi_Click);
            // 
            // CboPretrazi
            // 
            this.CboPretrazi.FormattingEnabled = true;
            this.CboPretrazi.Items.AddRange(new object[] {
            "Sifra",
            "ISBN",
            "Zanr",
            "Autor",
            "Naslov"});
            this.CboPretrazi.Location = new System.Drawing.Point(269, 154);
            this.CboPretrazi.Name = "CboPretrazi";
            this.CboPretrazi.Size = new System.Drawing.Size(264, 24);
            this.CboPretrazi.TabIndex = 13;
            // 
            // TxtPretrazi
            // 
            this.TxtPretrazi.Location = new System.Drawing.Point(548, 154);
            this.TxtPretrazi.Name = "TxtPretrazi";
            this.TxtPretrazi.Size = new System.Drawing.Size(240, 22);
            this.TxtPretrazi.TabIndex = 14;
            // 
            // BtnPrikaziSve
            // 
            this.BtnPrikaziSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPrikaziSve.Location = new System.Drawing.Point(16, 217);
            this.BtnPrikaziSve.Name = "BtnPrikaziSve";
            this.BtnPrikaziSve.Size = new System.Drawing.Size(237, 33);
            this.BtnPrikaziSve.TabIndex = 15;
            this.BtnPrikaziSve.Text = "Prikazi Sve";
            this.BtnPrikaziSve.UseVisualStyleBackColor = true;
            this.BtnPrikaziSve.Click += new System.EventHandler(this.BtnPrikaziSve_Click);
            // 
            // BtnSakrij
            // 
            this.BtnSakrij.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSakrij.Location = new System.Drawing.Point(269, 217);
            this.BtnSakrij.Name = "BtnSakrij";
            this.BtnSakrij.Size = new System.Drawing.Size(264, 33);
            this.BtnSakrij.TabIndex = 16;
            this.BtnSakrij.Text = "Prikazi prva 2 reda";
            this.BtnSakrij.UseVisualStyleBackColor = true;
            this.BtnSakrij.Click += new System.EventHandler(this.BtnSakrij_Click);
            // 
            // BtnIzvjestajZanrovi
            // 
            this.BtnIzvjestajZanrovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnIzvjestajZanrovi.Location = new System.Drawing.Point(548, 217);
            this.BtnIzvjestajZanrovi.Name = "BtnIzvjestajZanrovi";
            this.BtnIzvjestajZanrovi.Size = new System.Drawing.Size(240, 33);
            this.BtnIzvjestajZanrovi.TabIndex = 17;
            this.BtnIzvjestajZanrovi.Text = "Izvjestaj po Zanrovima";
            this.BtnIzvjestajZanrovi.UseVisualStyleBackColor = true;
            this.BtnIzvjestajZanrovi.Click += new System.EventHandler(this.BtnIzvjestajZanrovi_Click);
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.BtnIzvjestajZanrovi);
            this.Controls.Add(this.BtnSakrij);
            this.Controls.Add(this.BtnPrikaziSve);
            this.Controls.Add(this.TxtPretrazi);
            this.Controls.Add(this.CboPretrazi);
            this.Controls.Add(this.BtnPretrazi);
            this.Controls.Add(this.BtnUredi);
            this.Controls.Add(this.BtnIzbrisi);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.TxtNaslov);
            this.Controls.Add(this.TxtISBN);
            this.Controls.Add(this.CboAutor);
            this.Controls.Add(this.CboZanr);
            this.Controls.Add(this.LblNaslov);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.LblZanr);
            this.Controls.Add(this.LblIsbn);
            this.Name = "Knjige";
            this.Text = "Knjige";
            this.Shown += new System.EventHandler(this.Knjige_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIsbn;
        private System.Windows.Forms.Label LblZanr;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblNaslov;
        private System.Windows.Forms.ComboBox CboZanr;
        private System.Windows.Forms.ComboBox CboAutor;
        private System.Windows.Forms.TextBox TxtISBN;
        private System.Windows.Forms.TextBox TxtNaslov;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button BtnDodaj;
        private System.Windows.Forms.Button BtnIzbrisi;
        private System.Windows.Forms.Button BtnUredi;
        private System.Windows.Forms.Button BtnPretrazi;
        private System.Windows.Forms.ComboBox CboPretrazi;
        private System.Windows.Forms.BindingSource BindingSource1;
        private System.Windows.Forms.TextBox TxtPretrazi;
        private System.Windows.Forms.Button BtnPrikaziSve;
        private System.Windows.Forms.Button BtnSakrij;
        private System.Windows.Forms.Button BtnIzvjestajZanrovi;
    }
}