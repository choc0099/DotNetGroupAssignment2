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
    public partial class IncidentReport : Form
    {
        public IncidentReport()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string description = issueDesc.Text;
            string roomNumber = roomNo.Text;

            // Validation
            if (string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(roomNumber))
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            // filename
            string fileName = $"{roomNumber}_report.txt";

            // Creates or appends to the txt file
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")); // Timestamp
                    writer.WriteLine(description); // Incident description
                    writer.WriteLine(); // Empty line for separation
                }

                MessageBox.Show("Incident report saved successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void issueDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void roomNo_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
