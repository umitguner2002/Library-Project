namespace LibraryProject
{
    partial class frmAuthor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuthor));
            this.authorList = new System.Windows.Forms.DataGridView();
            this.authorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthorCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authorList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorList
            // 
            this.authorList.AllowUserToAddRows = false;
            this.authorList.AllowUserToDeleteRows = false;
            this.authorList.AllowUserToResizeColumns = false;
            this.authorList.AllowUserToResizeRows = false;
            this.authorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.authorList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.authorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorID,
            this.authorName,
            this.authorCountry});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.authorList.DefaultCellStyle = dataGridViewCellStyle2;
            this.authorList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.authorList.EnableHeadersVisualStyles = false;
            this.authorList.Location = new System.Drawing.Point(0, 194);
            this.authorList.MultiSelect = false;
            this.authorList.Name = "authorList";
            this.authorList.ReadOnly = true;
            this.authorList.RowHeadersVisible = false;
            this.authorList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.authorList.RowTemplate.Height = 25;
            this.authorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.authorList.Size = new System.Drawing.Size(300, 326);
            this.authorList.TabIndex = 8;
            this.authorList.Click += new System.EventHandler(this.authorList_Click);
            this.authorList.DoubleClick += new System.EventHandler(this.authorList_DoubleClick);
            // 
            // authorID
            // 
            this.authorID.DataPropertyName = "authorID";
            this.authorID.HeaderText = "ID";
            this.authorID.Name = "authorID";
            this.authorID.ReadOnly = true;
            this.authorID.Visible = false;
            // 
            // authorName
            // 
            this.authorName.DataPropertyName = "authorName";
            this.authorName.FillWeight = 98.47716F;
            this.authorName.HeaderText = "Author\'s Name";
            this.authorName.Name = "authorName";
            this.authorName.ReadOnly = true;
            // 
            // authorCountry
            // 
            this.authorCountry.DataPropertyName = "authorCountry";
            this.authorCountry.FillWeight = 101.5228F;
            this.authorCountry.HeaderText = "Author\'s Country";
            this.authorCountry.Name = "authorCountry";
            this.authorCountry.ReadOnly = true;
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
            this.panel1.Size = new System.Drawing.Size(300, 35);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(265, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "      Authors";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Location = new System.Drawing.Point(241, 4);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(13, 15);
            this.lblAuthorID.TabIndex = 15;
            this.lblAuthorID.Text = "0";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(256, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 25);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(201, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "  Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(105, 84);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "  Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(9, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "  Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(70, 26);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(184, 23);
            this.txtAuthorName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Author\'s";
            // 
            // txtAuthorCountry
            // 
            this.txtAuthorCountry.Location = new System.Drawing.Point(70, 55);
            this.txtAuthorCountry.Name = "txtAuthorCountry";
            this.txtAuthorCountry.Size = new System.Drawing.Size(184, 23);
            this.txtAuthorCountry.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Country";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnList);
            this.panel2.Controls.Add(this.lblAuthorID);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtAuthorCountry);
            this.panel2.Controls.Add(this.txtAuthorName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 159);
            this.panel2.TabIndex = 16;
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnList.Location = new System.Drawing.Point(9, 119);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(282, 30);
            this.btnList.TabIndex = 16;
            this.btnList.Text = "  List";
            this.btnList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // frmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(300, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.authorList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAuthor";
            this.Load += new System.EventHandler(this.frmAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView authorList;
        private Panel panel1;
        private Button btnExit;
        private Label label1;
        private Label lblAuthorID;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label label2;
        private TextBox txtAuthorName;
        private Label label3;
        private TextBox txtAuthorCountry;
        private Label label4;
        private DataGridViewTextBoxColumn authorID;
        private DataGridViewTextBoxColumn authorName;
        private DataGridViewTextBoxColumn authorCountry;
        private Panel panel2;
        private Button btnList;
    }
}