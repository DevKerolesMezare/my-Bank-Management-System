namespace BankSystem_UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currenUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankingToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bankingToolStripMenuItem
            // 
            this.bankingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.bankingToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankingToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Pictogrammers_Material_Bank_transfer_64;
            this.bankingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bankingToolStripMenuItem.Name = "bankingToolStripMenuItem";
            this.bankingToolStripMenuItem.Size = new System.Drawing.Size(222, 68);
            this.bankingToolStripMenuItem.Text = "Banking";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Dryicons_Sketchy_Paper_Create_new_folder_24;
            this.accountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(346, 38);
            this.accountToolStripMenuItem.Text = "Accounts Page";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionHistoryToolStripMenuItem});
            this.transactionsToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.transactionsToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Custom_Icon_Design_Flatastic_11_Arrows_24;
            this.transactionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(346, 38);
            this.transactionsToolStripMenuItem.Text = "Transactions Page";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // transactionHistoryToolStripMenuItem
            // 
            this.transactionHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.transactionHistoryToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Custom_Icon_Design_Flatastic_5_Rank_History_24;
            this.transactionHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transactionHistoryToolStripMenuItem.Name = "transactionHistoryToolStripMenuItem";
            this.transactionHistoryToolStripMenuItem.Size = new System.Drawing.Size(279, 30);
            this.transactionHistoryToolStripMenuItem.Text = "Transaction History";
            this.transactionHistoryToolStripMenuItem.Click += new System.EventHandler(this.transactionHistoryToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.customersToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Hopstarter_Soft_Scraps_User_Clients_64;
            this.customersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(266, 68);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.peopleToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Dtafalonso_Win_10x_People_64;
            this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(200, 68);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Checked = true;
            this.usersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.usersToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Icojam_Blue_Bits_User_settings_64;
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(187, 68);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currenUserToolStripMenuItem,
            this.changeUserPasswordToolStripMenuItem});
            this.signOutToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.signOutToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Dtafalonso_Android_Lollipop_Settings_64;
            this.signOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(226, 68);
            this.signOutToolStripMenuItem.Text = "Settings";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // currenUserToolStripMenuItem
            // 
            this.currenUserToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currenUserToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Dario_Arnaez_Genesis_3G_User_Files_24;
            this.currenUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.currenUserToolStripMenuItem.Name = "currenUserToolStripMenuItem";
            this.currenUserToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.currenUserToolStripMenuItem.Text = "Current User info";
            this.currenUserToolStripMenuItem.Click += new System.EventHandler(this.currenUserToolStripMenuItem_Click);
            // 
            // changeUserPasswordToolStripMenuItem
            // 
            this.changeUserPasswordToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.changeUserPasswordToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Icons8_Ios7_User_Interface_Password_24;
            this.changeUserPasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changeUserPasswordToolStripMenuItem.Name = "changeUserPasswordToolStripMenuItem";
            this.changeUserPasswordToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.changeUserPasswordToolStripMenuItem.Text = "Change Password";
            this.changeUserPasswordToolStripMenuItem.Click += new System.EventHandler(this.changeUserPasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Image = global::BankSystem_UI.Properties.Resources.Saki_NuoveXT_2_Apps_session_logout_64;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(202, 68);
            this.toolStripMenuItem1.Text = "Logout";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 53);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 808);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1584, 53);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(53, 683);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1531, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(53, 683);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(87, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 136);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bank System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Location = new System.Drawing.Point(350, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 47);
            this.label4.TabIndex = 8;
            this.label4.Text = "Welcome To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(53, 786);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Verson 1.0.0";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(377, 193);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(852, 531);
            this.panel6.TabIndex = 12;
            this.panel6.Resize += new System.EventHandler(this.panel6_Resize);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::BankSystem_UI.Properties.Resources.Microsoft_Fluentui_Emoji_Mono_Bank_128;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(297, 350);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(314, 129);
            this.panel5.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem currenUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStripMenuItem transactionHistoryToolStripMenuItem;
    }
}

