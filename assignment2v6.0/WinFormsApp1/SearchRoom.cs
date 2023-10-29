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
    public partial class SearchRoom : Form
    {
        private string roomCode;
        public SearchRoom()
        {
            InitializeComponent();
            this.roomCode = "";
        }

        public SearchRoom(string roomCode)
        {
            InitializeComponent();
            this.roomCode = roomCode;
        }

        private void button1_Click(object sender, EventArgs e) //Closes SearchRoom
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllText("roomDisplay.txt");
            if (!File.Exists("Room " + roomSearch.Text + ".txt")) //Checks if user input exists as a text file; if it does not exist, this error shows.
            {
                MessageBox.Show("Room " + roomSearch.Text + " was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (File.Exists("Room " + roomSearch.Text + ".txt")) //Displays user information assuming the user input is valid.
            {             

                if (!lines.Contains(roomSearch.Text))
                {
                    MessageBox.Show("Room " + roomSearch.Text + " was not found.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                if (lines.Contains(roomSearch.Text))
                {
                    richTextBox1.Clear();
                    List<string> roomInfo = new List<string>();
                    roomInfo = File.ReadAllLines("Room " + roomSearch.Text + ".txt").ToList();
                    foreach (var line in roomInfo)
                    {
                        string[] roomSplit = line.Split(',');
                        string[] roomSplits = line.Split(',');
                        richTextBox1.AppendText("Room ID: " + roomSplit[0] + "\n");
                        richTextBox1.AppendText("Room Size: " + roomSplit[1] + "\n");
                        richTextBox1.AppendText("Bed Size: " + roomSplit[2] + "\n");
                        richTextBox1.AppendText("Room View: " + roomSplit[3] + "\n");
                        richTextBox1.AppendText("Features: " + roomSplit[4] + " " + roomSplit[5] + "\n");
                        richTextBox1.AppendText("Price: " + roomSplit[6] + "\n");
                        richTextBox1.AppendText("Additional Information: " + roomSplit[7] + "\n");
                    }


                }
            }
        }

        private void SearchRoom_Load(object sender, EventArgs e)
        {
            roomSearch.Text = roomCode;
        }
    }
}
