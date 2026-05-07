namespace BankSystem_UI.CustomersManagement
{
    partial class frmManagerCustomers
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.cmsCustomer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.findPersonByCustomerIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbIsBlocked = new System.Windows.Forms.ComboBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.cmsCustomer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToOrderColumns = true;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.ContextMenuStrip = this.cmsCustomer;
            this.dgvCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCustomers.Location = new System.Drawing.Point(9, 229);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(933, 371);
            this.dgvCustomers.TabIndex = 7;
            // 
            // cmsCustomer
            // 
            this.cmsCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.findPersonByCustomerIDToolStripMenuItem});
            this.cmsCustomer.Name = "contextMenuStrip1";
            this.cmsCustomer.Size = new System.Drawing.Size(235, 206);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.PersonDetails_321;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.showDetailsToolStripMenuItem.Text = "&Show Person Info";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::BankSystem_UI.Properties.Resources.Add_New_User_321;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(234, 38);
            this.toolStripMenuItem1.Text = "Add &New Customer";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Edit_User_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // findPersonByCustomerIDToolStripMenuItem
            // 
            this.findPersonByCustomerIDToolStripMenuItem.Name = "findPersonByCustomerIDToolStripMenuItem";
            this.findPersonByCustomerIDToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.findPersonByCustomerIDToolStripMenuItem.Text = "Find Person By CustomerID";
            this.findPersonByCustomerIDToolStripMenuItem.Click += new System.EventHandler(this.findPersonByCustomerIDToolStripMenuItem_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.ForeColor = System.Drawing.Color.Red;
            this.lblRecordsCount.Location = new System.Drawing.Point(99, 616);
            this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(42, 20);
            this.lblRecordsCount.TabIndex = 9;
            this.lblRecordsCount.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 616);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "#Record(s):";
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAddNewCustomer.BackgroundImage = global::BankSystem_UI.Properties.Resources.Custom_Icon_Design_Pretty_Office_3_Add_Male_User_64;
            this.btnAddNewCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(801, 161);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(141, 63);
            this.btnAddNewCustomer.TabIndex = 11;
            this.btnAddNewCustomer.UseVisualStyleBackColor = false;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbIsBlocked);
            this.panel2.Controls.Add(this.cbFilterBy);
            this.panel2.Controls.Add(this.txtFilterValue);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(9, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 63);
            this.panel2.TabIndex = 13;
            // 
            // cbIsBlocked
            // 
            this.cbIsBlocked.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsBlocked.FormattingEnabled = true;
            this.cbIsBlocked.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsBlocked.Location = new System.Drawing.Point(305, 18);
            this.cbIsBlocked.Name = "cbIsBlocked";
            this.cbIsBlocked.Size = new System.Drawing.Size(121, 29);
            this.cbIsBlocked.TabIndex = 107;
            this.cbIsBlocked.Visible = false;
            this.cbIsBlocked.SelectedIndexChanged += new System.EventHandler(this.cbIsBlocked_SelectedIndexChanged);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Customer ID",
            "User ID",
            "Person ID",
            "Full Name",
            "Is Blocked"});
            this.cbFilterBy.Location = new System.Drawing.Point(89, 18);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(210, 29);
            this.cbFilterBy.TabIndex = 106;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(306, 18);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(256, 29);
            this.txtFilterValue.TabIndex = 105;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 104;
            this.label2.Text = "Filter By:";
            // 
            // frmManagerCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(951, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCustomers);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManagerCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmManagerCustomers_Load);
            this.Controls.SetChildIndex(this.dgvCustomers, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblRecordsCount, 0);
            this.Controls.SetChildIndex(this.btnAddNewCustomer, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.cmsCustomer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbIsBlocked;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsCustomer;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem findPersonByCustomerIDToolStripMenuItem;
    }
}