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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("login.txt");
            var lines1 = File.ReadAllLines("customerDB.txt");
            //if (!File.Exists(deleteCustomerTxtBox.Text + ".txt"))
            //{
            //    MessageBox.Show("no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //}
            //else if (File.Exists(deleteCustomerTxtBox.Text + ".txt"))
            //{
            if (!lines.Contains(deleteUsernameTxtBox.Text + "," + deletePasswordTxtBox.Text) && !lines1.Contains(deleteNameBox.Text + "," + deleteUsernameTxtBox.Text))
            {
                MessageBox.Show("User not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (lines.Contains(deleteUsernameTxtBox.Text + "," + deletePasswordTxtBox.Text) && lines1.Contains(deleteNameBox.Text + "," + deleteUsernameTxtBox.Text))
            {
                DialogResult dialogResult = MessageBox.Show("User found. Would you like to delete " + deleteUsernameTxtBox.Text + "?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    File.WriteAllLines("login.txt", File.ReadLines("login.txt").Where(l => !l.Equals(deleteUsernameTxtBox.Text + "," + deletePasswordTxtBox.Text)).ToList());
                    File.WriteAllLines("customerDB.txt", File.ReadLines("customerDB.txt").Where(l => !l.Equals(deleteNameBox.Text + "," + deleteUsernameTxtBox.Text)).ToList());
                    File.Delete(deleteUsernameTxtBox.Text + ".txt");
                }

                if (dialogResult == DialogResult.No)
                {

                }

            }

            if (lines.Contains(deleteUsernameTxtBox.Text + "," + deletePasswordTxtBox.Text) && !lines1.Contains(deleteNameBox.Text + "," + deleteUsernameTxtBox.Text))
            {
                MessageBox.Show("User not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //}
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deletePasswordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
