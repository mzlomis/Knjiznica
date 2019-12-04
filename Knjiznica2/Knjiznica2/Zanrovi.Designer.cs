namespace Knjiznica2
{
    partial class Zanrovi
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.TxtZanr = new System.Windows.Forms.TextBox();
            this.LblZanr = new System.Windows.Forms.Label();
            this.BtnDodaj = new System.Windows.Forms.Button();
            this.BtnIzbrisi = new System.Windows.Forms.Button();
            this.BtnUredi = new System.Windows.Forms.Button();
            this.BtnPretrazi = new System.Windows.Forms.Button();
            this.CboPretrazi = new System.Windows.Forms.ComboBox();
            this.BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TxtTrazi = new System.Windows.Forms.TextBox();
            this.BtnPrikaziSve = new System.Windows.Forms.Button();
            this.BtnSakrij = new System.Windows.Forms.Button();
            this.BtnPopisZanrova = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 253);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(586, 244);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            // 
            // TxtZanr
            // 
            this.TxtZanr.Location = new System.Drawing.Point(77, 32);
            this.TxtZanr.Name = "TxtZanr";
            this.TxtZanr.Size = new System.Drawing.Size(181, 22);
            this.TxtZanr.TabIndex = 1;
            // 
            // LblZanr
            // 
            this.LblZanr.AutoSize = true;
            this.LblZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblZanr.Location = new System.Drawing.Point(12, 32);
            this.LblZanr.Name = "LblZanr";
            this.LblZanr.Size = new System.Drawing.Size(42, 20);
            this.LblZanr.TabIndex = 2;
            this.LblZanr.Text = "Zanr";
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDodaj.Location = new System.Drawing.Point(264, 28);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(104, 30);
            this.BtnDodaj.TabIndex = 3;
            this.BtnDodaj.Text = "Dodaj";
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // BtnIzbrisi
            // 
            this.BtnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnIzbrisi.Location = new System.Drawing.Point(496, 28);
            this.BtnIzbrisi.Name = "BtnIzbrisi";
            this.BtnIzbrisi.Size = new System.Drawing.Size(101, 30);
            this.BtnIzbrisi.TabIndex = 4;
            this.BtnIzbrisi.Text = "Izbrisi";
            this.BtnIzbrisi.UseVisualStyleBackColor = true;
            this.BtnIzbrisi.Click += new System.EventHandler(this.BtnIzbrisi_Click);
            // 
            // BtnUredi
            // 
            this.BtnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnUredi.Location = new System.Drawing.Point(374, 28);
            this.BtnUredi.Name = "BtnUredi";
            this.BtnUredi.Size = new System.Drawing.Size(116, 30);
            this.BtnUredi.TabIndex = 5;
            this.BtnUredi.Text = "Uredi";
            this.BtnUredi.UseVisualStyleBackColor = true;
            this.BtnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // BtnPretrazi
            // 
            this.BtnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPretrazi.Location = new System.Drawing.Point(16, 103);
            this.BtnPretrazi.Name = "BtnPretrazi";
            this.BtnPretrazi.Size = new System.Drawing.Size(144, 30);
            this.BtnPretrazi.TabIndex = 6;
            this.BtnPretrazi.Text = "Pretrazi";
            this.BtnPretrazi.UseVisualStyleBackColor = true;
            this.BtnPretrazi.Click += new System.EventHandler(this.BtnPretrazi_Click);
            // 
            // CboPretrazi
            // 
            this.CboPretrazi.FormattingEnabled = true;
            this.CboPretrazi.Items.AddRange(new object[] {
            "Sifra",
            "Zanr"});
            this.CboPretrazi.Location = new System.Drawing.Point(176, 108);
            this.CboPretrazi.Name = "CboPretrazi";
            this.CboPretrazi.Size = new System.Drawing.Size(192, 24);
            this.CboPretrazi.TabIndex = 7;
            // 
            // TxtTrazi
            // 
            this.TxtTrazi.Location = new System.Drawing.Point(374, 108);
            this.TxtTrazi.Name = "TxtTrazi";
            this.TxtTrazi.Size = new System.Drawing.Size(223, 22);
            this.TxtTrazi.TabIndex = 8;
            // 
            // BtnPrikaziSve
            // 
            this.BtnPrikaziSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPrikaziSve.Location = new System.Drawing.Point(16, 176);
            this.BtnPrikaziSve.Name = "BtnPrikaziSve";
            this.BtnPrikaziSve.Size = new System.Drawing.Size(144, 32);
            this.BtnPrikaziSve.TabIndex = 9;
            this.BtnPrikaziSve.Text = "Prikazi Sve";
            this.BtnPrikaziSve.UseVisualStyleBackColor = true;
            this.BtnPrikaziSve.Click += new System.EventHandler(this.BtnPrikaziSve_Click);
            // 
            // BtnSakrij
            // 
            this.BtnSakrij.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSakrij.Location = new System.Drawing.Point(176, 176);
            this.BtnSakrij.Name = "BtnSakrij";
            this.BtnSakrij.Size = new System.Drawing.Size(192, 32);
            this.BtnSakrij.TabIndex = 10;
            this.BtnSakrij.Text = "Prikazi prva 2 reda";
            this.BtnSakrij.UseVisualStyleBackColor = true;
            this.BtnSakrij.Click += new System.EventHandler(this.BtnSakrij_Click);
            // 
            // BtnPopisZanrova
            // 
            this.BtnPopisZanrova.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPopisZanrova.Location = new System.Drawing.Point(387, 176);
            this.BtnPopisZanrova.Name = "BtnPopisZanrova";
            this.BtnPopisZanrova.Size = new System.Drawing.Size(210, 32);
            this.BtnPopisZanrova.TabIndex = 11;
            this.BtnPopisZanrova.Text = "Popis Zanorva";
            this.BtnPopisZanrova.UseVisualStyleBackColor = true;
            this.BtnPopisZanrova.Click += new System.EventHandler(this.BtnPopisZanrova_Click);
            // 
            // Zanrovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 509);
            this.Controls.Add(this.BtnPopisZanrova);
            this.Controls.Add(this.BtnSakrij);
            this.Controls.Add(this.BtnPrikaziSve);
            this.Controls.Add(this.TxtTrazi);
            this.Controls.Add(this.CboPretrazi);
            this.Controls.Add(this.BtnPretrazi);
            this.Controls.Add(this.BtnUredi);
            this.Controls.Add(this.BtnIzbrisi);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.LblZanr);
            this.Controls.Add(this.TxtZanr);
            this.Controls.Add(this.DataGridView);
            this.Name = "Zanrovi";
            this.Text = "Zanrovi";
            this.Shown += new System.EventHandler(this.Zanrovi_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox TxtZanr;
        private System.Windows.Forms.Label LblZanr;
        private System.Windows.Forms.Button BtnDodaj;
        private System.Windows.Forms.Button BtnIzbrisi;
        private System.Windows.Forms.Button BtnUredi;
        private System.Windows.Forms.Button BtnPretrazi;
        private System.Windows.Forms.ComboBox CboPretrazi;
        private System.Windows.Forms.BindingSource BindingSource1;
        private System.Windows.Forms.TextBox TxtTrazi;
        private System.Windows.Forms.Button BtnPrikaziSve;
        private System.Windows.Forms.Button BtnSakrij;
        private System.Windows.Forms.Button BtnPopisZanrova;
    }
}