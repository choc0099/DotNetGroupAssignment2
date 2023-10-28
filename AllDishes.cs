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
            List<string> dishInfo = new List<string>();
            dishInfo = File.ReadAllLines("dishDisplay.txt").ToList();
            foreach (var line in dishInfo)
            {
                string[] dishSplit = line.Split(',');
                richTextBox1.AppendText("Dish: " + dishSplit[0] + "\n");
                richTextBox1.AppendText("Price: " + dishSplit[1] + "\n");
                richTextBox1.AppendText("Calories: " + dishSplit[2] + "\n");
                richTextBox1.AppendText("Meal Type: " + dishSplit[3] + "\n");
                richTextBox1.AppendText("Allergens: " + dishSplit[4] + "\n");
                richTextBox1.AppendText("Additional Info: " + dishSplit[5] + "\n");
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
