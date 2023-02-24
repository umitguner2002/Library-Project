using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class frmBooks : Form
    {
        frmAuthor fAuthor = new frmAuthor();
        frmGenre fGenre = new frmGenre();
        frmPublisher fPublisher = new frmPublisher();

        MYDB db = new MYDB();
        MYMSG msg = new MYMSG();
        TitleBarAction tBarAct = new TitleBarAction();
        
        private int editMode = 0;

        public static int authorID = 0;
        public static String authorName = "";
        public static int genreID = 0;
        public static String genreName = "";
        public static int publisherID = 0;
        public static String publisherName = "";



        public frmBooks()
        {
            InitializeComponent();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            fAuthor.ShowDialog();
            lblAuthorID.Text = authorID.ToString();
            txtAuthor.Text = authorName;
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            fGenre.ShowDialog();
            lblGenreID.Text = genreID.ToString();
            txtGenre.Text = genreName;
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            fPublisher.ShowDialog();
            lblPublisherID.Text = publisherID.ToString();
            txtPublisher.Text = publisherName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            RefreshList(true);
            StateControl(true);
            editMode = 0;
            txtISBN.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lblBookID.Text != "0")
            {
                editMode = 1;
                StateControl(true);                
            }
            else
                msg.SelectItem();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblAuthorID.Text == "0")
            {
                msg.EmptyItem("Author");
                btnAuthor.Focus();
            }                
            else if (lblGenreID.Text == "0")
            {
                msg.EmptyItem("Genre");
                btnGenre.Focus();
            }                
            else if (lblPublisherID.Text == "0")
            {
                msg.EmptyItem("Publisher");
                btnPublisher.Focus();
            } 
            else if (txtISBN.Text != "")
            {
                if (editMode == 0)
                {
                    if (db.AddBook(txtISBN.Text, txtTitle.Text, Convert.ToInt32(txtPageCount.Value), Convert.ToInt32(lblAuthorID.Text), Convert.ToInt32(lblGenreID.Text), Convert.ToInt32(lblPublisherID.Text), txtPublishDate.Value, Convert.ToInt32(txtQuantity.Value)))
                    {
                        bookList.DataSource = db.BookDataSearch("ISBN", txtISBN.Text);
                        lblBookID.Text = bookList.CurrentRow.Cells[0].Value.ToString();
                        editMode = 0;
                        StateControl(false);
                    }
                    else
                    {
                        StateControl(true);
                        txtISBN.Focus();
                        txtISBN.SelectAll();
                    }
                }
                else
                {
                    int index = Convert.ToInt32(lblBookID.Text);

                    if (index > 0)
                    {
                        db.EditBook(index, txtISBN.Text, txtTitle.Text, Convert.ToInt32(txtPageCount.Value), Convert.ToInt32(lblAuthorID.Text), Convert.ToInt32(lblGenreID.Text), Convert.ToInt32(lblPublisherID.Text), txtPublishDate.Value, Convert.ToInt32(txtQuantity.Value));
                        bookList.DataSource = db.BookDataSearch("ISBN", txtISBN.Text);
                        lblBookID.Text = bookList.CurrentRow.Cells[0].Value.ToString();
                        editMode = 0;
                        StateControl(false);
                    }
                    else
                        msg.SelectItem();
                }
            }
            else
            {
                msg.EmptyItem("T.C.No");
                txtISBN.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StateControl(false);
            editMode = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lblBookID.Text);

            if (index > 0)
            {
                int result = db.DeleteBook(index);
                if (result == 1)
                    RefreshList(true);
            }
            else
                msg.SelectItem();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            RefreshList(true);
        }        

        private void frmBooks_Load(object sender, EventArgs e)
        {
            addBookListColumn();
            RefreshList(true);            
            StateControl(false);
        }        

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-';
        }

        private void bookList_Click(object sender, EventArgs e)
        {
            lblBookID.Text = bookList.CurrentRow.Cells[0].Value.ToString();
            txtISBN.Text = bookList.CurrentRow.Cells[1].Value.ToString();
            txtTitle.Text = bookList.CurrentRow.Cells[2].Value.ToString();
            txtPageCount.Value = Convert.ToInt32(bookList.CurrentRow.Cells[3].Value);
            txtAuthor.Text = bookList.CurrentRow.Cells[4].Value.ToString();
            txtGenre.Text = bookList.CurrentRow.Cells[5].Value.ToString();
            txtPublisher.Text = bookList.CurrentRow.Cells[6].Value.ToString();
            txtPublishDate.Text = bookList.CurrentRow.Cells[7].Value.ToString();
            txtQuantity.Value = Convert.ToInt32(bookList.CurrentRow.Cells[8].Value);
            lblAuthorID.Text = bookList.CurrentRow.Cells[9].Value.ToString();
            lblGenreID.Text = bookList.CurrentRow.Cells[10].Value.ToString();
            lblPublisherID.Text = bookList.CurrentRow.Cells[11].Value.ToString();
        }        

        private void txtPublishDate_Leave(object sender, EventArgs e)
        {
            String publishDate = txtPublishDate.Text;
            String newpublishDate = "";

            if (txtPublishDate.Text != "")
            {
                if (publishDate.Length == 8)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (i == 2 || i == 4)
                            newpublishDate += "/" + publishDate[i];
                        else
                            newpublishDate += publishDate[i];
                    }
                    txtPublishDate.Text = newpublishDate;
                }

                if (!IsDateControl(txtPublishDate.Text))
                {
                    MessageBox.Show("Wrong Date Value", "Date Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPublishDate.Focus();
                }
            }
        }

        private void RefreshList(bool control)
        {
            if(control == true)
            {
                bookList.DataSource = db.BookList();
                bookList.ClearSelection();
                if (bookList.RowCount > 0)
                    lblBookCount.Text = "Numbers of Books : " + bookList.RowCount.ToString();
            }
            
            lblBookID.Text = "0";
            lblAuthorID.Text = "0";
            lblGenreID.Text = "0";
            lblPublisherID.Text = "0";
            txtISBN.Text = "";
            txtTitle.Text = "";
            txtPageCount.Value = 0;
            txtAuthor.Text = "";
            txtGenre.Text = "";
            txtPublisher.Text = "";
            txtPublishDate.Value = DateTime.Now;
            txtQuantity.Value = 0;
            
        }

        private void StateControl(bool state)
        {
            if (state)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnList.Enabled = false;
                btnNew.Enabled = false;
                bookList.Enabled = false;
                btnISBN.Enabled = false;
                btnTitle.Enabled = false;
                btnAuthor.Enabled = true;
                btnGenre.Enabled = true;
                btnPublisher.Enabled = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                if (editMode == 0)
                {
                    txtISBN.ReadOnly = false;
                    txtTitle.ReadOnly = false;
                    txtPublishDate.Enabled = true;
                    txtPageCount.Enabled = true;
                    txtQuantity.Enabled = true;
                    panel2.BackColor = Color.DarkKhaki;
                }

                else
                {
                    txtISBN.ReadOnly = true;
                    txtTitle.ReadOnly = false;
                    txtPublishDate.Enabled = true;
                    txtPageCount.Enabled = true;
                    txtQuantity.Enabled = true;
                    panel2.BackColor = Color.DarkKhaki;
                }
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnList.Enabled = true;
                btnNew.Enabled = true;
                bookList.Enabled = true;
                btnISBN.Enabled = true;
                btnTitle.Enabled = true;
                btnAuthor.Enabled = false;
                btnGenre.Enabled = false;
                btnPublisher.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                txtISBN.ReadOnly = true;
                txtTitle.ReadOnly = true;
                txtPublishDate.Enabled = false;
                txtPageCount.Enabled = false;
                txtQuantity.Enabled = false;
                panel2.BackColor = Color.DarkSeaGreen;
            }
        }

        private void addBookListColumn()
        {
            bookList.ColumnCount = 12;

            bookList.Columns[0].HeaderText = "ID";
            bookList.Columns[1].HeaderText = "ISBN";
            bookList.Columns[2].HeaderText = "Book's Title";
            bookList.Columns[3].HeaderText = "Page Count";
            bookList.Columns[4].HeaderText = "Author";
            bookList.Columns[5].HeaderText = "Genre";
            bookList.Columns[6].HeaderText = "Publisher";
            bookList.Columns[7].HeaderText = "Published Date";
            bookList.Columns[8].HeaderText = "Quantity";
            bookList.Columns[9].HeaderText = "AuthorID";
            bookList.Columns[10].HeaderText = "GenreID";
            bookList.Columns[11].HeaderText = "PublisherID";

            bookList.Columns[0].Visible = false;
            bookList.Columns[9].Visible = false;
            bookList.Columns[10].Visible = false;
            bookList.Columns[11].Visible = false;

            bookList.Columns[0].DataPropertyName = "bookID";
            bookList.Columns[1].DataPropertyName = "ISBN";
            bookList.Columns[2].DataPropertyName = "bookTitle";
            bookList.Columns[3].DataPropertyName = "bookPageCount";
            bookList.Columns[4].DataPropertyName = "authorName";
            bookList.Columns[5].DataPropertyName = "genreName";
            bookList.Columns[6].DataPropertyName = "publisherName";
            bookList.Columns[7].DataPropertyName = "bookPublishDate";
            bookList.Columns[8].DataPropertyName = "bookQuantity";
            bookList.Columns[9].DataPropertyName = "bookAuthorID";
            bookList.Columns[10].DataPropertyName = "bookGenreID";
            bookList.Columns[11].DataPropertyName = "bookPublisherID";
        }

        private bool IsDateControl(string txtDate)
        {
            DateTime tempDate;

            return DateTime.TryParse(txtDate, out tempDate) ? true : false;
        }

        private void btnISBN_Click(object sender, EventArgs e)
        {
            String searchText = txtISBN.Text;
            RefreshList(false);
            if(lblBookID.Text == "0")
            {                
                bookList.DataSource = db.BookDataSearch("ISBN", searchText);
                bookList.ClearSelection();
                txtISBN.Text = searchText;
                if (bookList.RowCount == 0)
                    msg.NotFindItem();
            }            
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            String searchText = txtTitle.Text;
            RefreshList(false);
            if (lblBookID.Text == "0")
            {
                bookList.DataSource = db.BookDataSearch("bookTitle", searchText);
                bookList.ClearSelection();
                txtTitle.Text = searchText;
                if (bookList.RowCount == 0)
                    msg.NotFindItem();
            }                
        }

        private void bookList_DoubleClick(object sender, EventArgs e)
        {
            if (bookList.CurrentRow.Cells[1].Value.ToString() != "")
            {
                frmCirculation fCirc = new frmCirculation();
                fCirc.BookID = Convert.ToInt32(bookList.CurrentRow.Cells[0].Value);
                this.Close();
                fCirc.Dispose();
            }
        }
    }
}
