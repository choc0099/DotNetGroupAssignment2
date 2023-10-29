﻿using System;
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
    public partial class SearchCustomer : Form
    {
        public SearchCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllText("login.txt");
            
            if (!File.Exists(customerSearch.Text + ".txt")) //Checks if user input exists as a text file; if it does not exist, this error shows.
            {
                MessageBox.Show("User not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            if (File.Exists(customerSearch.Text + ".txt") && !File.ReadAllLines(customerSearch.Text + ".txt").Contains("Role: Admin")) //Checks if user input exists as a text file
            {
                if (File.ReadAllLines(customerSearch.Text + ".txt").Contains("Role: Admin")) //Ensures that any user files that belong to an admin do not display.
                {
                    MessageBox.Show("User not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (lines.Contains(customerSearch.Text)) //Displays user information assuming the user input is valid.
                {
                    richTextBox1.Clear();
                    List<string> custInfo = new List<string>();
                    custInfo = File.ReadAllLines(customerSearch.Text + ".txt").ToList();
                    foreach (var line in custInfo)
                    {
                        string[] custSplit = line.Split('|');
                        richTextBox1.AppendText("Name: " + custSplit[0] + "\n");
                        richTextBox1.AppendText("Email: " + custSplit[1] + "\n");
                        richTextBox1.AppendText("Phone: " + custSplit[2] + "\n");
                        richTextBox1.AppendText("Address: " + custSplit[3] + "\n");
                        richTextBox1.AppendText("Date of Birth: " + custSplit[4] + "\n");
                    }
                }
            }
        }
        

        private void button1_Click(object sender, EventArgs e) //Closes SearchCustomer
        {
            Close();
        }
    }
}
