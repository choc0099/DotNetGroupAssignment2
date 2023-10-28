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
    public partial class NewCustomerForm : Form
    {
        LoginForm loginform;
        string username, usertype;
        public NewCustomerForm(LoginForm loginform)
        {
            InitializeComponent();
            this.loginform = loginform;
        }

        public Boolean isFormComplete()
        {
            if (String.IsNullOrEmpty(userTxtBox.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (validUsername(userTxtBox.Text))
            {
                MessageBox.Show("Username already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (!(passTxtBox.Text.Equals(passReenterTxtBox.Text)) || String.IsNullOrEmpty(passTxtBox.Text))
            {
                MessageBox.Show("Passwords do not match or is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (String.IsNullOrEmpty(emailTxtBox.Text))
            {
                MessageBox.Show("Email cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if (!emailTxtBox.Text.Contains("@gmail.com") && !emailTxtBox.Text.Contains("outlook.com") && !emailTxtBox.Text.Contains("@uts.edu.au"))
            {
                MessageBox.Show("Invalid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if (String.IsNullOrEmpty(phoneTxtBox.Text))
            {
                MessageBox.Show("Phone number cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if ((phoneTxtBox.Text).Length < 10)
            {
                MessageBox.Show("Invalid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if (String.IsNullOrEmpty(addressTxtBox.Text))
            {
                MessageBox.Show("Address cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if (String.IsNullOrEmpty(cityTxtBox.Text))
            {
                MessageBox.Show("City cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if (String.IsNullOrEmpty(stateComboBox.Text))
            {
                MessageBox.Show("State cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else
            {
                return true;
            }

        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (isFormComplete() == true)
            {
                string address = addressTxtBox.Text + " " + cityTxtBox.Text + " " + stateComboBox.Text;
                User user = new User(userTxtBox.Text, passTxtBox.Text, fNameTxtBox.Text, surnameTxtBox.Text, emailTxtBox.Text, phoneTxtBox.Text, address, dobPicker.Text);
                string userInfo = (fNameTxtBox.Text + " " + surnameTxtBox.Text + "|" + emailTxtBox.Text + "|" + phoneTxtBox.Text + "|" + address + "|" + dobPicker.Text + "|Role: Customer");
                MessageBox.Show("Account has been created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.AppendAllText("customerDB.txt", fNameTxtBox.Text + " " + surnameTxtBox.Text + "," + userTxtBox.Text + "\n");
                File.WriteAllText(userTxtBox.Text + ".txt", userInfo);
                Close();
                loginform.Show();
            }
        }

        

        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dobPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void userTxtBx_TextChanged(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            Close();
            loginform.Show();
        }

        private void fNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void surnameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        public int userID()
        {
            for (int i = 10000; i < 9999999; i++) //generates code beginning from 10000
            {
                if (System.IO.File.Exists(i + ".txt")) //checks if a code with value 'i' exists in the name of a .txt file. for e.g., it checks if 10000.txt exists. if so, it does nothing. if not, it generates a code.
                {
                    Console.WriteLine("what");
                }
                else
                {
                    return i;
                }
            }
            return 0;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        public Boolean validUsername(string username)
        {
            string[] accInfo = File.ReadAllLines("login.txt");
            for (int i = 0; i < File.ReadLines("login.txt").Count(); i++)
            {
                string[] temp = accInfo[i].Split(',');
                Console.WriteLine(temp[0]);
                if (temp[0] == username)
                {
                    return true;
                }
                else
                {

                }
            }
            return false;
        }
        
    }
}
