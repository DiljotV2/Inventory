﻿namespace InventorySystem
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.StocksButton = new System.Windows.Forms.Button();
            this.VendorsButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddNewCustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.test_DatabaseDataSet1 = new InventorySystem.Test_DatabaseDataSet1();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new InventorySystem.Test_DatabaseDataSet1TableAdapters.CustomersTableAdapter();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.DashboardButton);
            this.flowLayoutPanel1.Controls.Add(this.ProductsButton);
            this.flowLayoutPanel1.Controls.Add(this.StocksButton);
            this.flowLayoutPanel1.Controls.Add(this.VendorsButton);
            this.flowLayoutPanel1.Controls.Add(this.CustomersButton);
            this.flowLayoutPanel1.Controls.Add(this.LogoutButton);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 450);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // DashboardButton
            // 
            this.DashboardButton.BackColor = System.Drawing.Color.White;
            this.DashboardButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DashboardButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.Image = global::InventorySystem.Properties.Resources.DashboardIcon;
            this.DashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButton.Location = new System.Drawing.Point(3, 3);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(206, 67);
            this.DashboardButton.TabIndex = 0;
            this.DashboardButton.Text = "DASHBOARD";
            this.DashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DashboardButton.UseVisualStyleBackColor = false;
            this.DashboardButton.Click += new System.EventHandler(this.DashBoardButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.BackColor = System.Drawing.Color.White;
            this.ProductsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ProductsButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsButton.Image = global::InventorySystem.Properties.Resources.ProductsIcon;
            this.ProductsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductsButton.Location = new System.Drawing.Point(3, 76);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(206, 67);
            this.ProductsButton.TabIndex = 1;
            this.ProductsButton.Text = "           PRODUCTS";
            this.ProductsButton.UseVisualStyleBackColor = false;
            // 
            // StocksButton
            // 
            this.StocksButton.BackColor = System.Drawing.Color.White;
            this.StocksButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StocksButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StocksButton.Image = global::InventorySystem.Properties.Resources.StockIcon;
            this.StocksButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StocksButton.Location = new System.Drawing.Point(3, 149);
            this.StocksButton.Name = "StocksButton";
            this.StocksButton.Size = new System.Drawing.Size(206, 67);
            this.StocksButton.TabIndex = 2;
            this.StocksButton.Text = " STOCKS";
            this.StocksButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StocksButton.UseVisualStyleBackColor = false;
            this.StocksButton.Click += new System.EventHandler(this.StocksButton_Click);
            // 
            // VendorsButton
            // 
            this.VendorsButton.BackColor = System.Drawing.Color.White;
            this.VendorsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.VendorsButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorsButton.Image = global::InventorySystem.Properties.Resources.VendorsIcon;
            this.VendorsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VendorsButton.Location = new System.Drawing.Point(3, 222);
            this.VendorsButton.Name = "VendorsButton";
            this.VendorsButton.Size = new System.Drawing.Size(206, 67);
            this.VendorsButton.TabIndex = 3;
            this.VendorsButton.Text = "        VENDORS";
            this.VendorsButton.UseVisualStyleBackColor = false;
            this.VendorsButton.Click += new System.EventHandler(this.VendorsButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.BackColor = System.Drawing.Color.White;
            this.CustomersButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CustomersButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersButton.Image = global::InventorySystem.Properties.Resources.CustomersIcon;
            this.CustomersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomersButton.Location = new System.Drawing.Point(3, 295);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(206, 67);
            this.CustomersButton.TabIndex = 4;
            this.CustomersButton.Text = "CUSTOMERS";
            this.CustomersButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CustomersButton.UseVisualStyleBackColor = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.White;
            this.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogoutButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Image = global::InventorySystem.Properties.Resources.LogOutIcon;
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(3, 368);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(206, 69);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "      LOGOUT";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 64);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventorySystem.Properties.Resources.Admin_Img;
            this.pictureBox1.Location = new System.Drawing.Point(856, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(786, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // AddNewCustomer
            // 
            this.AddNewCustomer.Location = new System.Drawing.Point(763, 467);
            this.AddNewCustomer.Name = "AddNewCustomer";
            this.AddNewCustomer.Size = new System.Drawing.Size(137, 43);
            this.AddNewCustomer.TabIndex = 3;
            this.AddNewCustomer.Text = "Add New Customer";
            this.AddNewCustomer.UseVisualStyleBackColor = true;
            this.AddNewCustomer.Click += new System.EventHandler(this.AddNewCustomer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(321, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 348);
            this.dataGridView1.TabIndex = 6;
            // 
            // test_DatabaseDataSet1
            // 
            this.test_DatabaseDataSet1.DataSetName = "Test_DatabaseDataSet1";
            this.test_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.test_DatabaseDataSet1;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 524);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddNewCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Customers";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button StocksButton;
        private System.Windows.Forms.Button VendorsButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Test_DatabaseDataSet1 test_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Test_DatabaseDataSet1TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}