namespace LibraryProject
{
    partial class frmMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMember));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.memberList = new System.Windows.Forms.DataGridView();
            this.memberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberTCNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberEMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnList.Location = new System.Drawing.Point(8, 159);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(150, 30);
            this.btnList.TabIndex = 12;
            this.btnList.Text = "  List";
            this.btnList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtBirthDate);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.rdbFemale);
            this.panel2.Controls.Add(this.rdbMale);
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.lblMemberID);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtSurname);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtEMail);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtTCNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 197);
            this.panel2.TabIndex = 19;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBirthDate.Location = new System.Drawing.Point(261, 119);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(100, 23);
            this.txtBirthDate.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 195);
            this.panel3.TabIndex = 18;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(8, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(150, 30);
            this.btnNew.TabIndex = 13;
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
            this.btnCancel.Location = new System.Drawing.Point(8, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 30);
            this.btnCancel.TabIndex = 11;
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
            this.btnSave.Location = new System.Drawing.Point(8, 69);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 10;
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
            this.btnEdit.Location = new System.Drawing.Point(8, 39);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 30);
            this.btnEdit.TabIndex = 11;
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
            this.btnDelete.Location = new System.Drawing.Point(8, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "  Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbFemale.Location = new System.Drawing.Point(329, 152);
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
            this.rdbMale.Location = new System.Drawing.Point(264, 152);
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
            this.lblGender.Location = new System.Drawing.Point(433, 160);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(33, 15);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "Male";
            this.lblGender.Visible = false;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(403, 7);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(13, 15);
            this.lblMemberID.TabIndex = 15;
            this.lblMemberID.Text = "0";
            this.lblMemberID.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(366, 29);
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
            this.label3.Location = new System.Drawing.Point(174, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Member\'s Informations";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(173, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(196, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Surname";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(433, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(445, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "E-Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(443, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(206, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(214, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(208, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "T.C. No";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(496, 30);
            this.txtPhone.MaxLength = 16;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(120, 23);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(261, 90);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(140, 23);
            this.txtSurname.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(496, 90);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(260, 81);
            this.txtAddress.TabIndex = 9;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(496, 60);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(260, 23);
            this.txtEMail.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(261, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(261, 30);
            this.txtTCNo.MaxLength = 11;
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(100, 23);
            this.txtTCNo.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "      Members";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memberList
            // 
            this.memberList.AllowUserToAddRows = false;
            this.memberList.AllowUserToDeleteRows = false;
            this.memberList.AllowUserToResizeColumns = false;
            this.memberList.AllowUserToResizeRows = false;
            this.memberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memberList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.memberList.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memberList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.memberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.memberList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberID,
            this.memberTCNo,
            this.name,
            this.memberName,
            this.memberSurname,
            this.memberGender,
            this.memberBirthDate,
            this.memberPhone,
            this.memberEMail,
            this.memberAddress});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.memberList.DefaultCellStyle = dataGridViewCellStyle2;
            this.memberList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.memberList.EnableHeadersVisualStyles = false;
            this.memberList.Location = new System.Drawing.Point(0, 232);
            this.memberList.MultiSelect = false;
            this.memberList.Name = "memberList";
            this.memberList.ReadOnly = true;
            this.memberList.RowHeadersVisible = false;
            this.memberList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.memberList.RowTemplate.Height = 25;
            this.memberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memberList.Size = new System.Drawing.Size(773, 252);
            this.memberList.TabIndex = 18;
            this.memberList.TabStop = false;
            this.memberList.Click += new System.EventHandler(this.memberList_Click);
            this.memberList.DoubleClick += new System.EventHandler(this.memberList_DoubleClick);
            // 
            // memberID
            // 
            this.memberID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.memberID.DataPropertyName = "memberID";
            this.memberID.HeaderText = "ID";
            this.memberID.Name = "memberID";
            this.memberID.ReadOnly = true;
            this.memberID.Visible = false;
            // 
            // memberTCNo
            // 
            this.memberTCNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.memberTCNo.DataPropertyName = "memberTCNo";
            this.memberTCNo.HeaderText = "T.C. No";
            this.memberTCNo.Name = "memberTCNo";
            this.memberTCNo.ReadOnly = true;
            this.memberTCNo.Width = 70;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name Surname";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 115;
            // 
            // memberName
            // 
            this.memberName.DataPropertyName = "memberName";
            this.memberName.HeaderText = "Name";
            this.memberName.Name = "memberName";
            this.memberName.ReadOnly = true;
            this.memberName.Visible = false;
            // 
            // memberSurname
            // 
            this.memberSurname.DataPropertyName = "memberSurname";
            this.memberSurname.HeaderText = "Surname";
            this.memberSurname.Name = "memberSurname";
            this.memberSurname.ReadOnly = true;
            this.memberSurname.Visible = false;
            // 
            // memberGender
            // 
            this.memberGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.memberGender.DataPropertyName = "memberGender";
            this.memberGender.HeaderText = "Gender";
            this.memberGender.Name = "memberGender";
            this.memberGender.ReadOnly = true;
            this.memberGender.Width = 70;
            // 
            // memberBirthDate
            // 
            this.memberBirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.memberBirthDate.DataPropertyName = "memberBirthDate";
            this.memberBirthDate.HeaderText = "Date of Birth";
            this.memberBirthDate.Name = "memberBirthDate";
            this.memberBirthDate.ReadOnly = true;
            this.memberBirthDate.Width = 99;
            // 
            // memberPhone
            // 
            this.memberPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.memberPhone.DataPropertyName = "memberPhone";
            this.memberPhone.HeaderText = "Phone";
            this.memberPhone.Name = "memberPhone";
            this.memberPhone.ReadOnly = true;
            this.memberPhone.Width = 66;
            // 
            // memberEMail
            // 
            this.memberEMail.DataPropertyName = "memberEMail";
            this.memberEMail.HeaderText = "E-Mail";
            this.memberEMail.Name = "memberEMail";
            this.memberEMail.ReadOnly = true;
            // 
            // memberAddress
            // 
            this.memberAddress.DataPropertyName = "memberAddress";
            this.memberAddress.HeaderText = "Address";
            this.memberAddress.Name = "memberAddress";
            this.memberAddress.ReadOnly = true;
            this.memberAddress.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(738, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.panel1.Size = new System.Drawing.Size(773, 35);
            this.panel1.TabIndex = 17;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // frmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 484);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.memberList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMember";
            this.Load += new System.EventHandler(this.frmMember_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnList;
        private Panel panel2;
        private Label lblMemberID;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private Label label3;
        private Label label4;
        private Label label2;
        private TextBox txtName;
        private TextBox txtTCNo;
        private Label label1;
        private DataGridView memberList;
        private Button btnExit;
        private Panel panel1;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label5;
        private TextBox txtSurname;
        private TextBox txtAddress;
        private TextBox txtEMail;
        private Label lblGender;
        private TextBox txtPhone;
        private Button btnCancel;
        private Button btnNew;
        private DataGridViewTextBoxColumn memberID;
        private DataGridViewTextBoxColumn memberTCNo;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn memberName;
        private DataGridViewTextBoxColumn memberSurname;
        private DataGridViewTextBoxColumn memberGender;
        private DataGridViewTextBoxColumn memberBirthDate;
        private DataGridViewTextBoxColumn memberPhone;
        private DataGridViewTextBoxColumn memberEMail;
        private DataGridViewTextBoxColumn memberAddress;
        private Panel panel3;
        private DateTimePicker txtBirthDate;
    }
}