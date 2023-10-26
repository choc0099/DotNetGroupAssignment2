using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Admin : Form
    {
        LoginForm loginform;

        public Admin(LoginForm loginform, string username)
        {
            InitializeComponent();
            this.loginform = loginform;
        }

        private void usernameLbl_Click(object sender, EventArgs e)
        {

        }

        private void usertypeComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchRoom f1 = new SearchRoom();
            f1.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DeleteUser f1 = new DeleteUser();
            f1.Show();
        }

        private void AllCustomerBtn_Click(object sender, EventArgs e)
        {
            AllCustomers f1 = new AllCustomers();
            f1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SearchCustomer f1 = new SearchCustomer();
            f1.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Close();
            loginform.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddDish f1 = new AddDish();
            f1.Show();
        }


        private void button14_Click(object sender, EventArgs e)
        {
            SearchDish f1 = new SearchDish();
            f1.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AllDishes f1 = new AllDishes();
            f1.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AllRooms f1 = new AllRooms();
            f1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddRoom f1 = new AddRoom();
            f1.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DeleteDish f1 = new DeleteDish();
            f1.Show();
        }

        private void viewComplaints_Click(object sender, EventArgs e)
        {
            viewIncidents f1 = new viewIncidents();
            f1.Show();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployee f1 = new AddEmployee();
            f1.Show();
        }
    }
}
