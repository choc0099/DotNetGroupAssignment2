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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace assignment2
{
    public partial class LoginForm : Form
    {
        LoginForm loginform;
        string username;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewUserBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new NewCustomerForm(this).Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //userTxtBx
            Boolean loggedin = false;

            string[] accInfo = File.ReadAllLines("login.txt");
            if (File.Exists(userTxtBx.Text + ".txt"))
            {
                if (File.ReadAllText(userTxtBx.Text + ".txt").Contains("Role: Admin"))
                {
                    for (int i = 0; i < File.ReadAllLines("login.txt").Length; i++)
                    {
                        string[] temp = accInfo[i].Split(',');
                        //Console.WriteLine(temp[0] + temp[1]);


                        if (temp[0] == userTxtBx.Text && temp[1] == PassTxtbox.Text)
                        {
                            Hide();
                            new Admin(this, username).Show();
                            loggedin = true;
                        }
                        else if (temp[0] == userTxtBx.Text && temp[1] != PassTxtbox.Text)
                        {
                            MessageBox.Show("Incorrect credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            loggedin = false;
                        }
                        
                        else if (!System.IO.File.Exists(userTxtBx.Text + ".txt"))
                        {
                            MessageBox.Show("Incorrect credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            loggedin = false;
                        }
                    }
                }

                if (File.ReadAllText(userTxtBx.Text + ".txt").Contains("Role: Customer"))
                {
                    for (int i = 0; i < File.ReadAllLines("login.txt").Length; i++)
                    {
                        string[] temp = accInfo[i].Split(',');
                        //Console.WriteLine(temp[0] + temp[1]);
                        if (System.IO.File.Exists(userTxtBx.Text + ".txt"))
                        {
                            if (temp[0] == userTxtBx.Text && temp[1] == PassTxtbox.Text)
                            {
                                Hide();
                                new Customer(this, username).Show();
                                loggedin = true;
                            }
                            else if (temp[0] == userTxtBx.Text && temp[1] != PassTxtbox.Text)
                            {
                                MessageBox.Show("Incorrect credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                loggedin = false;
                            }
                        }
                        else if (!System.IO.File.Exists(userTxtBx.Text + ".txt"))
                        {
                            MessageBox.Show("Incorrect credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            loggedin = false;
                        }
                    }
                }

                if (File.ReadAllText(userTxtBx.Text + ".txt").Contains("Role: Receptionist"))
                {
                    for (int i = 0; i < File.ReadAllLines("login.txt").Length; i++)
                    {
                        string[] temp = accInfo[i].Split(',');
                        //Console.WriteLine(temp[0] + temp[1]);
                        if (System.IO.File.Exists(userTxtBx.Text + ".txt"))
                        {
                            if (temp[0] == userTxtBx.Text && temp[1] == PassTxtbox.Text)
                            {
                                Hide();
                                new ReceptionistForm(this, username).Show();
                                loggedin = true;
                            }
                            else if (temp[0] == userTxtBx.Text && temp[1] != PassTxtbox.Text)
                            {
                                MessageBox.Show("Incorrect credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                loggedin = false;
                            }
                        }
                        else if (!System.IO.File.Exists(userTxtBx.Text + ".txt"))
                        {
                            MessageBox.Show("Incorrect credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            loggedin = false;
                        }
                    }
                }
                
            }
            if (!File.Exists(userTxtBx.Text + ".txt"))
                {
                    MessageBox.Show("User does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    loggedin = false;
                }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameLbl_Click(object sender, EventArgs e)
        {

        }

        private void passwordLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
