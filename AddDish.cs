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
    public partial class AddDish : Form
    {
        public AddDish()
        {
            InitializeComponent();
        }



        public Boolean isFormComplete()
        {
            if (String.IsNullOrEmpty(DishTxtBox.Text))
            {
                MessageBox.Show("Dish cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (validDish(DishTxtBox.Text))
            {
                MessageBox.Show("Dish is already available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            
            else if (String.IsNullOrEmpty(PriceTxtBox.Text))
            {
                MessageBox.Show("Please insert a price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (!(PriceTxtBox.Text).All(char.IsDigit))
            {
                MessageBox.Show("Please insert a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            } 
            else if (String.IsNullOrEmpty(CalorieTxtBox.Text))
            {
                MessageBox.Show("Please insert a calorie count.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (String.IsNullOrEmpty(DishType.Text))
            {
                MessageBox.Show("Please select a meal type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if (String.IsNullOrEmpty(AllergenTxtBox.Text))
            {
                MessageBox.Show("Please insert any allergens", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else
            {
                return true;
            }

        }

        private void DishType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DishTxtBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void PriceTxtBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void AdditionalInfoBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
            
        private void SubmitBtn_Click_1(object sender, EventArgs e)
        {
            if (isFormComplete() == true)
            {
                string dishInfo = (DishTxtBox.Text + ",$" + PriceTxtBox.Text + "," + CalorieTxtBox.Text + "kJ," + DishType.Text + "," + AllergenTxtBox.Text + "," + AdditionalInfoBox.Text);
                string dishDisplay = ("Dish: " + DishTxtBox.Text + "\nPrice: $" + PriceTxtBox.Text + "\nCalories (kJ): " + CalorieTxtBox.Text + "kJ\nMeal Type: " + DishType.Text + "\nAllergens: " + AllergenTxtBox.Text + "\nAdditional Information: " + AdditionalInfoBox.Text + "\n\n");
                Dish dishes = new Dish(DishTxtBox.Text, PriceTxtBox.Text, CalorieTxtBox.Text, DishType.Text, AllergenTxtBox.Text, AdditionalInfoBox.Text);
                MessageBox.Show("Dish has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.AppendAllText("dish.txt", dishInfo + "\n");
                File.AppendAllText(DishTxtBox.Text + ".txt", dishDisplay);
                Close();
            }
        }

        public Boolean validDish(string dish)
        {
            string[] accInfo = File.ReadAllLines("dish.txt");
            for (int i = 0; i < File.ReadLines("dish.txt").Count(); i++)
            {
                string[] temp = accInfo[i].Split(',');
                Console.WriteLine(temp[0]);
                if (temp[0] == dish)
                {
                    return true;
                }
                else
                {

                }
            }
            return false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AllergenTxtBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
