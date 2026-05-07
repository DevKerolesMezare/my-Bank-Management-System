namespace BankSystem_UI.Customer
{
    partial class frmAddUpdateCustomer
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsBlocked = new System.Windows.Forms.CheckBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnPersonInfoNext = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardWithFilter1 = new BankSystem_UI.People.Control.ctrlPersonCardWithFilter();
            this.tpCustomerInfo = new System.Windows.Forms.TabPage();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcCustomerInfo = new System.Windows.Forms.TabControl();
            this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tpCustomerInfo.SuspendLayout();
            this.tcCustomerInfo.SuspendLayout();
            this.cmsUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::BankSystem_UI.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(609, 637);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 120;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Image = global::BankSystem_UI.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(743, 637);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 37);
            this.btnSave.TabIndex = 119;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(281, 77);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(39, 20);
            this.lblCustomerID.TabIndex = 142;
            this.lblCustomerID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 141;
            this.label4.Text = "CustomerID:";
            // 
            // chkIsBlocked
            // 
            this.chkIsBlocked.AutoSize = true;
            this.chkIsBlocked.Checked = true;
            this.chkIsBlocked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsBlocked.Location = new System.Drawing.Point(115, 324);
            this.chkIsBlocked.Name = "chkIsBlocked";
            this.chkIsBlocked.Size = new System.Drawing.Size(102, 24);
            this.chkIsBlocked.TabIndex = 140;
            this.chkIsBlocked.Text = "Is Blocked";
            this.chkIsBlocked.UseVisualStyleBackColor = true;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::BankSystem_UI.Properties.Resources.Number_321;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Location = new System.Drawing.Point(241, 77);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 136;
            this.pictureBox8.TabStop = false;
            // 
            // btnPersonInfoNext
            // 
            this.btnPersonInfoNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonInfoNext.Image = global::BankSystem_UI.Properties.Resources.Next_32;
            this.btnPersonInfoNext.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPersonInfoNext.Location = new System.Drawing.Point(718, 411);
            this.btnPersonInfoNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPersonInfoNext.Name = "btnPersonInfoNext";
            this.btnPersonInfoNext.Size = new System.Drawing.Size(126, 37);
            this.btnPersonInfoNext.TabIndex = 120;
            this.btnPersonInfoNext.Text = "Next";
            this.btnPersonInfoNext.UseVisualStyleBackColor = true;
            this.btnPersonInfoNext.Click += new System.EventHandler(this.btnPersonInfoNext_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPersonInfoNext);
            this.tabPage1.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(855, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(7, 8);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(837, 393);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tpCustomerInfo
            // 
            this.tpCustomerInfo.Controls.Add(this.txtNotes);
            this.tpCustomerInfo.Controls.Add(this.label1);
            this.tpCustomerInfo.Controls.Add(this.lblCustomerID);
            this.tpCustomerInfo.Controls.Add(this.label4);
            this.tpCustomerInfo.Controls.Add(this.chkIsBlocked);
            this.tpCustomerInfo.Controls.Add(this.pictureBox8);
            this.tpCustomerInfo.Location = new System.Drawing.Point(4, 29);
            this.tpCustomerInfo.Name = "tpCustomerInfo";
            this.tpCustomerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomerInfo.Size = new System.Drawing.Size(855, 465);
            this.tpCustomerInfo.TabIndex = 1;
            this.tpCustomerInfo.Text = "CustomerInfo";
            this.tpCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(81, 185);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(632, 103);
            this.txtNotes.TabIndex = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 143;
            this.label1.Text = "Notes";
            // 
            // tcCustomerInfo
            // 
            this.tcCustomerInfo.Controls.Add(this.tabPage1);
            this.tcCustomerInfo.Controls.Add(this.tpCustomerInfo);
            this.tcCustomerInfo.Location = new System.Drawing.Point(6, 122);
            this.tcCustomerInfo.Name = "tcCustomerInfo";
            this.tcCustomerInfo.SelectedIndex = 0;
            this.tcCustomerInfo.Size = new System.Drawing.Size(863, 498);
            this.tcCustomerInfo.TabIndex = 118;
            // 
            // cmsUsers
            // 
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1});
            this.cmsUsers.Name = "contextMenuStrip1";
            this.cmsUsers.Size = new System.Drawing.Size(195, 168);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.PersonDetails_321;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
            this.showDetailsToolStripMenuItem.Text = "&Show Details";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::BankSystem_UI.Properties.Resources.Add_New_User_321;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 38);
            this.toolStripMenuItem1.Text = "Add &New Customer";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Edit_User_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
            this.deleteToolStripMenuItem.Text = "&Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // frmAddUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 683);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcCustomerInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddUpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdate Customer";
            this.Activated += new System.EventHandler(this.frmAddUpdateCustomer_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdateCustomer_Load);
            this.Controls.SetChildIndex(this.tcCustomerInfo, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tpCustomerInfo.ResumeLayout(false);
            this.tpCustomerInfo.PerformLayout();
            this.tcCustomerInfo.ResumeLayout(false);
            this.cmsUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tcCustomerInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPersonInfoNext;
        private People.Control.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.TabPage tpCustomerInfo;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsBlocked;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}