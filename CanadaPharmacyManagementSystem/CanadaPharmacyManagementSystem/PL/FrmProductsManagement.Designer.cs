namespace CanadaPharmacyManagementSystem.PL
{
    partial class FrmProductsManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteSelectedProduct = new System.Windows.Forms.Button();
            this.btnShowProductImage = new System.Windows.Forms.Button();
            this.btnPrintAllProducts = new System.Windows.Forms.Button();
            this.btnPrintSelectedProduct = new System.Windows.Forms.Button();
            this.btnSaveProductsInExcel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShowExpiredDates = new System.Windows.Forms.Button();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProducts);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1029, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowExpiredDates);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnSaveProductsInExcel);
            this.groupBox2.Controls.Add(this.btnPrintSelectedProduct);
            this.groupBox2.Controls.Add(this.btnPrintAllProducts);
            this.groupBox2.Controls.Add(this.btnShowProductImage);
            this.groupBox2.Controls.Add(this.btnDeleteSelectedProduct);
            this.groupBox2.Controls.Add(this.btnEditProduct);
            this.groupBox2.Controls.Add(this.btnAddProduct);
            this.groupBox2.Controls.Add(this.btnGetAll);
            this.groupBox2.Location = new System.Drawing.Point(12, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1026, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(338, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(453, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(3, 19);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1023, 302);
            this.dgvProducts.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Product Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Active Material";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Scientific Name";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Purchase Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Sell Price";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Quantity";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Barcode";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(262, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(114, 22);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(151, 36);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "Show All Products";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(276, 22);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(151, 36);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(438, 22);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(151, 36);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.Text = "Edit Selected Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedProduct
            // 
            this.btnDeleteSelectedProduct.Location = new System.Drawing.Point(600, 22);
            this.btnDeleteSelectedProduct.Name = "btnDeleteSelectedProduct";
            this.btnDeleteSelectedProduct.Size = new System.Drawing.Size(151, 36);
            this.btnDeleteSelectedProduct.TabIndex = 3;
            this.btnDeleteSelectedProduct.Text = "Delete Selected Product";
            this.btnDeleteSelectedProduct.UseVisualStyleBackColor = true;
            // 
            // btnShowProductImage
            // 
            this.btnShowProductImage.Location = new System.Drawing.Point(762, 22);
            this.btnShowProductImage.Name = "btnShowProductImage";
            this.btnShowProductImage.Size = new System.Drawing.Size(151, 36);
            this.btnShowProductImage.TabIndex = 4;
            this.btnShowProductImage.Text = "Show Product Image";
            this.btnShowProductImage.UseVisualStyleBackColor = true;
            // 
            // btnPrintAllProducts
            // 
            this.btnPrintAllProducts.Location = new System.Drawing.Point(114, 79);
            this.btnPrintAllProducts.Name = "btnPrintAllProducts";
            this.btnPrintAllProducts.Size = new System.Drawing.Size(151, 36);
            this.btnPrintAllProducts.TabIndex = 5;
            this.btnPrintAllProducts.Text = "Print All Products";
            this.btnPrintAllProducts.UseVisualStyleBackColor = true;
            // 
            // btnPrintSelectedProduct
            // 
            this.btnPrintSelectedProduct.Location = new System.Drawing.Point(276, 79);
            this.btnPrintSelectedProduct.Name = "btnPrintSelectedProduct";
            this.btnPrintSelectedProduct.Size = new System.Drawing.Size(151, 36);
            this.btnPrintSelectedProduct.TabIndex = 6;
            this.btnPrintSelectedProduct.Text = "Print Selected Product";
            this.btnPrintSelectedProduct.UseVisualStyleBackColor = true;
            // 
            // btnSaveProductsInExcel
            // 
            this.btnSaveProductsInExcel.Location = new System.Drawing.Point(438, 79);
            this.btnSaveProductsInExcel.Name = "btnSaveProductsInExcel";
            this.btnSaveProductsInExcel.Size = new System.Drawing.Size(151, 36);
            this.btnSaveProductsInExcel.TabIndex = 7;
            this.btnSaveProductsInExcel.Text = "Save products in Excel";
            this.btnSaveProductsInExcel.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(762, 79);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 36);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowExpiredDates
            // 
            this.btnShowExpiredDates.Location = new System.Drawing.Point(600, 79);
            this.btnShowExpiredDates.Name = "btnShowExpiredDates";
            this.btnShowExpiredDates.Size = new System.Drawing.Size(151, 36);
            this.btnShowExpiredDates.TabIndex = 9;
            this.btnShowExpiredDates.Text = "Show ExpiredDates";
            this.btnShowExpiredDates.UseVisualStyleBackColor = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Description";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // FrmProductsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveProductsInExcel;
        private System.Windows.Forms.Button btnPrintSelectedProduct;
        private System.Windows.Forms.Button btnPrintAllProducts;
        private System.Windows.Forms.Button btnShowProductImage;
        private System.Windows.Forms.Button btnDeleteSelectedProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowExpiredDates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}