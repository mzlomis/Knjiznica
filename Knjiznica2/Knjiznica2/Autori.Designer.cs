namespace Knjiznica2
{
    partial class Autori
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
            this.LblAutor = new System.Windows.Forms.Label();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.BtnDodaj = new System.Windows.Forms.Button();
            this.BtnIzbrisi = new System.Windows.Forms.Button();
            this.BtnUredi = new System.Windows.Forms.Button();
            this.CboPretrazi = new System.Windows.Forms.ComboBox();
            this.BtnPretrazi = new System.Windows.Forms.Button();
            this.BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TxtPretrazi = new System.Windows.Forms.TextBox();
            this.BtnPrikaziSve = new System.Windows.Forms.Button();
            this.BtnSakrij = new System.Windows.Forms.Button();
            this.BtnPopisAutora = new System.Windows.Forms.Button();
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
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 270);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(550, 202);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.AllowUserToAddRowsChanged += new System.EventHandler(this.Autori_Shown);
            this.DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblAutor.Location = new System.Drawing.Point(12, 39);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(49, 20);
            this.LblAutor.TabIndex = 1;
            this.LblAutor.Text = "Autor";
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(70, 39);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(216, 22);
            this.TxtAutor.TabIndex = 2;
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDodaj.Location = new System.Drawing.Point(292, 33);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(88, 32);
            this.BtnDodaj.TabIndex = 3;
            this.BtnDodaj.Text = "Dodaj";
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // BtnIzbrisi
            // 
            this.BtnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnIzbrisi.Location = new System.Drawing.Point(479, 33);
            this.BtnIzbrisi.Name = "BtnIzbrisi";
            this.BtnIzbrisi.Size = new System.Drawing.Size(87, 32);
            this.BtnIzbrisi.TabIndex = 4;
            this.BtnIzbrisi.Text = "Izbrisi";
            this.BtnIzbrisi.UseVisualStyleBackColor = true;
            this.BtnIzbrisi.Click += new System.EventHandler(this.BtnIzbrisi_Click);
            // 
            // BtnUredi
            // 
            this.BtnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnUredi.Location = new System.Drawing.Point(390, 33);
            this.BtnUredi.Name = "BtnUredi";
            this.BtnUredi.Size = new System.Drawing.Size(83, 32);
            this.BtnUredi.TabIndex = 5;
            this.BtnUredi.Text = "Uredi";
            this.BtnUredi.UseVisualStyleBackColor = true;
            this.BtnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // CboPretrazi
            // 
            this.CboPretrazi.FormattingEnabled = true;
            this.CboPretrazi.Items.AddRange(new object[] {
            "Sifra",
            "Autor"});
            this.CboPretrazi.Location = new System.Drawing.Point(176, 93);
            this.CboPretrazi.Name = "CboPretrazi";
            this.CboPretrazi.Size = new System.Drawing.Size(154, 24);
            this.CboPretrazi.TabIndex = 6;
            // 
            // BtnPretrazi
            // 
            this.BtnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPretrazi.Location = new System.Drawing.Point(12, 87);
            this.BtnPretrazi.Name = "BtnPretrazi";
            this.BtnPretrazi.Size = new System.Drawing.Size(138, 32);
            this.BtnPretrazi.TabIndex = 7;
            this.BtnPretrazi.Text = "Pretrazi";
            this.BtnPretrazi.UseVisualStyleBackColor = true;
            this.BtnPretrazi.Click += new System.EventHandler(this.BtnPretrazi_Click);
            // 
            // TxtPretrazi
            // 
            this.TxtPretrazi.Location = new System.Drawing.Point(347, 95);
            this.TxtPretrazi.Name = "TxtPretrazi";
            this.TxtPretrazi.Size = new System.Drawing.Size(215, 22);
            this.TxtPretrazi.TabIndex = 8;
            // 
            // BtnPrikaziSve
            // 
            this.BtnPrikaziSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPrikaziSve.Location = new System.Drawing.Point(12, 159);
            this.BtnPrikaziSve.Name = "BtnPrikaziSve";
            this.BtnPrikaziSve.Size = new System.Drawing.Size(138, 32);
            this.BtnPrikaziSve.TabIndex = 9;
            this.BtnPrikaziSve.Text = "Prikazi sve";
            this.BtnPrikaziSve.UseVisualStyleBackColor = true;
            this.BtnPrikaziSve.Click += new System.EventHandler(this.BtnPrikaziSve_Click);
            // 
            // BtnSakrij
            // 
            this.BtnSakrij.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSakrij.Location = new System.Drawing.Point(176, 156);
            this.BtnSakrij.Name = "BtnSakrij";
            this.BtnSakrij.Size = new System.Drawing.Size(169, 35);
            this.BtnSakrij.TabIndex = 10;
            this.BtnSakrij.Text = "Prikazi prva 2 reda";
            this.BtnSakrij.UseVisualStyleBackColor = true;
            this.BtnSakrij.Click += new System.EventHandler(this.BtnSakrij_Click);
            // 
            // BtnPopisAutora
            // 
            this.BtnPopisAutora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPopisAutora.Location = new System.Drawing.Point(361, 156);
            this.BtnPopisAutora.Name = "BtnPopisAutora";
            this.BtnPopisAutora.Size = new System.Drawing.Size(201, 35);
            this.BtnPopisAutora.TabIndex = 11;
            this.BtnPopisAutora.Text = "Popis Autora";
            this.BtnPopisAutora.UseVisualStyleBackColor = true;
            this.BtnPopisAutora.Click += new System.EventHandler(this.BtnPopisAutora_Click);
            // 
            // Autori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 484);
            this.Controls.Add(this.BtnPopisAutora);
            this.Controls.Add(this.BtnSakrij);
            this.Controls.Add(this.BtnPrikaziSve);
            this.Controls.Add(this.TxtPretrazi);
            this.Controls.Add(this.BtnPretrazi);
            this.Controls.Add(this.CboPretrazi);
            this.Controls.Add(this.BtnUredi);
            this.Controls.Add(this.BtnIzbrisi);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.DataGridView);
            this.Name = "Autori";
            this.Text = "Autori";
            this.Shown += new System.EventHandler(this.Autori_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.Button BtnDodaj;
        private System.Windows.Forms.Button BtnIzbrisi;
        private System.Windows.Forms.Button BtnUredi;
        private System.Windows.Forms.ComboBox CboPretrazi;
        private System.Windows.Forms.Button BtnPretrazi;
        private System.Windows.Forms.BindingSource BindingSource1;
        private System.Windows.Forms.TextBox TxtPretrazi;
        private System.Windows.Forms.Button BtnPrikaziSve;
        private System.Windows.Forms.Button BtnSakrij;
        private System.Windows.Forms.Button BtnPopisAutora;
    }
}