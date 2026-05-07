namespace BankSystem_UI.Accounts
{
    partial class frmAccountTypes
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
            this.dgvAccountTypes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccountTypes
            // 
            this.dgvAccountTypes.AllowUserToAddRows = false;
            this.dgvAccountTypes.AllowUserToDeleteRows = false;
            this.dgvAccountTypes.AllowUserToResizeRows = false;
            this.dgvAccountTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAccountTypes.Location = new System.Drawing.Point(24, 149);
            this.dgvAccountTypes.Name = "dgvAccountTypes";
            this.dgvAccountTypes.ReadOnly = true;
            this.dgvAccountTypes.Size = new System.Drawing.Size(523, 126);
            this.dgvAccountTypes.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateNameToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.enableServiceToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 94);
            // 
            // updateNameToolStripMenuItem
            // 
            this.updateNameToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Custom_Icon_Design_Pretty_Office_9_Edit_file_32;
            this.updateNameToolStripMenuItem.Name = "updateNameToolStripMenuItem";
            this.updateNameToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.updateNameToolStripMenuItem.Text = "Update Account Type";
            this.updateNameToolStripMenuItem.Click += new System.EventHandler(this.updateNameToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Mazenl77_I_Like_Buttons_3a_Cute_Ball_Shutdown_32;
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.displayToolStripMenuItem.Text = "Disable Servicey";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // enableServiceToolStripMenuItem
            // 
            this.enableServiceToolStripMenuItem.Image = global::BankSystem_UI.Properties.Resources.Mazenl77_I_Like_Buttons_3a_Cute_Ball_Go_32__1_;
            this.enableServiceToolStripMenuItem.Name = "enableServiceToolStripMenuItem";
            this.enableServiceToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.enableServiceToolStripMenuItem.Text = "Enable Service";
            this.enableServiceToolStripMenuItem.Click += new System.EventHandler(this.enableServiceToolStripMenuItem_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.ForeColor = System.Drawing.Color.Red;
            this.lblRecordsCount.Location = new System.Drawing.Point(109, 290);
            this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(42, 20);
            this.lblRecordsCount.TabIndex = 25;
            this.lblRecordsCount.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "#Record(s):";
            // 
            // frmAccountTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 348);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvAccountTypes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAccountTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Types";
            this.Load += new System.EventHandler(this.frmAccountTypes_Load);
            this.Controls.SetChildIndex(this.dgvAccountTypes, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lblRecordsCount, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccountTypes;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableServiceToolStripMenuItem;
    }
}