using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class viewIncidents : Form
    {
        public viewIncidents()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.viewIncidents_Load);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewIncidents_Load(object sender, EventArgs e)
        {
            // Directory where the incident report text files are stored
            string reportsDirectory = Path.Combine(Directory.GetCurrentDirectory());

            comboBoxRoomNumbers.Items.Clear();

            // Gets list of text files in the directory that end with "_report.txt"
            string[] reportFiles = Directory.GetFiles(reportsDirectory, "*_report.txt");

            foreach (string reportFile in reportFiles)
            {
                string fileName = Path.GetFileNameWithoutExtension(reportFile);

                // Check if the file name ends with "_report" and if the rest of the name is a number
                if (fileName.EndsWith("_report") && int.TryParse(fileName.Substring(0, fileName.Length - 7), out int roomNumber))
                {
                    comboBoxRoomNumbers.Items.Add(roomNumber);
                }
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (comboBoxRoomNumbers.SelectedItem != null)
            {
                int selectedRoomNumber = (int)comboBoxRoomNumbers.SelectedItem;

                // Get the directory
                string appDirectory = Application.StartupPath;

                // relative path
                string relativeFilePath = $"{selectedRoomNumber}_report.txt";

                // Combine the app directory with the relative file path
                string filePath = Path.Combine(appDirectory, relativeFilePath);

                if (File.Exists(filePath))
                {
                    string fileContents = File.ReadAllText(filePath);
                    reportRichTextBox.Text = fileContents;
                }
                else
                {
                    reportRichTextBox.Text = "Report not found for this room.";
                }
            }
        }
    }
}
