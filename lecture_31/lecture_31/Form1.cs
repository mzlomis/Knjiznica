using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//allows using directory class so we can get all the files in the folder

namespace lecture_31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFolderPath_DoubleClick(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();//when user double clicks in box, a folder browser shows
            txtFolderPath.Text = folderBrowserDialog1.SelectedPath;//puts selected path in dialog box
            btnListFiles.Enabled = true;//makes the button eneabled
        }

        private void btnListFiles_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";//clears the text so the outpu does not accumulate
            //we are going ot create an array
            //an array is a collection of items
            //array values can be examined one at a time using foreach loop
            //Directory.GetFiles returns an array of filen names, which is then saved to the files array
            string[] files = Directory.GetFiles(txtFolderPath.Text);
            foreach (string file in files)//grab each file name, store it to the variable file
                richTextBox1.Text += $"{file}\n";//display the file in the rich textbox
        }
    }
}
