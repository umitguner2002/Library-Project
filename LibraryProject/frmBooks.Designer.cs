namespace LibraryProject
{
    partial class frmBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.bookList = new System.Windows.Forms.DataGridView();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnISBN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPublishDate = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtPageCount = new System.Windows.Forms.NumericUpDown();
            this.lblPublisherID = new System.Windows.Forms.Label();
            this.lblGenreID = new System.Windows.Forms.Label();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.btnPublisher = new System.Windows.Forms.Button();
            this.btnGenre = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookGenreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublisherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageCount)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "      Books";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel3.Size = new System.Drawing.Size(168, 408);
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
            this.btnNew.TabIndex = 9;
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
            this.btnCancel.TabIndex = 13;
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
            this.btnSave.TabIndex = 11;
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
            this.btnEdit.TabIndex = 10;
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
            this.btnDelete.TabIndex = 12;
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
            this.btnList.Location = new System.Drawing.Point(8, 159);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(150, 30);
            this.btnList.TabIndex = 14;
            this.btnList.Text = "  List && Clear";
            this.btnList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // bookList
            // 
            this.bookList.AllowUserToAddRows = false;
            this.bookList.AllowUserToDeleteRows = false;
            this.bookList.AllowUserToResizeColumns = false;
            this.bookList.AllowUserToResizeRows = false;
            this.bookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.bookList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.bookList.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookList.DefaultCellStyle = dataGridViewCellStyle2;
            this.bookList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bookList.EnableHeadersVisualStyles = false;
            this.bookList.Location = new System.Drawing.Point(0, 232);
            this.bookList.MultiSelect = false;
            this.bookList.Name = "bookList";
            this.bookList.ReadOnly = true;
            this.bookList.RowHeadersVisible = false;
            this.bookList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bookList.RowTemplate.Height = 25;
            this.bookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookList.Size = new System.Drawing.Size(800, 213);
            this.bookList.TabIndex = 21;
            this.bookList.TabStop = false;
            this.bookList.Click += new System.EventHandler(this.bookList_Click);
            this.bookList.DoubleClick += new System.EventHandler(this.bookList_DoubleClick);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(439, 38);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(13, 15);
            this.lblBookID.TabIndex = 15;
            this.lblBookID.Text = "0";
            // 
            // btnISBN
            // 
            this.btnISBN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnISBN.Image = ((System.Drawing.Image)(resources.GetObject("btnISBN.Image")));
            this.btnISBN.Location = new System.Drawing.Point(398, 34);
            this.btnISBN.Name = "btnISBN";
            this.btnISBN.Size = new System.Drawing.Size(35, 25);
            this.btnISBN.TabIndex = 1;
            this.btnISBN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnISBN.UseVisualStyleBackColor = true;
            this.btnISBN.Click += new System.EventHandler(this.btnISBN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(172, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Book\'s Informations";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(478, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Published Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(498, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Page Count";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(513, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Publisher";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(187, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Genre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(180, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Author";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(765, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 27);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(198, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Title";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtPublishDate);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtPageCount);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblPublisherID);
            this.panel2.Controls.Add(this.lblGenreID);
            this.panel2.Controls.Add(this.lblAuthorID);
            this.panel2.Controls.Add(this.lblBookID);
            this.panel2.Controls.Add(this.btnPublisher);
            this.panel2.Controls.Add(this.btnGenre);
            this.panel2.Controls.Add(this.btnAuthor);
            this.panel2.Controls.Add(this.btnTitle);
            this.panel2.Controls.Add(this.btnISBN);
            this.panel2.Controls.Add(this.lblBookCount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtAuthor);
            this.panel2.Controls.Add(this.txtGenre);
            this.panel2.Controls.Add(this.txtPublisher);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.txtISBN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 410);
            this.panel2.TabIndex = 22;
            // 
            // txtPublishDate
            // 
            this.txtPublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtPublishDate.Location = new System.Drawing.Point(583, 64);
            this.txtPublishDate.Name = "txtPublishDate";
            this.txtPublishDate.Size = new System.Drawing.Size(109, 23);
            this.txtPublishDate.TabIndex = 19;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(583, 122);
            this.txtQuantity.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(60, 23);
            this.txtQuantity.TabIndex = 8;
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(583, 93);
            this.txtPageCount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(60, 23);
            this.txtPageCount.TabIndex = 7;
            // 
            // lblPublisherID
            // 
            this.lblPublisherID.AutoSize = true;
            this.lblPublisherID.Location = new System.Drawing.Point(781, 40);
            this.lblPublisherID.Name = "lblPublisherID";
            this.lblPublisherID.Size = new System.Drawing.Size(13, 15);
            this.lblPublisherID.TabIndex = 15;
            this.lblPublisherID.Text = "0";
            // 
            // lblGenreID
            // 
            this.lblGenreID.AutoSize = true;
            this.lblGenreID.Location = new System.Drawing.Point(439, 127);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(13, 15);
            this.lblGenreID.TabIndex = 15;
            this.lblGenreID.Text = "0";
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Location = new System.Drawing.Point(439, 98);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(13, 15);
            this.lblAuthorID.TabIndex = 15;
            this.lblAuthorID.Text = "0";
            // 
            // btnPublisher
            // 
            this.btnPublisher.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPublisher.Image = ((System.Drawing.Image)(resources.GetObject("btnPublisher.Image")));
            this.btnPublisher.Location = new System.Drawing.Point(744, 34);
            this.btnPublisher.Name = "btnPublisher";
            this.btnPublisher.Size = new System.Drawing.Size(35, 25);
            this.btnPublisher.TabIndex = 5;
            this.btnPublisher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPublisher.UseVisualStyleBackColor = true;
            this.btnPublisher.Click += new System.EventHandler(this.btnPublisher_Click);
            // 
            // btnGenre
            // 
            this.btnGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenre.Image = ((System.Drawing.Image)(resources.GetObject("btnGenre.Image")));
            this.btnGenre.Location = new System.Drawing.Point(398, 121);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(35, 25);
            this.btnGenre.TabIndex = 4;
            this.btnGenre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenre.UseVisualStyleBackColor = true;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAuthor.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthor.Image")));
            this.btnAuthor.Location = new System.Drawing.Point(398, 92);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(35, 25);
            this.btnAuthor.TabIndex = 3;
            this.btnAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTitle.Image = ((System.Drawing.Image)(resources.GetObject("btnTitle.Image")));
            this.btnTitle.Location = new System.Drawing.Point(398, 63);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(35, 25);
            this.btnTitle.TabIndex = 1;
            this.btnTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // lblBookCount
            // 
            this.lblBookCount.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBookCount.ForeColor = System.Drawing.Color.Navy;
            this.lblBookCount.Location = new System.Drawing.Point(180, 151);
            this.lblBookCount.Name = "lblBookCount";
            this.lblBookCount.Size = new System.Drawing.Size(599, 41);
            this.lblBookCount.TabIndex = 10;
            this.lblBookCount.Text = "Numbers Of Books : ";
            this.lblBookCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(513, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(194, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "ISBN";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(237, 93);
            this.txtAuthor.MaxLength = 16;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(160, 23);
            this.txtAuthor.TabIndex = 3;
            this.txtAuthor.TabStop = false;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(237, 122);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(160, 23);
            this.txtGenre.TabIndex = 8;
            this.txtGenre.TabStop = false;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(583, 35);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(160, 23);
            this.txtPublisher.TabIndex = 8;
            this.txtPublisher.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(237, 64);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(160, 23);
            this.txtTitle.TabIndex = 2;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(237, 35);
            this.txtISBN.MaxLength = 50;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(160, 23);
            this.txtISBN.TabIndex = 0;
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBN_KeyPress);
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
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 20;
            // 
            // bookID
            // 
            this.bookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.bookID.DataPropertyName = "bookID";
            this.bookID.HeaderText = "ID";
            this.bookID.Name = "bookID";
            this.bookID.Visible = false;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // bookTitle
            // 
            this.bookTitle.DataPropertyName = "bookTitle";
            this.bookTitle.HeaderText = "Title";
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Width = 99;
            // 
            // bookPageCount
            // 
            this.bookPageCount.DataPropertyName = "bookPageCount";
            this.bookPageCount.HeaderText = "Page Count";
            this.bookPageCount.Name = "bookPageCount";
            // 
            // bookAuthorID
            // 
            this.bookAuthorID.DataPropertyName = "bookAuthorID";
            this.bookAuthorID.HeaderText = "AuthorID";
            this.bookAuthorID.Name = "bookAuthorID";
            this.bookAuthorID.Visible = false;
            // 
            // bookGenreID
            // 
            this.bookGenreID.DataPropertyName = "bookGenreID";
            this.bookGenreID.HeaderText = "GenreID";
            this.bookGenreID.Name = "bookGenreID";
            this.bookGenreID.Visible = false;
            this.bookGenreID.Width = 99;
            // 
            // bookPublisherID
            // 
            this.bookPublisherID.DataPropertyName = "bookPublisherID";
            this.bookPublisherID.HeaderText = "PublisherID";
            this.bookPublisherID.Name = "bookPublisherID";
            this.bookPublisherID.Visible = false;
            // 
            // bookPublishDate
            // 
            this.bookPublishDate.DataPropertyName = "bookPublishDate";
            this.bookPublishDate.HeaderText = "Published Date";
            this.bookPublishDate.Name = "bookPublishDate";
            this.bookPublishDate.Width = 99;
            // 
            // bookQuantity
            // 
            this.bookQuantity.DataPropertyName = "bookQuantity";
            this.bookQuantity.HeaderText = "Quantity";
            this.bookQuantity.Name = "bookQuantity";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bookID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn2.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 159;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "bookTitle";
            this.dataGridViewTextBoxColumn3.HeaderText = "Book\'s Title";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 160;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "bookPageCount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Page Count";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 159;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "bookAuthorID";
            this.dataGridViewTextBoxColumn5.HeaderText = "AuthorID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "bookGenreID";
            this.dataGridViewTextBoxColumn6.HeaderText = "GenreID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "bookPublisherID";
            this.dataGridViewTextBoxColumn7.HeaderText = "PublisherID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "bookPublishDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "Published Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 160;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "bookQuantity";
            this.dataGridViewTextBoxColumn9.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 159;
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.bookList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBooks";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel3;
        private Button btnNew;
        private Button btnCancel;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnList;
        private DataGridView bookList;
        private Label lblBookID;
        private Button btnISBN;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnExit;
        private Label label4;
        private Panel panel2;
        private Button btnAuthor;
        private Label label5;
        private Label label2;
        private TextBox txtAuthor;
        private TextBox txtGenre;
        private TextBox txtPublisher;
        private TextBox txtTitle;
        private TextBox txtISBN;
        private Panel panel1;
        private NumericUpDown txtQuantity;
        private NumericUpDown txtPageCount;
        private Button btnGenre;
        private Button btnPublisher;
        private Label lblPublisherID;
        private Label lblGenreID;
        private Label lblAuthorID;
        private DataGridViewTextBoxColumn bookID;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn bookTitle;
        private DataGridViewTextBoxColumn bookPageCount;
        private DataGridViewTextBoxColumn bookAuthorID;
        private DataGridViewTextBoxColumn bookGenreID;
        private DataGridViewTextBoxColumn bookPublisherID;
        private DataGridViewTextBoxColumn bookPublishDate;
        private DataGridViewTextBoxColumn bookQuantity;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Button btnTitle;
        private Label lblBookCount;
        private DateTimePicker txtPublishDate;
    }
}