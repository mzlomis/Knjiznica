namespace Knjžnica
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtNaslovKnjige = new System.Windows.Forms.TextBox();
            this.txtSignatura = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTraži = new System.Windows.Forms.Button();
            this.cboTraži = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzbriši = new System.Windows.Forms.Button();
            this.txtTraži1 = new System.Windows.Forms.TextBox();
            this.btnIspiši = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Naslov knjige";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Signatura";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(143, 15);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(184, 22);
            this.txtAutor.TabIndex = 5;
            // 
            // txtNaslovKnjige
            // 
            this.txtNaslovKnjige.Location = new System.Drawing.Point(143, 61);
            this.txtNaslovKnjige.Name = "txtNaslovKnjige";
            this.txtNaslovKnjige.Size = new System.Drawing.Size(184, 22);
            this.txtNaslovKnjige.TabIndex = 6;
            // 
            // txtSignatura
            // 
            this.txtSignatura.Location = new System.Drawing.Point(143, 100);
            this.txtSignatura.Name = "txtSignatura";
            this.txtSignatura.Size = new System.Drawing.Size(184, 22);
            this.txtSignatura.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 191);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
            // 
            // btnTraži
            // 
            this.btnTraži.Location = new System.Drawing.Point(12, 137);
            this.btnTraži.Name = "btnTraži";
            this.btnTraži.Size = new System.Drawing.Size(87, 28);
            this.btnTraži.TabIndex = 9;
            this.btnTraži.Text = "Traži";
            this.btnTraži.UseVisualStyleBackColor = true;
            this.btnTraži.Click += new System.EventHandler(this.btnTraži_Click);
            // 
            // cboTraži
            // 
            this.cboTraži.FormattingEnabled = true;
            this.cboTraži.Items.AddRange(new object[] {
            "ID_broj_knjige",
            "Autor",
            "Naslov_knjige",
            "Signatura"});
            this.cboTraži.Location = new System.Drawing.Point(143, 138);
            this.cboTraži.Name = "cboTraži";
            this.cboTraži.Size = new System.Drawing.Size(184, 24);
            this.cboTraži.TabIndex = 10;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(426, 9);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(179, 28);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // btnIzbriši
            // 
            this.btnIzbriši.Location = new System.Drawing.Point(426, 50);
            this.btnIzbriši.Name = "btnIzbriši";
            this.btnIzbriši.Size = new System.Drawing.Size(179, 28);
            this.btnIzbriši.TabIndex = 13;
            this.btnIzbriši.Text = "Izbriši";
            this.btnIzbriši.UseVisualStyleBackColor = true;
            this.btnIzbriši.Click += new System.EventHandler(this.btnIzbriši_Click);
            // 
            // txtTraži1
            // 
            this.txtTraži1.Location = new System.Drawing.Point(426, 137);
            this.txtTraži1.Name = "txtTraži1";
            this.txtTraži1.Size = new System.Drawing.Size(181, 22);
            this.txtTraži1.TabIndex = 22;
            // 
            // btnIspiši
            // 
            this.btnIspiši.Location = new System.Drawing.Point(426, 95);
            this.btnIspiši.Name = "btnIspiši";
            this.btnIspiši.Size = new System.Drawing.Size(179, 25);
            this.btnIspiši.TabIndex = 23;
            this.btnIspiši.Text = "Ispiši";
            this.btnIspiši.UseVisualStyleBackColor = true;
            this.btnIspiši.Click += new System.EventHandler(this.btnIspiši_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Knjžnica.Knjige);
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 465);
            this.Controls.Add(this.btnIspiši);
            this.Controls.Add(this.txtTraži1);
            this.Controls.Add(this.btnIzbriši);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cboTraži);
            this.Controls.Add(this.btnTraži);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSignatura);
            this.Controls.Add(this.txtNaslovKnjige);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Knjige";
            this.Text = "Knjige";
            this.Load += new System.EventHandler(this.Knjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNaslovKnjige;
        private System.Windows.Forms.TextBox txtSignatura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTraži;
        private System.Windows.Forms.ComboBox cboTraži;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzbriši;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtTraži1;
        private System.Windows.Forms.Button btnIspiši;
    }
}