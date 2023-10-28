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
    public partial class ReceptionistForm : Form
    {
        //this is a data table that will be used to display custoemr infomration.
        private DataTable customerDataTable = new DataTable();
        private DataTable roomsDataTable = new DataTable();
        private string username;
        private LoginForm loginForm; //passes login information from the logged in user.
        public ReceptionistForm(LoginForm loginForm, string username)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.username = username;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            NewCustomerForm addCustomerForm = new NewCustomerForm(loginForm);
            DialogResult dResult = addCustomerForm.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                //refreshes the datatable
                this.Refresh();
            }

        }



        private void lbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            //loads the customer data from memory to the table
            AddCustomersToDataTable();
            AddRoomsToDT();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {

        }

        private void AddRoomCols()
        {
            DataColumn roomCodeCol = new DataColumn();
            roomCodeCol.ColumnName = "code";
            DataColumn roomDisplayTextCol = new DataColumn();
            roomDisplayTextCol.ColumnName = "name";
            roomsDataTable.Columns.Add(roomCodeCol);
            roomsDataTable.Columns.Add(roomDisplayTextCol);

        }

        //this is a uhelper function that will add the data from the text file to the room datatable.
        private void FetchRoomsFromTxt()
        {
            foreach(string line in File.ReadAllLines("rooms.txt"))
            {
                string[] splits = line.Split(',');
                var row = roomsDataTable.NewRow();
                row["code"] = splits[0];
                row["name"] = "Room: #" + splits[0]; 
                roomsDataTable.Rows.Add(row);
            }
        }

        private void RefreshRoomsDT()
        {
            lbRooms.DataSource = roomsDataTable;
            lbRooms.DisplayMember = "name";
            lbRooms.ValueMember = "code";
        }

        private void AddCustomersToDataTable()
        {
            AddCustColumns();
            AddCustomerDataFromDB();
            RefreshCustomerList();

        }

        private void AddRoomsToDT()
        {
            AddRoomCols();
            FetchRoomsFromTxt();
            RefreshRoomsDT();
        }

        private void RefreshCustomerList()
        {
            lbCustomers.DataSource = customerDataTable;
            lbCustomers.DisplayMember = "name";
            lbCustomers.ValueMember = "username";
        }
        private void AddCustColumns()
        {
            DataColumn custUserNameCol = new DataColumn();
            custUserNameCol.ColumnName = "username";
            DataColumn custNameCol = new DataColumn();
            custNameCol.ColumnName = "name";

            //adds the column headers
            customerDataTable.Columns.Add(custUserNameCol);
            customerDataTable.Columns.Add(custNameCol);

        }

        private void AddCustomerDataFromDB()
        {
            foreach(string line in File.ReadAllLines("customerDB.txt"))
            {
                string[] splits = line.Split(",");
                var row = customerDataTable.NewRow();
                row["username"] = splits[1]; // customer username
                row["name"] = splits[0];
                customerDataTable.Rows.Add(row);
            }

        }

        private void reportIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncidentReport incidentReportForm = new IncidentReport();
            incidentReportForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
