namespace CanadaPharmacyManagementSystem.PL
{
    partial class FrmAddActiveMaterial
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtActiveMaterialName = new System.Windows.Forms.TextBox();
            this.txtActiveMaterialDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(116, 264);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(336, 264);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 46);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtActiveMaterialName
            // 
            this.txtActiveMaterialName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActiveMaterialName.Location = new System.Drawing.Point(195, 92);
            this.txtActiveMaterialName.Margin = new System.Windows.Forms.Padding(4);
            this.txtActiveMaterialName.Name = "txtActiveMaterialName";
            this.txtActiveMaterialName.Size = new System.Drawing.Size(303, 24);
            this.txtActiveMaterialName.TabIndex = 2;
            // 
            // txtActiveMaterialDescription
            // 
            this.txtActiveMaterialDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActiveMaterialDescription.Location = new System.Drawing.Point(195, 143);
            this.txtActiveMaterialDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtActiveMaterialDescription.Multiline = true;
            this.txtActiveMaterialDescription.Name = "txtActiveMaterialDescription";
            this.txtActiveMaterialDescription.Size = new System.Drawing.Size(303, 92);
            this.txtActiveMaterialDescription.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Active Material Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Active Material Description:";
            // 
            // FrmAddActiveMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 370);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtActiveMaterialDescription);
            this.Controls.Add(this.txtActiveMaterialName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddActiveMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddActiveMaterial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtActiveMaterialName;
        private System.Windows.Forms.TextBox txtActiveMaterialDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}