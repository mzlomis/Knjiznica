namespace Knjiznica2
{
    partial class Posudba
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
            this.CboSifraKnjige = new System.Windows.Forms.ComboBox();
            this.LblSifraKnjige = new System.Windows.Forms.Label();
            this.CboSifraClana = new System.Windows.Forms.ComboBox();
            this.LblSifraClana = new System.Windows.Forms.Label();
            this.DTPPosudba = new System.Windows.Forms.DateTimePicker();
            this.DTPVracanje = new System.Windows.Forms.DateTimePicker();
            this.BtnDodaj = new System.Windows.Forms.Button();
            this.BtnUredi = new System.Windows.Forms.Button();
            this.BtnPretrazi = new System.Windows.Forms.Button();
            this.CboPretrazi = new System.Windows.Forms.ComboBox();
            this.TxtPretrazi = new System.Windows.Forms.TextBox();
            this.LblBrojDana = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.BtnPrikaziSve = new System.Windows.Forms.Button();
            this.BtnSakrij = new System.Windows.Forms.Button();
            this.LblDatumPosudbe = new System.Windows.Forms.Label();
            this.LblDatumVracanja = new System.Windows.Forms.Label();
            this.BtnKasnjenje = new System.Windows.Forms.Button();
            this.BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BtnIzvjestajKasnjenje = new System.Windows.Forms.Button();
            this.BtnIzbrisi1 = new System.Windows.Forms.Button();
            this.BtnIzvjestajZanrovi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CboSifraKnjige
            // 
            this.CboSifraKnjige.FormattingEnabled = true;
            this.CboSifraKnjige.Location = new System.Drawing.Point(129, 45);
            this.CboSifraKnjige.Name = "CboSifraKnjige";
            this.CboSifraKnjige.Size = new System.Drawing.Size(87, 24);
            this.CboSifraKnjige.TabIndex = 0;
            this.CboSifraKnjige.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboSifraKnjige_KeyDown);
            // 
            // LblSifraKnjige
            // 
            this.LblSifraKnjige.AutoSize = true;
            this.LblSifraKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblSifraKnjige.Location = new System.Drawing.Point(12, 45);
            this.LblSifraKnjige.Name = "LblSifraKnjige";
            this.LblSifraKnjige.Size = new System.Drawing.Size(95, 20);
            this.LblSifraKnjige.TabIndex = 1;
            this.LblSifraKnjige.Text = "Sifra Knjige";
            // 
            // CboSifraClana
            // 
            this.CboSifraClana.FormattingEnabled = true;
            this.CboSifraClana.Location = new System.Drawing.Point(379, 45);
            this.CboSifraClana.Name = "CboSifraClana";
            this.CboSifraClana.Size = new System.Drawing.Size(87, 24);
            this.CboSifraClana.TabIndex = 2;
            this.CboSifraClana.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboSifraClana_KeyDown);
            // 
            // LblSifraClana
            // 
            this.LblSifraClana.AutoSize = true;
            this.LblSifraClana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblSifraClana.Location = new System.Drawing.Point(258, 45);
            this.LblSifraClana.Name = "LblSifraClana";
            this.LblSifraClana.Size = new System.Drawing.Size(92, 20);
            this.LblSifraClana.TabIndex = 3;
            this.LblSifraClana.Text = "Sifra Clana";
            // 
            // DTPPosudba
            // 
            this.DTPPosudba.Location = new System.Drawing.Point(659, 45);
            this.DTPPosudba.Name = "DTPPosudba";
            this.DTPPosudba.Size = new System.Drawing.Size(200, 22);
            this.DTPPosudba.TabIndex = 4;
            // 
            // DTPVracanje
            // 
            this.DTPVracanje.Checked = false;
            this.DTPVracanje.Location = new System.Drawing.Point(1058, 47);
            this.DTPVracanje.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DTPVracanje.Name = "DTPVracanje";
            this.DTPVracanje.ShowCheckBox = true;
            this.DTPVracanje.Size = new System.Drawing.Size(200, 22);
            this.DTPVracanje.TabIndex = 5;
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDodaj.Location = new System.Drawing.Point(16, 107);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(200, 42);
            this.BtnDodaj.TabIndex = 6;
            this.BtnDodaj.Text = "Dodaj";
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // BtnUredi
            // 
            this.BtnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnUredi.Location = new System.Drawing.Point(262, 107);
            this.BtnUredi.Name = "BtnUredi";
            this.BtnUredi.Size = new System.Drawing.Size(204, 42);
            this.BtnUredi.TabIndex = 7;
            this.BtnUredi.Text = "Uredi";
            this.BtnUredi.UseVisualStyleBackColor = true;
            this.BtnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // BtnPretrazi
            // 
            this.BtnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPretrazi.Location = new System.Drawing.Point(16, 193);
            this.BtnPretrazi.Name = "BtnPretrazi";
            this.BtnPretrazi.Size = new System.Drawing.Size(200, 42);
            this.BtnPretrazi.TabIndex = 9;
            this.BtnPretrazi.Text = "Pretrazi";
            this.BtnPretrazi.UseVisualStyleBackColor = true;
            this.BtnPretrazi.Click += new System.EventHandler(this.BtnPretrazi_Click);
            // 
            // CboPretrazi
            // 
            this.CboPretrazi.FormattingEnabled = true;
            this.CboPretrazi.Items.AddRange(new object[] {
            "Sifra Knjige",
            "Sifra Clana"});
            this.CboPretrazi.Location = new System.Drawing.Point(262, 204);
            this.CboPretrazi.Name = "CboPretrazi";
            this.CboPretrazi.Size = new System.Drawing.Size(204, 24);
            this.CboPretrazi.TabIndex = 10;
            // 
            // TxtPretrazi
            // 
            this.TxtPretrazi.Location = new System.Drawing.Point(507, 204);
            this.TxtPretrazi.Name = "TxtPretrazi";
            this.TxtPretrazi.Size = new System.Drawing.Size(200, 22);
            this.TxtPretrazi.TabIndex = 11;
            // 
            // LblBrojDana
            // 
            this.LblBrojDana.AutoSize = true;
            this.LblBrojDana.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblBrojDana.Location = new System.Drawing.Point(1052, 114);
            this.LblBrojDana.Name = "LblBrojDana";
            this.LblBrojDana.Size = new System.Drawing.Size(0, 32);
            this.LblBrojDana.TabIndex = 13;
            // 
            // DataGridView
            // 
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 337);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(1270, 241);
            this.DataGridView.TabIndex = 14;
            this.DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            // 
            // BtnPrikaziSve
            // 
            this.BtnPrikaziSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPrikaziSve.Location = new System.Drawing.Point(16, 273);
            this.BtnPrikaziSve.Name = "BtnPrikaziSve";
            this.BtnPrikaziSve.Size = new System.Drawing.Size(200, 36);
            this.BtnPrikaziSve.TabIndex = 15;
            this.BtnPrikaziSve.Text = "Prikazi Sve";
            this.BtnPrikaziSve.UseVisualStyleBackColor = true;
            this.BtnPrikaziSve.Click += new System.EventHandler(this.BtnPrikaziSve_Click);
            // 
            // BtnSakrij
            // 
            this.BtnSakrij.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSakrij.Location = new System.Drawing.Point(262, 273);
            this.BtnSakrij.Name = "BtnSakrij";
            this.BtnSakrij.Size = new System.Drawing.Size(200, 36);
            this.BtnSakrij.TabIndex = 16;
            this.BtnSakrij.Text = "Prikazi prva 2 reda";
            this.BtnSakrij.UseVisualStyleBackColor = true;
            this.BtnSakrij.Click += new System.EventHandler(this.BtnSakrij_Click);
            // 
            // LblDatumPosudbe
            // 
            this.LblDatumPosudbe.AutoSize = true;
            this.LblDatumPosudbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblDatumPosudbe.Location = new System.Drawing.Point(503, 45);
            this.LblDatumPosudbe.Name = "LblDatumPosudbe";
            this.LblDatumPosudbe.Size = new System.Drawing.Size(129, 20);
            this.LblDatumPosudbe.TabIndex = 17;
            this.LblDatumPosudbe.Text = "Datum Posudbe";
            // 
            // LblDatumVracanja
            // 
            this.LblDatumVracanja.AutoSize = true;
            this.LblDatumVracanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblDatumVracanja.Location = new System.Drawing.Point(903, 47);
            this.LblDatumVracanja.Name = "LblDatumVracanja";
            this.LblDatumVracanja.Size = new System.Drawing.Size(130, 20);
            this.LblDatumVracanja.TabIndex = 18;
            this.LblDatumVracanja.Text = "Datum Vracanja";
            // 
            // BtnKasnjenje
            // 
            this.BtnKasnjenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnKasnjenje.Location = new System.Drawing.Point(767, 107);
            this.BtnKasnjenje.Name = "BtnKasnjenje";
            this.BtnKasnjenje.Size = new System.Drawing.Size(206, 42);
            this.BtnKasnjenje.TabIndex = 19;
            this.BtnKasnjenje.Text = "Kasnjenje (u danima)";
            this.BtnKasnjenje.UseVisualStyleBackColor = true;
            this.BtnKasnjenje.Click += new System.EventHandler(this.BtnKasnjenje_Click);
            // 
            // BtnIzvjestajKasnjenje
            // 
            this.BtnIzvjestajKasnjenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnIzvjestajKasnjenje.Location = new System.Drawing.Point(507, 273);
            this.BtnIzvjestajKasnjenje.Name = "BtnIzvjestajKasnjenje";
            this.BtnIzvjestajKasnjenje.Size = new System.Drawing.Size(200, 36);
            this.BtnIzvjestajKasnjenje.TabIndex = 22;
            this.BtnIzvjestajKasnjenje.Text = "Izvjestaj Kasnjenje";
            this.BtnIzvjestajKasnjenje.UseVisualStyleBackColor = true;
            this.BtnIzvjestajKasnjenje.Click += new System.EventHandler(this.BtnIzvjestajKasnjenje_Click);
            // 
            // BtnIzbrisi1
            // 
            this.BtnIzbrisi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnIzbrisi1.Location = new System.Drawing.Point(507, 107);
            this.BtnIzbrisi1.Name = "BtnIzbrisi1";
            this.BtnIzbrisi1.Size = new System.Drawing.Size(204, 42);
            this.BtnIzbrisi1.TabIndex = 23;
            this.BtnIzbrisi1.Text = "Izbrisi";
            this.BtnIzbrisi1.UseVisualStyleBackColor = true;
            this.BtnIzbrisi1.Click += new System.EventHandler(this.BtnIzbrisi1_Click);
            // 
            // BtnIzvjestajZanrovi
            // 
            this.BtnIzvjestajZanrovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnIzvjestajZanrovi.Location = new System.Drawing.Point(767, 273);
            this.BtnIzvjestajZanrovi.Name = "BtnIzvjestajZanrovi";
            this.BtnIzvjestajZanrovi.Size = new System.Drawing.Size(200, 36);
            this.BtnIzvjestajZanrovi.TabIndex = 24;
            this.BtnIzvjestajZanrovi.Text = "Izvjestaj Zanrovi";
            this.BtnIzvjestajZanrovi.UseVisualStyleBackColor = true;
            this.BtnIzvjestajZanrovi.Click += new System.EventHandler(this.BtnIzvjestajZanrovi_Click);
            // 
            // Posudba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 590);
            this.Controls.Add(this.BtnIzvjestajZanrovi);
            this.Controls.Add(this.BtnIzbrisi1);
            this.Controls.Add(this.BtnIzvjestajKasnjenje);
            this.Controls.Add(this.BtnKasnjenje);
            this.Controls.Add(this.LblDatumVracanja);
            this.Controls.Add(this.LblDatumPosudbe);
            this.Controls.Add(this.BtnSakrij);
            this.Controls.Add(this.BtnPrikaziSve);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.LblBrojDana);
            this.Controls.Add(this.TxtPretrazi);
            this.Controls.Add(this.CboPretrazi);
            this.Controls.Add(this.BtnPretrazi);
            this.Controls.Add(this.BtnUredi);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.DTPVracanje);
            this.Controls.Add(this.DTPPosudba);
            this.Controls.Add(this.LblSifraClana);
            this.Controls.Add(this.CboSifraClana);
            this.Controls.Add(this.LblSifraKnjige);
            this.Controls.Add(this.CboSifraKnjige);
            this.Name = "Posudba";
            this.Text = "Posudba";
            this.Shown += new System.EventHandler(this.Posudba_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboSifraKnjige;
        private System.Windows.Forms.Label LblSifraKnjige;
        private System.Windows.Forms.ComboBox CboSifraClana;
        private System.Windows.Forms.Label LblSifraClana;
        private System.Windows.Forms.DateTimePicker DTPPosudba;
        private System.Windows.Forms.DateTimePicker DTPVracanje;
        private System.Windows.Forms.Button BtnDodaj;
        private System.Windows.Forms.Button BtnUredi;
        private System.Windows.Forms.Button BtnPretrazi;
        private System.Windows.Forms.ComboBox CboPretrazi;
        private System.Windows.Forms.TextBox TxtPretrazi;
        private System.Windows.Forms.Label LblBrojDana;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button BtnPrikaziSve;
        private System.Windows.Forms.Button BtnSakrij;
        private System.Windows.Forms.BindingSource BindingSource1;
        private System.Windows.Forms.Label LblDatumPosudbe;
        private System.Windows.Forms.Label LblDatumVracanja;
        private System.Windows.Forms.Button BtnKasnjenje;
        private System.Windows.Forms.Button BtnIzvjestajKasnjenje;
        private System.Windows.Forms.Button BtnIzbrisi1;
        private System.Windows.Forms.Button BtnIzvjestajZanrovi;
    }
}