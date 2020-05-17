﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        public Form RefToLogin { get; set; }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddNewCustomer_Click(object sender, EventArgs e)
        {
            CustomersAdd cta = new CustomersAdd();
            cta.RefToCustomers = this;
            cta.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            RefToLogin.Show();
        }
        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            DashBoard DashBoardLink = new DashBoard();
            DashBoardLink.Show();
            DashBoardLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void StocksButton_Click(object sender, EventArgs e)
        {
            Stocks StockLink = new Stocks();
            StockLink.Show();
            StockLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void VendorsButton_Click(object sender, EventArgs e)
        {
            Vendors VendorLink = new Vendors();
            VendorLink.Show();
            VendorLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.customersDataSet1.Customers);
            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.customersDataSet.Customers);



        }

        private void CustomersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
