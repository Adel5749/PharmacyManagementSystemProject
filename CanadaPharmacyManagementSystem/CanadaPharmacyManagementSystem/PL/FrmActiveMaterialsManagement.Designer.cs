namespace CanadaPharmacyManagementSystem.PL
{
    partial class FrmActiveMaterialsManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtActiveMaterialDescription = new System.Windows.Forms.TextBox();
            this.txtActiveMaterialName = new System.Windows.Forms.TextBox();
            this.txtActiveMaterialID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrintAllMaterials = new System.Windows.Forms.Button();
            this.btnDeleteSelectedMaterial = new System.Windows.Forms.Button();
            this.btnEditMaterialData = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvActiveMaterials = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtActiveMaterialDescription);
            this.groupBox1.Controls.Add(this.txtActiveMaterialName);
            this.groupBox1.Controls.Add(this.txtActiveMaterialID);
            this.groupBox1.Location = new System.Drawing.Point(18, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Active Material Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Active Material ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Acitve Material Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Active Material Desc:";
            // 
            // txtActiveMaterialDescription
            // 
            this.txtActiveMaterialDescription.Location = new System.Drawing.Point(150, 109);
            this.txtActiveMaterialDescription.Multiline = true;
            this.txtActiveMaterialDescription.Name = "txtActiveMaterialDescription";
            this.txtActiveMaterialDescription.Size = new System.Drawing.Size(229, 101);
            this.txtActiveMaterialDescription.TabIndex = 6;
            // 
            // txtActiveMaterialName
            // 
            this.txtActiveMaterialName.Location = new System.Drawing.Point(150, 67);
            this.txtActiveMaterialName.Name = "txtActiveMaterialName";
            this.txtActiveMaterialName.Size = new System.Drawing.Size(229, 26);
            this.txtActiveMaterialName.TabIndex = 5;
            // 
            // txtActiveMaterialID
            // 
            this.txtActiveMaterialID.Location = new System.Drawing.Point(150, 25);
            this.txtActiveMaterialID.Name = "txtActiveMaterialID";
            this.txtActiveMaterialID.ReadOnly = true;
            this.txtActiveMaterialID.Size = new System.Drawing.Size(229, 26);
            this.txtActiveMaterialID.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrintAllMaterials);
            this.groupBox2.Controls.Add(this.btnDeleteSelectedMaterial);
            this.groupBox2.Controls.Add(this.btnEditMaterialData);
            this.groupBox2.Controls.Add(this.btnGetAll);
            this.groupBox2.Location = new System.Drawing.Point(12, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // btnPrintAllMaterials
            // 
            this.btnPrintAllMaterials.Location = new System.Drawing.Point(218, 98);
            this.btnPrintAllMaterials.Name = "btnPrintAllMaterials";
            this.btnPrintAllMaterials.Size = new System.Drawing.Size(167, 32);
            this.btnPrintAllMaterials.TabIndex = 3;
            this.btnPrintAllMaterials.Text = "Print All Materials";
            this.btnPrintAllMaterials.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedMaterial
            // 
            this.btnDeleteSelectedMaterial.Location = new System.Drawing.Point(24, 98);
            this.btnDeleteSelectedMaterial.Name = "btnDeleteSelectedMaterial";
            this.btnDeleteSelectedMaterial.Size = new System.Drawing.Size(167, 32);
            this.btnDeleteSelectedMaterial.TabIndex = 2;
            this.btnDeleteSelectedMaterial.Text = "Delete Selected Material";
            this.btnDeleteSelectedMaterial.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedMaterial.Click += new System.EventHandler(this.btnDeleteSelectedMaterial_Click);
            // 
            // btnEditMaterialData
            // 
            this.btnEditMaterialData.Location = new System.Drawing.Point(218, 40);
            this.btnEditMaterialData.Name = "btnEditMaterialData";
            this.btnEditMaterialData.Size = new System.Drawing.Size(167, 32);
            this.btnEditMaterialData.TabIndex = 1;
            this.btnEditMaterialData.Text = "Edit Selected Material";
            this.btnEditMaterialData.UseVisualStyleBackColor = true;
            this.btnEditMaterialData.Click += new System.EventHandler(this.btnEditMaterial_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(24, 40);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(167, 32);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "Show All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvActiveMaterials);
            this.groupBox3.Location = new System.Drawing.Point(443, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 396);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Active Materials List";
            // 
            // dgvActiveMaterials
            // 
            this.dgvActiveMaterials.AllowUserToAddRows = false;
            this.dgvActiveMaterials.AllowUserToDeleteRows = false;
            this.dgvActiveMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActiveMaterials.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveMaterials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActiveMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActiveMaterials.Location = new System.Drawing.Point(3, 22);
            this.dgvActiveMaterials.Name = "dgvActiveMaterials";
            this.dgvActiveMaterials.ReadOnly = true;
            this.dgvActiveMaterials.RowHeadersVisible = false;
            this.dgvActiveMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActiveMaterials.Size = new System.Drawing.Size(445, 371);
            this.dgvActiveMaterials.TabIndex = 0;
            this.dgvActiveMaterials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveMaterials_CellClick);
            this.dgvActiveMaterials.SelectionChanged += new System.EventHandler(this.dgvActiveMaterials_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(281, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(408, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // FrmActiveMaterialsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 491);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmActiveMaterialsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Active Materials Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvActiveMaterials;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrintAllMaterials;
        private System.Windows.Forms.Button btnDeleteSelectedMaterial;
        private System.Windows.Forms.Button btnEditMaterialData;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtActiveMaterialDescription;
        private System.Windows.Forms.TextBox txtActiveMaterialName;
        private System.Windows.Forms.TextBox txtActiveMaterialID;
    }
}