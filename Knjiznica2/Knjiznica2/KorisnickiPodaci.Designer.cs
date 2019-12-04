namespace Knjiznica2
{
    partial class KorisnickiPodaci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KorisnickiPodaci));
            this.TxtKorIme = new System.Windows.Forms.TextBox();
            this.TxtLozinka = new System.Windows.Forms.TextBox();
            this.LblKorIme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BtnDodaj = new System.Windows.Forms.Button();
            this.BtnUredi = new System.Windows.Forms.Button();
            this.BtnIzbrisi = new System.Windows.Forms.Button();
            this.BtnPretrazi = new System.Windows.Forms.Button();
            this.CboPretrazi = new System.Windows.Forms.ComboBox();
            this.TxtPretrazi = new System.Windows.Forms.TextBox();
            this.BtnPrikaziSve = new System.Windows.Forms.Button();
            this.BtnSakrij = new System.Windows.Forms.Button();
            this.BtnIspisi = new System.Windows.Forms.Button();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijava2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prijava2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtKorIme
            // 
            this.TxtKorIme.Location = new System.Drawing.Point(137, 51);
            this.TxtKorIme.Name = "TxtKorIme";
            this.TxtKorIme.Size = new System.Drawing.Size(261, 22);
            this.TxtKorIme.TabIndex = 0;
            // 
            // TxtLozinka
            // 
            this.TxtLozinka.Location = new System.Drawing.Point(137, 102);
            this.TxtLozinka.Name = "TxtLozinka";
            this.TxtLozinka.Size = new System.Drawing.Size(261, 22);
            this.TxtLozinka.TabIndex = 1;
            // 
            // LblKorIme
            // 
            this.LblKorIme.AutoSize = true;
            this.LblKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblKorIme.Location = new System.Drawing.Point(12, 51);
            this.LblKorIme.Name = "LblKorIme";
            this.LblKorIme.Size = new System.Drawing.Size(69, 20);
            this.LblKorIme.TabIndex = 2;
            this.LblKorIme.Text = "Korisnik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lozinka";
            // 
            // DataGridView1
            // 
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnikDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.prijava2BindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(12, 404);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(386, 150);
            this.DataGridView1.TabIndex = 4;
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDodaj.Location = new System.Drawing.Point(16, 148);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(112, 29);
            this.BtnDodaj.TabIndex = 5;
            this.BtnDodaj.Text = "Dodaj";
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // BtnUredi
            // 
            this.BtnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnUredi.Location = new System.Drawing.Point(149, 148);
            this.BtnUredi.Name = "BtnUredi";
            this.BtnUredi.Size = new System.Drawing.Size(112, 29);
            this.BtnUredi.TabIndex = 6;
            this.BtnUredi.Text = "Uredi";
            this.BtnUredi.UseVisualStyleBackColor = true;
            this.BtnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // BtnIzbrisi
            // 
            this.BtnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnIzbrisi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIzbrisi.Location = new System.Drawing.Point(286, 148);
            this.BtnIzbrisi.Name = "BtnIzbrisi";
            this.BtnIzbrisi.Size = new System.Drawing.Size(112, 29);
            this.BtnIzbrisi.TabIndex = 7;
            this.BtnIzbrisi.Text = "Izbrisi";
            this.BtnIzbrisi.UseVisualStyleBackColor = true;
            this.BtnIzbrisi.Click += new System.EventHandler(this.BtnIzbrisi_Click);
            // 
            // BtnPretrazi
            // 
            this.BtnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPretrazi.Location = new System.Drawing.Point(16, 201);
            this.BtnPretrazi.Name = "BtnPretrazi";
            this.BtnPretrazi.Size = new System.Drawing.Size(112, 31);
            this.BtnPretrazi.TabIndex = 8;
            this.BtnPretrazi.Text = "Pretrazi";
            this.BtnPretrazi.UseVisualStyleBackColor = true;
            this.BtnPretrazi.Click += new System.EventHandler(this.BtnPretrazi_Click);
            // 
            // CboPretrazi
            // 
            this.CboPretrazi.FormattingEnabled = true;
            this.CboPretrazi.Items.AddRange(new object[] {
            "Korisnik"});
            this.CboPretrazi.Location = new System.Drawing.Point(149, 208);
            this.CboPretrazi.Name = "CboPretrazi";
            this.CboPretrazi.Size = new System.Drawing.Size(112, 24);
            this.CboPretrazi.TabIndex = 9;
            // 
            // TxtPretrazi
            // 
            this.TxtPretrazi.Location = new System.Drawing.Point(286, 210);
            this.TxtPretrazi.Name = "TxtPretrazi";
            this.TxtPretrazi.Size = new System.Drawing.Size(112, 22);
            this.TxtPretrazi.TabIndex = 10;
            // 
            // BtnPrikaziSve
            // 
            this.BtnPrikaziSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPrikaziSve.Location = new System.Drawing.Point(12, 260);
            this.BtnPrikaziSve.Name = "BtnPrikaziSve";
            this.BtnPrikaziSve.Size = new System.Drawing.Size(116, 37);
            this.BtnPrikaziSve.TabIndex = 11;
            this.BtnPrikaziSve.Text = "Prikazi Sve";
            this.BtnPrikaziSve.UseVisualStyleBackColor = true;
            this.BtnPrikaziSve.Click += new System.EventHandler(this.BtnPrikaziSve_Click);
            // 
            // BtnSakrij
            // 
            this.BtnSakrij.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSakrij.Location = new System.Drawing.Point(149, 260);
            this.BtnSakrij.Name = "BtnSakrij";
            this.BtnSakrij.Size = new System.Drawing.Size(249, 37);
            this.BtnSakrij.TabIndex = 12;
            this.BtnSakrij.Text = "Prikazi prva 2 reda";
            this.BtnSakrij.UseVisualStyleBackColor = true;
            this.BtnSakrij.Click += new System.EventHandler(this.BtnSakrij_Click);
            // 
            // BtnIspisi
            // 
            this.BtnIspisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnIspisi.Location = new System.Drawing.Point(12, 326);
            this.BtnIspisi.Name = "BtnIspisi";
            this.BtnIspisi.Size = new System.Drawing.Size(386, 34);
            this.BtnIspisi.TabIndex = 13;
            this.BtnIspisi.Text = "Ispisi Korisnike";
            this.BtnIspisi.UseVisualStyleBackColor = true;
            this.BtnIspisi.Click += new System.EventHandler(this.BtnIspisi_Click);
            // 
            // PrintPreviewDialog1
            // 
            this.PrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog1.Document = this.PrintDocument1;
            this.PrintPreviewDialog1.Enabled = true;
            this.PrintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog1.Icon")));
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            this.PrintPreviewDialog1.Visible = false;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            // 
            // prijava2BindingSource
            // 
            this.prijava2BindingSource.DataSource = typeof(Knjiznica2.Prijava2);
            // 
            // KorisnickiPodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 563);
            this.Controls.Add(this.BtnIspisi);
            this.Controls.Add(this.BtnSakrij);
            this.Controls.Add(this.BtnPrikaziSve);
            this.Controls.Add(this.TxtPretrazi);
            this.Controls.Add(this.CboPretrazi);
            this.Controls.Add(this.BtnPretrazi);
            this.Controls.Add(this.BtnIzbrisi);
            this.Controls.Add(this.BtnUredi);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblKorIme);
            this.Controls.Add(this.TxtLozinka);
            this.Controls.Add(this.TxtKorIme);
            this.Name = "KorisnickiPodaci";
            this.Text = "KorisnickiPodaci";
            this.Shown += new System.EventHandler(this.KorisnickiPodaci_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prijava2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtKorIme;
        private System.Windows.Forms.TextBox TxtLozinka;
        private System.Windows.Forms.Label LblKorIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.BindingSource BindingSource1;
        private System.Windows.Forms.Button BtnDodaj;
        private System.Windows.Forms.Button BtnUredi;
        private System.Windows.Forms.Button BtnIzbrisi;
        private System.Windows.Forms.Button BtnPretrazi;
        private System.Windows.Forms.ComboBox CboPretrazi;
        private System.Windows.Forms.TextBox TxtPretrazi;
        private System.Windows.Forms.Button BtnPrikaziSve;
        private System.Windows.Forms.Button BtnSakrij;
        private System.Windows.Forms.Button BtnIspisi;
        private System.Drawing.Printing.PrintDocument PrintDocument1;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prijava2BindingSource;
    }
}