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
    public partial class AllDishes : Form
    {
        public AllDishes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            var fileLocation = File.ReadAllLines("dishDisplay.txt");
            List<string> lines = new List<string>(fileLocation);
            for (int i = 0; i < lines.Count; i++)
            {
                richTextBox1.AppendText(lines[i] + "\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
