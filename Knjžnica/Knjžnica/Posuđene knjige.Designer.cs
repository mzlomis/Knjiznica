namespace Knjžnica
{
    partial class Posuđene_knjige
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTraži3 = new System.Windows.Forms.Button();
            this.txtTraži3 = new System.Windows.Forms.TextBox();
            this.cboTraži3 = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.btnIspiši3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnTraži3
            // 
            this.btnTraži3.Location = new System.Drawing.Point(13, 27);
            this.btnTraži3.Name = "btnTraži3";
            this.btnTraži3.Size = new System.Drawing.Size(180, 28);
            this.btnTraži3.TabIndex = 1;
            this.btnTraži3.Text = "Traži";
            this.btnTraži3.UseVisualStyleBackColor = true;
            this.btnTraži3.Click += new System.EventHandler(this.btnTraži3_Click);
            // 
            // txtTraži3
            // 
            this.txtTraži3.Location = new System.Drawing.Point(396, 30);
            this.txtTraži3.Name = "txtTraži3";
            this.txtTraži3.Size = new System.Drawing.Size(198, 22);
            this.txtTraži3.TabIndex = 2;
            // 
            // cboTraži3
            // 
            this.cboTraži3.FormattingEnabled = true;
            this.cboTraži3.Items.AddRange(new object[] {
            "ID_Korisnika",
            "Posuđena_knjiga",
            "Prezime",
            "Datum_posudbe"});
            this.cboTraži3.Location = new System.Drawing.Point(199, 29);
            this.cboTraži3.Name = "cboTraži3";
            this.cboTraži3.Size = new System.Drawing.Size(191, 24);
            this.cboTraži3.TabIndex = 3;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // btnIspiši3
            // 
            this.btnIspiši3.Location = new System.Drawing.Point(610, 28);
            this.btnIspiši3.Name = "btnIspiši3";
            this.btnIspiši3.Size = new System.Drawing.Size(178, 26);
            this.btnIspiši3.TabIndex = 4;
            this.btnIspiši3.Text = "Ispiši dospjelo";
            this.btnIspiši3.UseVisualStyleBackColor = true;
            this.btnIspiši3.Click += new System.EventHandler(this.btnIspiši3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(396, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Posuđene_knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnIspiši3);
            this.Controls.Add(this.cboTraži3);
            this.Controls.Add(this.txtTraži3);
            this.Controls.Add(this.btnTraži3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Posuđene_knjige";
            this.Text = "Posuđene_knjige";
            this.Load += new System.EventHandler(this.Posuđene_knjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTraži3;
        private System.Windows.Forms.TextBox txtTraži3;
        private System.Windows.Forms.ComboBox cboTraži3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button btnIspiši3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}