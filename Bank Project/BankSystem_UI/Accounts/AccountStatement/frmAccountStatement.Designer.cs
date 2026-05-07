namespace BankSystem_UI.Accounts
{
    partial class frmAccountStatement
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnFindStatement = new System.Windows.Forms.Button();
            this.dgvAccountStatement = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.White;
            this.gbFilter.Controls.Add(this.dtpEndDate);
            this.gbFilter.Controls.Add(this.dtpStartDate);
            this.gbFilter.Controls.Add(this.label3);
            this.gbFilter.Controls.Add(this.label2);
            this.gbFilter.Controls.Add(this.txtAccountNumber);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(0, 125);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1310, 90);
            this.gbFilter.TabIndex = 17;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(999, 34);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(178, 26);
            this.dtpEndDate.TabIndex = 5;
            this.dtpEndDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpEndDate_Validating);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(615, 34);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(178, 26);
            this.dtpStartDate.TabIndex = 4;
            this.dtpStartDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpStartDate_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(897, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "EndDate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "StartDate:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(260, 31);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(164, 29);
            this.txtAccountNumber.TabIndex = 1;
            this.txtAccountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnFindStatement
            // 
            this.btnFindStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindStatement.Image = global::BankSystem_UI.Properties.Resources.Inipagi_Business_Economic_Search_48;
            this.btnFindStatement.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindStatement.Location = new System.Drawing.Point(1316, 125);
            this.btnFindStatement.Name = "btnFindStatement";
            this.btnFindStatement.Size = new System.Drawing.Size(190, 90);
            this.btnFindStatement.TabIndex = 18;
            this.btnFindStatement.Text = "Research";
            this.btnFindStatement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindStatement.UseVisualStyleBackColor = true;
            this.btnFindStatement.Click += new System.EventHandler(this.btnFindStatement_Click);
            // 
            // dgvAccountStatement
            // 
            this.dgvAccountStatement.AllowUserToAddRows = false;
            this.dgvAccountStatement.AllowUserToDeleteRows = false;
            this.dgvAccountStatement.AllowUserToResizeRows = false;
            this.dgvAccountStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountStatement.Location = new System.Drawing.Point(26, 243);
            this.dgvAccountStatement.Name = "dgvAccountStatement";
            this.dgvAccountStatement.ReadOnly = true;
            this.dgvAccountStatement.Size = new System.Drawing.Size(1480, 300);
            this.dgvAccountStatement.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::BankSystem_UI.Properties.Resources.Icons8_Windows_8_Computer_Hardware_Restart_48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(1206, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 56);
            this.button2.TabIndex = 21;
            this.button2.Text = "Reset";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::BankSystem_UI.Properties.Resources.Papirus_Team_Papirus_Devices_Printer_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1377, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 56);
            this.button1.TabIndex = 20;
            this.button1.Text = "Print";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.ForeColor = System.Drawing.Color.Red;
            this.lblRecordsCount.Location = new System.Drawing.Point(111, 549);
            this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(42, 20);
            this.lblRecordsCount.TabIndex = 23;
            this.lblRecordsCount.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 549);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "#Record(s):";
            // 
            // frmAccountStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 620);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAccountStatement);
            this.Controls.Add(this.btnFindStatement);
            this.Controls.Add(this.gbFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAccountStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Statement";
            this.Load += new System.EventHandler(this.frmAccountStatement_Load);
            this.Controls.SetChildIndex(this.gbFilter, 0);
            this.Controls.SetChildIndex(this.btnFindStatement, 0);
            this.Controls.SetChildIndex(this.dgvAccountStatement, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lblRecordsCount, 0);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountStatement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnFindStatement;
        private System.Windows.Forms.DataGridView dgvAccountStatement;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label4;
    }
}