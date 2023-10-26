using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace assignment2
{
    public partial class SearchDish : Form
    {
        string lines;

        public SearchDish()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllText("dishDisplay.txt");
            if (!File.Exists(dishSearch.Text + ".txt"))
            {
                MessageBox.Show(dishSearch.Text + " was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (File.Exists(dishSearch.Text + ".txt"))
            {
                
                if (!lines.Contains(dishSearch.Text))
                {
                    MessageBox.Show("Dish not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (lines.Contains(dishSearch.Text))
                {
                    richTextBox1.Clear();
                    List<string> dishInfo = new List<string>();
                    dishInfo = File.ReadAllLines(dishSearch.Text + ".txt").ToList();
                    foreach (var line in dishInfo)
                    {
                        string[] dishSplit = line.Split(',');
                        string[] dishSplits = line.Split(',');
                        richTextBox1.AppendText(dishSplit[0] + "\n");
                    }
                }
                
            }
        }



        private void dishSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
