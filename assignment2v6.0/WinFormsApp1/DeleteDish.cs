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
    public partial class DeleteDish : Form
    {
        public DeleteDish()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllText("dish.txt");
            //if (!File.Exists(deleteDishTxtBox.Text + ".txt"))
            //{
            //    MessageBox.Show("Dish not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ///
            //}
            if (!lines.Contains(deleteDishTxtBox.Text))
            {
                MessageBox.Show("Dish not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (lines.Contains(deleteDishTxtBox.Text))
            {
                if (!lines.Contains(deleteDishTxtBox.Text))
                {
                    MessageBox.Show("Dish not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (lines.Contains(deleteDishTxtBox.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Dish found. Would you like to delete " + deleteDishTxtBox.Text + "?", "Delete Dish", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.Yes)
                    {
                        File.WriteAllLines("dish.txt", File.ReadLines("dish.txt").Where(l => !l.Equals(deleteDishTxtBox.Text)).ToList());
                        File.WriteAllLines("dishDisplay.txt", File.ReadLines("dishDisplay.txt").Where(l => !l.Equals(deleteDishTxtBox.Text)).ToList());
                        File.Delete(deleteDishTxtBox.Text + ".txt");
                    }

                    if (dialogResult == DialogResult.No)
                    {

                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
