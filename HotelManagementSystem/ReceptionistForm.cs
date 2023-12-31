﻿using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class ReceptionistForm : Form
    {
        //this is a data table that will be used to display custoemr infomration.
        private DataTable customerDataTable = new DataTable();
        private HotelMain hotelMain;
        public ReceptionistForm(HotelMain hotelMain)
        {
            InitializeComponent();
            this.hotelMain = hotelMain;
            
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm(hotelMain);
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
        }

        private void btnBook_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomersToDataTable()
        {
            AddColumns();
            AddCustomerDataFromDB();
            RefreshCustomerList();
            
        }

        private void RefreshCustomerList()
        {
            lbCustomers.DataSource = customerDataTable;
            lbCustomers.DisplayMember = "name";
            //lbCustomers.ValueMember = "id";
        }
        private void AddColumns()
        {
            DataColumn custIdCol = new DataColumn();
            custIdCol.ColumnName = "id";
            DataColumn custNameCol = new DataColumn();
            custNameCol.ColumnName = "name";

            //adds the column headers
            customerDataTable.Columns.Add(custIdCol);
            customerDataTable.Columns.Add(custNameCol);
            
        }

        private void AddCustomerDataFromDB()
        {
            foreach(Customer customer in hotelMain.Customers)
            {
                var row = customerDataTable.NewRow();
                row["id"] = customer.Id;
                row["name"] = customer.FirstName + " " + customer.LastName;
                customerDataTable.Rows.Add(row);
            }

        }
    }
}
