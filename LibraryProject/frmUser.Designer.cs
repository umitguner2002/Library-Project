namespace LibraryProject
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.DataGridView();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "      Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userList
            // 
            this.userList.AllowUserToAddRows = false;
            this.userList.AllowUserToDeleteRows = false;
            this.userList.AllowUserToResizeColumns = false;
            this.userList.AllowUserToResizeRows = false;
            this.userList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.userList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.userList.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userList.DefaultCellStyle = dataGridViewCellStyle2;
            this.userList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userList.EnableHeadersVisualStyles = false;
            this.userList.Location = new System.Drawing.Point(0, 262);
            this.userList.MultiSelect = false;
            this.userList.Name = "userList";
            this.userList.ReadOnly = true;
            this.userList.RowHeadersVisible = false;
            this.userList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.userList.RowTemplate.Height = 25;
            this.userList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userList.Size = new System.Drawing.Size(609, 152);
            this.userList.TabIndex = 21;
            this.userList.TabStop = false;
            this.userList.Click += new System.EventHandler(this.userList_Click);
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbFemale.Location = new System.Drawing.Point(414, 124);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(67, 21);
            this.rdbFemale.TabIndex = 6;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            this.rdbFemale.CheckedChanged += new System.EventHandler(this.rdbFemale_CheckedChanged);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Checked = true;
            this.rdbMale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbMale.Location = new System.Drawing.Point(349, 124);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(55, 21);
            this.rdbMale.TabIndex = 5;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            this.rdbMale.CheckedChanged += new System.EventHandler(this.rdbMale_CheckedChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(541, 127);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(33, 15);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "Male";
            this.lblGender.Visible = false;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(237, 9);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(13, 15);
            this.lblUserID.TabIndex = 15;
            this.lblUserID.Text = "0";
            this.lblUserID.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(236, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "User\'s Informations";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(7, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(30, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Surname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(300, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "E-Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(298, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(293, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(574, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(48, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtBirthDate);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnList);
            this.panel2.Controls.Add(this.rdbFemale);
            this.panel2.Controls.Add(this.rdbMale);
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.lblUserID);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtSurname);
            this.panel2.Controls.Add(this.txtEMail);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 379);
            this.panel2.TabIndex = 22;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBirthDate.Location = new System.Drawing.Point(95, 122);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(140, 23);
            this.txtBirthDate.TabIndex = 22;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(11, 154);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 30);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "  New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(483, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 30);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "  Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(247, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 30);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "  Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(129, 154);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 30);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "  Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(365, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 30);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "  Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnList.Location = new System.Drawing.Point(11, 190);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(584, 30);
            this.btnList.TabIndex = 19;
            this.btnList.Text = "  List";
            this.btnList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(279, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(348, 62);
            this.txtPhone.MaxLength = 16;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(120, 23);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(95, 92);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(140, 23);
            this.txtSurname.TabIndex = 3;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(348, 92);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(252, 23);
            this.txtEMail.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(348, 32);
            this.txtPassword.MaxLength = 11;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(140, 23);
            this.txtPassword.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(95, 32);
            this.txtUsername.MaxLength = 11;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(140, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 35);
            this.panel1.TabIndex = 20;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 414);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private DataGridView userList;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private Label lblGender;
        private Label lblUserID;
        private Button btnSearch;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label5;
        private Button btnExit;
        private Label label4;
        private Panel panel2;
        private Label label2;
        private TextBox txtPhone;
        private TextBox txtSurname;
        private TextBox txtEMail;
        private TextBox txtName;
        private TextBox txtUsername;
        private Panel panel1;
        private Button btnNew;
        private Button btnCancel;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnList;
        private Label label10;
        private TextBox txtPassword;
        private DateTimePicker txtBirthDate;
    }
}