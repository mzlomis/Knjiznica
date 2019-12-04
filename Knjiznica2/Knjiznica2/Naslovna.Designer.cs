namespace Knjiznica2
{
    partial class Naslovna
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
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SluzbenikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClanoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PosudbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrijavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip1.Location = new System.Drawing.Point(0, 28);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(800, 25);
            this.ToolStrip1.TabIndex = 0;
            this.ToolStrip1.Text = "toolStrip1";
            this.ToolStrip1.BackColorChanged += new System.EventHandler(this.ToolStrip1_BackColorChanged);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SluzbenikToolStripMenuItem,
            this.AdministratorToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(800, 28);
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // SluzbenikToolStripMenuItem
            // 
            this.SluzbenikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClanoviToolStripMenuItem,
            this.PosudbaToolStripMenuItem});
            this.SluzbenikToolStripMenuItem.Name = "SluzbenikToolStripMenuItem";
            this.SluzbenikToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.SluzbenikToolStripMenuItem.Text = "Sluzbenik";
            // 
            // ClanoviToolStripMenuItem
            // 
            this.ClanoviToolStripMenuItem.Name = "ClanoviToolStripMenuItem";
            this.ClanoviToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.ClanoviToolStripMenuItem.Text = "Clanovi";
            this.ClanoviToolStripMenuItem.Click += new System.EventHandler(this.ClanoviToolStripMenuItem_Click);
            // 
            // PosudbaToolStripMenuItem
            // 
            this.PosudbaToolStripMenuItem.Name = "PosudbaToolStripMenuItem";
            this.PosudbaToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.PosudbaToolStripMenuItem.Text = "Posudba";
            this.PosudbaToolStripMenuItem.Click += new System.EventHandler(this.PosudbaToolStripMenuItem_Click);
            // 
            // AdministratorToolStripMenuItem
            // 
            this.AdministratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrijavaToolStripMenuItem});
            this.AdministratorToolStripMenuItem.Name = "AdministratorToolStripMenuItem";
            this.AdministratorToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.AdministratorToolStripMenuItem.Text = "Administrator";
            // 
            // PrijavaToolStripMenuItem
            // 
            this.PrijavaToolStripMenuItem.Name = "PrijavaToolStripMenuItem";
            this.PrijavaToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.PrijavaToolStripMenuItem.Text = "Prijava";
            this.PrijavaToolStripMenuItem.Click += new System.EventHandler(this.PrijavaToolStripMenuItem_Click);
            // 
            // Naslovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "Naslovna";
            this.Text = "Naslovna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SluzbenikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClanoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PosudbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrijavaToolStripMenuItem;
    }
}

