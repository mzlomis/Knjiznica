using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = "";//clear botto box of text
            //line below is used to separate the text by diferent characters
            var words = richTextBox1.Text.Split(new char[] { ' ', ',', '.','!' });
            //grab each word, check whether it's 5 or more in length, and keep track of the count
            var count = words.Count(word => word.Length >= 5);
            //line below shows count of words 5 or more characters in length
            richTextBox2.Text = $"Number of words 5 or more chars: {count}";

            richTextBox2.Text += "\nwords 5 or more chars. sorted";
            //line below pick out words that are 5 or more chars, turns that reslut into a list and saves to longWords
            var longWords = words.Where(word => word.Length >= 5).ToList();
            //line beow orders words from shortest to longest
            var longWordsSorted = longWords.OrderBy(word => word.Length).ToList();
            //grab each word from the longWordsSorted list, and display it to the richtextbox on the bottom
            longWordsSorted.ForEach(word => richTextBox2.Text += $"\n{word}");
        }
    }
}
