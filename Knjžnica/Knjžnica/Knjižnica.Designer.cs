namespace Knjžnica
{
    partial class Knjižnica
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posuđeneKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knjigeToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.posuđeneKnjigeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            this.knjigeToolStripMenuItem.Click += new System.EventHandler(this.knjigeToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            this.korisniciToolStripMenuItem.Click += new System.EventHandler(this.korisniciToolStripMenuItem_Click);
            // 
            // posuđeneKnjigeToolStripMenuItem
            // 
            this.posuđeneKnjigeToolStripMenuItem.Name = "posuđeneKnjigeToolStripMenuItem";
            this.posuđeneKnjigeToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.posuđeneKnjigeToolStripMenuItem.Text = "Posuđene knjige";
            this.posuđeneKnjigeToolStripMenuItem.Click += new System.EventHandler(this.posuđeneKnjigeToolStripMenuItem_Click);
            // 
            // Knjižnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 680);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Knjižnica";
            this.Text = "Knjižnica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posuđeneKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

