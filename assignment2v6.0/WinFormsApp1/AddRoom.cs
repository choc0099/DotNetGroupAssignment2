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
    public partial class AddRoom : Form
    {
        string wifi = "Wi-Fi";
        string tv = "TV";
        public AddRoom()
        {
            InitializeComponent();
        }
        public Boolean isFormComplete()
        {
            if (String.IsNullOrEmpty(sizeTxtBox.Text))
            {
                MessageBox.Show("Room size cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if (!(sizeTxtBox.Text).All(char.IsDigit))
            {
                MessageBox.Show("Please insert a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (String.IsNullOrEmpty(bedTxtBox.Text))
            {
                MessageBox.Show("Please put the bed size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if (String.IsNullOrEmpty(sightTxtBox.Text))
            {
                MessageBox.Show("Please insert a sight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }


            else if (String.IsNullOrEmpty(priceTxtBox.Text))
            {
                MessageBox.Show("Please insert a price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if (String.IsNullOrEmpty(AdditionalInformationBox.Text))
            {
                MessageBox.Show("Please insert any additional information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }



            else
            {
                return true;
            }

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void featureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wifiCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            int roomID = makeRoomID();
            if (isFormComplete() == true)
            {
                if (tvCheckBox.Checked && wifiCheckBox.Checked)
                {
                    string count = ((File.ReadLines("rooms.txt").Count()) + 1).ToString();
                    string roomInfo = (count + "00" + "," + sizeTxtBox.Text + "m," + bedTxtBox.Text + "," + sightTxtBox.Text + "," + wifi + "," + tv + "," + "$" + priceTxtBox.Text + "," + AdditionalInformationBox.Text);
                    string roomDisplay = ("Room ID: " + count + "00" + "\n" + "Room Size: " + sizeTxtBox.Text + "\n" + "Bed Size:" + bedTxtBox.Text + "\n" + "Sight: " + sightTxtBox.Text + "\n" + "Features: " + tv + ", " + wifi + "\n" + "Price: $" + priceTxtBox.Text + "\n" + "Additional Info: " + AdditionalInformationBox.Text + "\n");
                    Room rooms = new Room(count + "00", sizeTxtBox.Text, bedTxtBox.Text, sightTxtBox.Text, tv + "," + wifi, priceTxtBox.Text, AdditionalInformationBox.Text);
                    MessageBox.Show("Room has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.WriteAllText("Room " + (count + "00") + ".txt", roomInfo + "\n");
                    File.AppendAllText("roomDisplay.txt", roomDisplay + "\n");
                    Close();
                }

                else if (wifiCheckBox.Checked)
                {
                    string count = ((File.ReadLines("rooms.txt").Count()) + 1).ToString();
                    string roomInfo = (count + "00" + "," + sizeTxtBox.Text + "m," + bedTxtBox.Text + "," + sightTxtBox.Text + "," + wifi + "," + ",$" + priceTxtBox.Text + "," + AdditionalInformationBox.Text);
                    string roomDisplay = ("Room ID: " + count + "00" + "\n" + "Room Size: " + sizeTxtBox.Text + "\n" + "Bed Size: " + bedTxtBox.Text + "\n" + "Sight: " + sightTxtBox.Text + "\n" + "Features: " + wifi + "\n" + "Price: $" + priceTxtBox.Text + "\n" + "Additional Info: " + AdditionalInformationBox.Text + "\n");
                    Room rooms = new Room(count + "00", sizeTxtBox.Text, bedTxtBox.Text, sightTxtBox.Text, wifi + ",", priceTxtBox.Text, AdditionalInformationBox.Text);
                    MessageBox.Show("Room has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.WriteAllText("Room " + (count + "00") + ".txt", roomInfo + "\n");
                    File.AppendAllText("roomDisplay.txt", roomDisplay + "\n");
                    Close();
                }

                else if (tvCheckBox.Checked)
                {
                    string count = ((File.ReadLines("rooms.txt").Count()) + 1).ToString();
                    string roomInfo = (count + "00" + "," + sizeTxtBox.Text + "m," + bedTxtBox.Text + "," + sightTxtBox.Text + "," + tv + "," + ",$" + priceTxtBox.Text + "," + AdditionalInformationBox.Text);
                    string roomDisplay = ("Room ID: " + count + "00" + "\n" + "Room Size: " + sizeTxtBox.Text + "\n" + "Bed Size: " + bedTxtBox.Text + "\n" + "Sight: " + sightTxtBox.Text + "\n" + "Features: " + tv + "\n" + "Price: $" + priceTxtBox.Text + "\n" + "Additional Info: " + AdditionalInformationBox.Text + "\n");
                    Room rooms = new Room(count + "00", sizeTxtBox.Text, bedTxtBox.Text, sightTxtBox.Text, tv + ",", priceTxtBox.Text, AdditionalInformationBox.Text);
                    MessageBox.Show("Room " + count + "00 " + "has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.WriteAllText("Room " + (count + "00") + ".txt", roomInfo + "\n");
                    File.AppendAllText("roomDisplay.txt", roomDisplay + "\n");
                    Close();
                }

                else if (!(wifiCheckBox.Checked) && !(tvCheckBox.Checked)) 
                {
                    string count = ((File.ReadLines("rooms.txt").Count()) + 1).ToString();
                    string roomInfo = (count + "00" + "," + sizeTxtBox.Text + "," + bedTxtBox.Text + "," + sightTxtBox.Text + ",N/A,,$" + priceTxtBox.Text + "," + AdditionalInformationBox.Text);
                    string roomDisplay = ("Room ID: " + count + "00" + "\n" + "Room Size: " + sizeTxtBox.Text + "\n" + "Bed Size: " + bedTxtBox.Text + "\n" + "Sight: " + sightTxtBox.Text + "\n" + "Features: " + "N/A" + "\n" + "Price: $" + priceTxtBox.Text + "\n" + "Additional Info: " + AdditionalInformationBox.Text + "\n");
                    Room rooms = new Room(count + "00", sizeTxtBox.Text, bedTxtBox.Text, sightTxtBox.Text, ",", priceTxtBox.Text, AdditionalInformationBox.Text);
                    MessageBox.Show("Room has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);;
                    File.WriteAllText("Room " + (count + "00") + ".txt", roomInfo + "\n");
                    File.AppendAllText("roomDisplay.txt", roomDisplay + "\n");
                    Close();
                }
            }
        }
        public static int makeRoomID()
        {
            for (int i = 1; i < 9999999; i++) //generates code beginning from 10000
            {
                if (System.IO.File.Exists(i + ".txt")) //checks if a code with value 'i' exists in the name of a .txt file. for e.g., it checks if 10000.txt exists. if so, it does nothing. if not, it generates a code.
                {
                    i++;
                }
                else
                {
                    return i++;
                }
            }
            return 0;
        }


    }
}
