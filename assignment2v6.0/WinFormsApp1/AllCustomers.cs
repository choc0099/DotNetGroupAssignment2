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
    public partial class AllCustomers : Form
    {
        public AllCustomers()
        {

            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            var fileLocation = File.ReadAllLines("customerDB.txt");
            List<string> lines = new List<string>(fileLocation);
            List<string> dishInfo = new List<string>();
            dishInfo = File.ReadAllLines("customerDB.txt").ToList();
            foreach (var line in dishInfo)
            {
                string[] custSplit = line.Split(',');
                richTextBox1.AppendText("Full Name: " + custSplit[0] + "\n");
                richTextBox1.AppendText("Username: " + custSplit[1] + "\n" + "\n");
               
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
