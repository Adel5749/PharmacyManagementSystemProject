namespace CanadaPharmacyManagementSystem.PL
{
    partial class FrmScientificNamesManagement
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
            this.dgvScientificNames = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScientificName = new System.Windows.Forms.TextBox();
            this.txtScientificID = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrintScientficNames = new System.Windows.Forms.Button();
            this.btnDeleteScientificName = new System.Windows.Forms.Button();
            this.btnEditScientificName = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScientificNames)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvScientificNames
            // 
            this.dgvScientificNames.AllowUserToAddRows = false;
            this.dgvScientificNames.AllowUserToDeleteRows = false;
            this.dgvScientificNames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScientificNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScientificNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvScientificNames.Location = new System.Drawing.Point(3, 22);
            this.dgvScientificNames.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvScientificNames.Name = "dgvScientificNames";
            this.dgvScientificNames.ReadOnly = true;
            this.dgvScientificNames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScientificNames.Size = new System.Drawing.Size(532, 440);
            this.dgvScientificNames.TabIndex = 0;
            this.dgvScientificNames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScientificNames_CellClick);
            this.dgvScientificNames.SelectionChanged += new System.EventHandler(this.dgvScientificNames_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtScientificName);
            this.groupBox2.Controls.Add(this.txtScientificID);
            this.groupBox2.Location = new System.Drawing.Point(28, 85);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(450, 245);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scientific Name Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Scientific Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Scientific ID";
            // 
            // txtScientificName
            // 
            this.txtScientificName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScientificName.Location = new System.Drawing.Point(153, 122);
            this.txtScientificName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtScientificName.Name = "txtScientificName";
            this.txtScientificName.Size = new System.Drawing.Size(239, 24);
            this.txtScientificName.TabIndex = 6;
            // 
            // txtScientificID
            // 
            this.txtScientificID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScientificID.Location = new System.Drawing.Point(153, 62);
            this.txtScientificID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtScientificID.Name = "txtScientificID";
            this.txtScientificID.ReadOnly = true;
            this.txtScientificID.Size = new System.Drawing.Size(239, 24);
            this.txtScientificID.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(379, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(392, 24);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrintScientficNames);
            this.groupBox3.Controls.Add(this.btnDeleteScientificName);
            this.groupBox3.Controls.Add(this.btnEditScientificName);
            this.groupBox3.Controls.Add(this.btnGetAll);
            this.groupBox3.Location = new System.Drawing.Point(28, 337);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Size = new System.Drawing.Size(450, 215);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operations";
            // 
            // btnPrintScientficNames
            // 
            this.btnPrintScientficNames.Location = new System.Drawing.Point(247, 118);
            this.btnPrintScientficNames.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPrintScientficNames.Name = "btnPrintScientficNames";
            this.btnPrintScientficNames.Size = new System.Drawing.Size(182, 43);
            this.btnPrintScientficNames.TabIndex = 3;
            this.btnPrintScientficNames.Text = "Print All Scintfic Names";
            this.btnPrintScientficNames.UseVisualStyleBackColor = true;
            // 
            // btnDeleteScientificName
            // 
            this.btnDeleteScientificName.Location = new System.Drawing.Point(40, 118);
            this.btnDeleteScientificName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDeleteScientificName.Name = "btnDeleteScientificName";
            this.btnDeleteScientificName.Size = new System.Drawing.Size(201, 43);
            this.btnDeleteScientificName.TabIndex = 2;
            this.btnDeleteScientificName.Text = "Delete Selected Scintfic Name";
            this.btnDeleteScientificName.UseVisualStyleBackColor = true;
            this.btnDeleteScientificName.Click += new System.EventHandler(this.btnDeleteScientificName_Click);
            // 
            // btnEditScientificName
            // 
            this.btnEditScientificName.Location = new System.Drawing.Point(247, 53);
            this.btnEditScientificName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEditScientificName.Name = "btnEditScientificName";
            this.btnEditScientificName.Size = new System.Drawing.Size(182, 43);
            this.btnEditScientificName.TabIndex = 1;
            this.btnEditScientificName.Text = "Edit Selected Scintfic Name";
            this.btnEditScientificName.UseVisualStyleBackColor = true;
            this.btnEditScientificName.Click += new System.EventHandler(this.btnEditScientificName_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(40, 53);
            this.btnGetAll.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(201, 43);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "Get All Scientific Names";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvScientificNames);
            this.groupBox1.Location = new System.Drawing.Point(499, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(538, 467);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ScientificNames";
            // 
            // FrmScientificNamesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmScientificNamesManagement";
            this.Text = "FrmScientificNamesManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvScientificNames)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScientificNames;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScientificName;
        private System.Windows.Forms.TextBox txtScientificID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPrintScientficNames;
        private System.Windows.Forms.Button btnDeleteScientificName;
        private System.Windows.Forms.Button btnEditScientificName;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}