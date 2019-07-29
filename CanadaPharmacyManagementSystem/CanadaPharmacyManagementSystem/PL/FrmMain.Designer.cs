namespace CanadaPharmacyManagementSystem.PL
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.msLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msBackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.msRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msServerConfigurations = new System.Windows.Forms.ToolStripMenuItem();
            this.msProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.productManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.msActiveMaterialManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.msAddActiveMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.scientificNamesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScientificNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.customersManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ordersManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.requestsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.usersManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile,
            this.msProducts,
            this.msCustomers,
            this.msSuppliers,
            this.msUsers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msFile
            // 
            this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msLogin,
            this.msLogout,
            this.toolStripSeparator1,
            this.msBackUp,
            this.msRestore,
            this.toolStripSeparator2,
            this.msServerConfigurations});
            this.msFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msFile.ForeColor = System.Drawing.Color.Black;
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(43, 23);
            this.msFile.Text = "File";
            this.msFile.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // msLogin
            // 
            this.msLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msLogin.ForeColor = System.Drawing.Color.Black;
            this.msLogin.Name = "msLogin";
            this.msLogin.Size = new System.Drawing.Size(203, 24);
            this.msLogin.Text = "Login";
            this.msLogin.Click += new System.EventHandler(this.msLogin_Click);
            // 
            // msLogout
            // 
            this.msLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msLogout.ForeColor = System.Drawing.Color.Black;
            this.msLogout.Name = "msLogout";
            this.msLogout.Size = new System.Drawing.Size(203, 24);
            this.msLogout.Text = "Log out";
            this.msLogout.Click += new System.EventHandler(this.msLogout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // msBackUp
            // 
            this.msBackUp.Enabled = false;
            this.msBackUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msBackUp.ForeColor = System.Drawing.Color.Black;
            this.msBackUp.Name = "msBackUp";
            this.msBackUp.Size = new System.Drawing.Size(203, 24);
            this.msBackUp.Text = "Backup Database";
            // 
            // msRestore
            // 
            this.msRestore.Enabled = false;
            this.msRestore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msRestore.ForeColor = System.Drawing.Color.Black;
            this.msRestore.Name = "msRestore";
            this.msRestore.Size = new System.Drawing.Size(203, 24);
            this.msRestore.Text = "Restore DataBase";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // msServerConfigurations
            // 
            this.msServerConfigurations.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msServerConfigurations.ForeColor = System.Drawing.Color.Black;
            this.msServerConfigurations.Name = "msServerConfigurations";
            this.msServerConfigurations.Size = new System.Drawing.Size(203, 24);
            this.msServerConfigurations.Text = "Server Configuration";
            // 
            // msProducts
            // 
            this.msProducts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productManagementToolStripMenuItem,
            this.addProductToolStripMenuItem,
            this.toolStripSeparator3,
            this.categoriesManagementToolStripMenuItem,
            this.addCategoryToolStripMenuItem,
            this.toolStripSeparator6,
            this.msActiveMaterialManagement,
            this.msAddActiveMaterial,
            this.toolStripSeparator7,
            this.scientificNamesManagementToolStripMenuItem,
            this.addScientificNameToolStripMenuItem});
            this.msProducts.Enabled = false;
            this.msProducts.Name = "msProducts";
            this.msProducts.Size = new System.Drawing.Size(75, 23);
            this.msProducts.Text = "Products";
            // 
            // productManagementToolStripMenuItem
            // 
            this.productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            this.productManagementToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.productManagementToolStripMenuItem.Text = "Product Management";
            this.productManagementToolStripMenuItem.Click += new System.EventHandler(this.productManagementToolStripMenuItem_Click);
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(258, 6);
            // 
            // categoriesManagementToolStripMenuItem
            // 
            this.categoriesManagementToolStripMenuItem.Name = "categoriesManagementToolStripMenuItem";
            this.categoriesManagementToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.categoriesManagementToolStripMenuItem.Text = "Categories Management";
            this.categoriesManagementToolStripMenuItem.Click += new System.EventHandler(this.categoriesManagementToolStripMenuItem_Click);
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.addCategoryToolStripMenuItem.Text = "Add Category";
            this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.addCategoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(258, 6);
            // 
            // msActiveMaterialManagement
            // 
            this.msActiveMaterialManagement.Name = "msActiveMaterialManagement";
            this.msActiveMaterialManagement.Size = new System.Drawing.Size(261, 24);
            this.msActiveMaterialManagement.Text = "Active Materials Management";
            this.msActiveMaterialManagement.Click += new System.EventHandler(this.activeMaterialsManagementToolStripMenuItem_Click);
            // 
            // msAddActiveMaterial
            // 
            this.msAddActiveMaterial.Name = "msAddActiveMaterial";
            this.msAddActiveMaterial.Size = new System.Drawing.Size(261, 24);
            this.msAddActiveMaterial.Text = "Add Active Material";
            this.msAddActiveMaterial.Click += new System.EventHandler(this.msAddActiveMaterial_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(258, 6);
            // 
            // scientificNamesManagementToolStripMenuItem
            // 
            this.scientificNamesManagementToolStripMenuItem.Name = "scientificNamesManagementToolStripMenuItem";
            this.scientificNamesManagementToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.scientificNamesManagementToolStripMenuItem.Text = "Scientific Names Management";
            this.scientificNamesManagementToolStripMenuItem.Click += new System.EventHandler(this.scientificNamesManagementToolStripMenuItem_Click);
            // 
            // addScientificNameToolStripMenuItem
            // 
            this.addScientificNameToolStripMenuItem.Name = "addScientificNameToolStripMenuItem";
            this.addScientificNameToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.addScientificNameToolStripMenuItem.Text = "Add Scientific Name ";
            this.addScientificNameToolStripMenuItem.Click += new System.EventHandler(this.addScientificNameToolStripMenuItem_Click);
            // 
            // msCustomers
            // 
            this.msCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersManagementToolStripMenuItem,
            this.addCustomerToolStripMenuItem,
            this.toolStripSeparator4,
            this.ordersManagementToolStripMenuItem,
            this.addOrderToolStripMenuItem});
            this.msCustomers.Enabled = false;
            this.msCustomers.Name = "msCustomers";
            this.msCustomers.Size = new System.Drawing.Size(86, 23);
            this.msCustomers.Text = "Customers";
            // 
            // customersManagementToolStripMenuItem
            // 
            this.customersManagementToolStripMenuItem.Name = "customersManagementToolStripMenuItem";
            this.customersManagementToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.customersManagementToolStripMenuItem.Text = "Customers Management";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(222, 6);
            // 
            // ordersManagementToolStripMenuItem
            // 
            this.ordersManagementToolStripMenuItem.Name = "ordersManagementToolStripMenuItem";
            this.ordersManagementToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.ordersManagementToolStripMenuItem.Text = "Orders Management";
            // 
            // addOrderToolStripMenuItem
            // 
            this.addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
            this.addOrderToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.addOrderToolStripMenuItem.Text = "Add Order";
            // 
            // msSuppliers
            // 
            this.msSuppliers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suppliersManagementToolStripMenuItem,
            this.addSupplierToolStripMenuItem,
            this.toolStripSeparator5,
            this.requestsManagementToolStripMenuItem,
            this.addRequestToolStripMenuItem});
            this.msSuppliers.Enabled = false;
            this.msSuppliers.Name = "msSuppliers";
            this.msSuppliers.Size = new System.Drawing.Size(77, 23);
            this.msSuppliers.Text = "Suppliers";
            // 
            // suppliersManagementToolStripMenuItem
            // 
            this.suppliersManagementToolStripMenuItem.Name = "suppliersManagementToolStripMenuItem";
            this.suppliersManagementToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.suppliersManagementToolStripMenuItem.Text = "Suppliers Management";
            // 
            // addSupplierToolStripMenuItem
            // 
            this.addSupplierToolStripMenuItem.Name = "addSupplierToolStripMenuItem";
            this.addSupplierToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.addSupplierToolStripMenuItem.Text = "Add Supplier";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(213, 6);
            // 
            // requestsManagementToolStripMenuItem
            // 
            this.requestsManagementToolStripMenuItem.Name = "requestsManagementToolStripMenuItem";
            this.requestsManagementToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.requestsManagementToolStripMenuItem.Text = "Requests Management";
            // 
            // addRequestToolStripMenuItem
            // 
            this.addRequestToolStripMenuItem.Name = "addRequestToolStripMenuItem";
            this.addRequestToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.addRequestToolStripMenuItem.Text = "Add Request";
            // 
            // msUsers
            // 
            this.msUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersManagementToolStripMenuItem,
            this.addUserToolStripMenuItem});
            this.msUsers.Enabled = false;
            this.msUsers.Name = "msUsers";
            this.msUsers.Size = new System.Drawing.Size(56, 23);
            this.msUsers.Text = "Users";
            // 
            // usersManagementToolStripMenuItem
            // 
            this.usersManagementToolStripMenuItem.Name = "usersManagementToolStripMenuItem";
            this.usersManagementToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.usersManagementToolStripMenuItem.Text = "Users Management";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.addUserToolStripMenuItem.Text = "Add User";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy Management System Project (Demo)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem msLogin;
        private System.Windows.Forms.ToolStripMenuItem msLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem msServerConfigurations;
        private System.Windows.Forms.ToolStripMenuItem productManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem categoriesManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ordersManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem requestsManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem msBackUp;
        public System.Windows.Forms.ToolStripMenuItem msRestore;
        public System.Windows.Forms.ToolStripMenuItem msProducts;
        public System.Windows.Forms.ToolStripMenuItem msCustomers;
        public System.Windows.Forms.ToolStripMenuItem msSuppliers;
        public System.Windows.Forms.ToolStripMenuItem msUsers;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem msActiveMaterialManagement;
        private System.Windows.Forms.ToolStripMenuItem msAddActiveMaterial;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem scientificNamesManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addScientificNameToolStripMenuItem;
    }
}