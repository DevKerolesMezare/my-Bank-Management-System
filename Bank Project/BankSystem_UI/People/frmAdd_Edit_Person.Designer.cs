namespace BankSystem_UI.People
{
    partial class frmAdd_Edit_Person
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 78);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(101, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(335, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Person";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPersonID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(10, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 60);
            this.panel2.TabIndex = 1;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.ForeColor = System.Drawing.Color.Red;
            this.lblPersonID.Location = new System.Drawing.Point(121, 18);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(44, 24);
            this.lblPersonID.TabIndex = 1;
            this.lblPersonID.Text = "[??]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "PersonID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.dtpDateOfBirth);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSecondName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtThirdName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNationalNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(7, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 368);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BankSystem_UI.Properties.Resources.Woman_32;
            this.pictureBox1.Location = new System.Drawing.Point(397, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BankSystem_UI.Properties.Resources.Man_321;
            this.pictureBox2.Location = new System.Drawing.Point(289, 324);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 116;
            this.pictureBox2.TabStop = false;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(434, 324);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(98, 28);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.Click += new System.EventHandler(this.rbFemale_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(331, 324);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(73, 28);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.Click += new System.EventHandler(this.rbMale_Click);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(11, 324);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(203, 29);
            this.dtpDateOfBirth.TabIndex = 5;
            this.dtpDateOfBirth.Value = new System.DateTime(2025, 10, 30, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(292, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Date of Birth";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(297, 233);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(203, 26);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LettersOnly_KeyPress);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(292, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Last Name";
            // 
            // txtSecondName
            // 
            this.txtSecondName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecondName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.Location = new System.Drawing.Point(297, 152);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(203, 26);
            this.txtSecondName.TabIndex = 2;
            this.txtSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LettersOnly_KeyPress);
            this.txtSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSecondName_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(292, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Second Name";
            // 
            // txtThirdName
            // 
            this.txtThirdName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtThirdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThirdName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtThirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThirdName.Location = new System.Drawing.Point(11, 233);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(203, 26);
            this.txtThirdName.TabIndex = 3;
            this.txtThirdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LettersOnly_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Third Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(11, 152);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(203, 26);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LettersOnly_KeyPress);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "First Name";
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNationalNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationalNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNationalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalNo.Location = new System.Drawing.Point(146, 53);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(203, 26);
            this.txtNationalNo.TabIndex = 0;
            this.txtNationalNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalNo_KeyPress);
            this.txtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNo_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "National NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.llRemoveImage);
            this.groupBox2.Controls.Add(this.llSetImage);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.pbPersonImage);
            this.groupBox2.Controls.Add(this.cbCountry);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(7, 527);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 486);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Information";
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.Location = new System.Drawing.Point(430, 255);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(87, 24);
            this.llRemoveImage.TabIndex = 12;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove";
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.Location = new System.Drawing.Point(304, 255);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(103, 24);
            this.llSetImage.TabIndex = 12;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(286, 405);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(231, 53);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonImage.Location = new System.Drawing.Point(277, 56);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(254, 182);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 14;
            this.pbPersonImage.TabStop = false;
            // 
            // cbCountry
            // 
            this.cbCountry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(11, 226);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(203, 32);
            this.cbCountry.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Country";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(13, 321);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(233, 147);
            this.txtAddress.TabIndex = 11;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(8, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 25);
            this.label13.TabIndex = 8;
            this.label13.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(13, 147);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(203, 26);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(8, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 25);
            this.label15.TabIndex = 4;
            this.label15.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(13, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 26);
            this.txtEmail.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(8, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Email";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(286, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(231, 53);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(286, 346);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(231, 53);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAdd_Edit_Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 1022);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAdd_Edit_Person";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAdd_Edit_Person_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel llRemoveImage;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}