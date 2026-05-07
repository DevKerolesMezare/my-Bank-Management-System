namespace BankSystem_UI.Transactions
{
    partial class frmTransactionMain
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
            this.manageServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swttingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAccountDetilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chanageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transfarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depoistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalWithdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickWithdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seginOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageServicesToolStripMenuItem,
            this.swttingsToolStripMenuItem,
            this.transactionTypeToolStripMenuItem,
            this.seginOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageServicesToolStripMenuItem
            // 
            this.manageServicesToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Everaldo_Kids_Icons_Package_utilities_48;
            this.manageServicesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageServicesToolStripMenuItem.Name = "manageServicesToolStripMenuItem";
            this.manageServicesToolStripMenuItem.Size = new System.Drawing.Size(332, 68);
            this.manageServicesToolStripMenuItem.Text = "Manage Services";
            // 
            // swttingsToolStripMenuItem
            // 
            this.swttingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAccountDetilsToolStripMenuItem,
            this.chanageToolStripMenuItem});
            this.swttingsToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.account_settings_64;
            this.swttingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.swttingsToolStripMenuItem.Name = "swttingsToolStripMenuItem";
            this.swttingsToolStripMenuItem.Size = new System.Drawing.Size(333, 68);
            this.swttingsToolStripMenuItem.Text = "Account Control";
            this.swttingsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // showAccountDetilsToolStripMenuItem
            // 
            this.showAccountDetilsToolStripMenuItem.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.showAccountDetilsToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Inipagi_Business_Economic_View_24;
            this.showAccountDetilsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showAccountDetilsToolStripMenuItem.Name = "showAccountDetilsToolStripMenuItem";
            this.showAccountDetilsToolStripMenuItem.Size = new System.Drawing.Size(319, 38);
            this.showAccountDetilsToolStripMenuItem.Text = "Show Account Details";
            this.showAccountDetilsToolStripMenuItem.Click += new System.EventHandler(this.showAccountDetilsToolStripMenuItem_Click);
            // 
            // chanageToolStripMenuItem
            // 
            this.chanageToolStripMenuItem.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.chanageToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Number_321;
            this.chanageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chanageToolStripMenuItem.Name = "chanageToolStripMenuItem";
            this.chanageToolStripMenuItem.Size = new System.Drawing.Size(319, 38);
            this.chanageToolStripMenuItem.Text = "Change PinCode";
            this.chanageToolStripMenuItem.Click += new System.EventHandler(this.chanageToolStripMenuItem_Click);
            // 
            // transactionTypeToolStripMenuItem
            // 
            this.transactionTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transfarToolStripMenuItem,
            this.depoistToolStripMenuItem,
            this.withdrawToolStripMenuItem});
            this.transactionTypeToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Custom_Icon_Design_Flatastic_11_Arrows_64;
            this.transactionTypeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transactionTypeToolStripMenuItem.Name = "transactionTypeToolStripMenuItem";
            this.transactionTypeToolStripMenuItem.Size = new System.Drawing.Size(352, 68);
            this.transactionTypeToolStripMenuItem.Text = "Transaction Type";
            this.transactionTypeToolStripMenuItem.Click += new System.EventHandler(this.transactionTypeToolStripMenuItem_Click);
            // 
            // transfarToolStripMenuItem
            // 
            this.transfarToolStripMenuItem.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.transfarToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Gartoon_Team_Gartoon_Misc_Media_Playlist_Shuffle_24;
            this.transfarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transfarToolStripMenuItem.Name = "transfarToolStripMenuItem";
            this.transfarToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.transfarToolStripMenuItem.Text = "Transfar";
            this.transfarToolStripMenuItem.Click += new System.EventHandler(this.transfarToolStripMenuItem_Click);
            // 
            // depoistToolStripMenuItem
            // 
            this.depoistToolStripMenuItem.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoistToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Add_24;
            this.depoistToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.depoistToolStripMenuItem.Name = "depoistToolStripMenuItem";
            this.depoistToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.depoistToolStripMenuItem.Text = "Depoist";
            this.depoistToolStripMenuItem.Click += new System.EventHandler(this.depoistToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalWithdrawToolStripMenuItem,
            this.quickWithdrawToolStripMenuItem});
            this.withdrawToolStripMenuItem.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.withdrawToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Iconarchive_Red_Orb_Alphabet_Math_minus_24;
            this.withdrawToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            // 
            // normalWithdrawToolStripMenuItem
            // 
            this.normalWithdrawToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Handdrawngoods_Busy_Money_24;
            this.normalWithdrawToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.normalWithdrawToolStripMenuItem.Name = "normalWithdrawToolStripMenuItem";
            this.normalWithdrawToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.normalWithdrawToolStripMenuItem.Text = "Normal Withdraw";
            this.normalWithdrawToolStripMenuItem.Click += new System.EventHandler(this.normalWithdrawToolStripMenuItem_Click);
            // 
            // quickWithdrawToolStripMenuItem
            // 
            this.quickWithdrawToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Github_Octicons_Rocket_241;
            this.quickWithdrawToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.quickWithdrawToolStripMenuItem.Name = "quickWithdrawToolStripMenuItem";
            this.quickWithdrawToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.quickWithdrawToolStripMenuItem.Text = "Quick Withdraw";
            this.quickWithdrawToolStripMenuItem.Click += new System.EventHandler(this.quickWithdrawToolStripMenuItem_Click);
            // 
            // seginOutToolStripMenuItem
            // 
            this.seginOutToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Saki_NuoveXT_2_Apps_session_logout_64;
            this.seginOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.seginOutToolStripMenuItem.Name = "seginOutToolStripMenuItem";
            this.seginOutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.seginOutToolStripMenuItem.Size = new System.Drawing.Size(219, 68);
            this.seginOutToolStripMenuItem.Text = "Sign Out";
            this.seginOutToolStripMenuItem.Click += new System.EventHandler(this.seginOutToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(50, 767);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "By: Keroles Mezare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(50, 789);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Verson 1.0.0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(50, 811);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1484, 50);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1534, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 739);
            this.panel4.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 739);
            this.panel1.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(300, 194);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1030, 526);
            this.panel6.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::BankSystem_UI.Properties.Resources.Fa_Team_Fontawesome_Emoji_FontAwesome_Emoji_Face_Smile_Beam_128;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(400, 340);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(314, 129);
            this.panel5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(426, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 47);
            this.label4.TabIndex = 8;
            this.label4.Text = "Welcome To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(33, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(968, 136);
            this.label1.TabIndex = 5;
            this.label1.Text = "Transaction Main";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1584, 50);
            this.panel2.TabIndex = 22;
            // 
            // frmTransactionMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmTransactionMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTransactionMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem swttingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seginOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depoistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAccountDetilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chanageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalWithdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickWithdrawToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem transfarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageServicesToolStripMenuItem;
    }
}