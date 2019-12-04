using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture_26_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnFindVowels_Click(object sender, EventArgs e)
        {
            rchVowelsBox.Text = "";//clears the vowels box on each button click so the output does not grow
            string text = rchInputBox.Text.ToLower();//grab the text, convert it to lower case adn save to variable named text
            //in english the basic vowels are a, e, i, o, u
            //grab each character, compare it against a, e, i, o, u to se if it's a vowel
            foreach(char c in text)//needed to grab each character and store it in c for rach cycle of the loop
            {
                //check whether the character that c represents on each cycle happens to be one of the vowels
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    rchVowelsBox.Text += $"{c}\n";
                }
            }
        }
    }
}
