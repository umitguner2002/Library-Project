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
    public partial class frmCirculation : Form
    {
        MYDB db = new MYDB();
        MYMSG msg = new MYMSG();
        frmBooks fBooks;
        frmMember fMember;

        DataTable dt;

        public static int bookID = 0;
        private static int memberID = 0;

        public frmCirculation()
        {
            InitializeComponent();
        }

        private void frmCirculation_Load(object sender, EventArgs e)
        {
            ClearText();
            addBorrowListColumn();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            ClearText();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            pnlBorrow1.Enabled = false;
            pnlReturn1.Enabled = true;
            pnlSearch.Enabled = true;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            ClearText();
            radioButton1.Checked = false;
            radioButton2.Checked = true;
            pnlBorrow1.Enabled = true;
            pnlReturn1.Enabled = false;
            pnlSearch.Enabled = false;
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            fBooks = new frmBooks();
            fBooks.ShowDialog();
            
            lblBorrowBookID.Text = bookID.ToString();
            
            if(bookID > 0)
            {
                dt = new DataTable();
                dt = db.BookDataSearch("bookID", bookID.ToString());

                txtBorrowBook.Text = dt.Rows[0]["bookTitle"].ToString();

                lblISBN.Text = dt.Rows[0]["ISBN"].ToString();
                lblTitle.Text = dt.Rows[0]["bookTitle"].ToString();
                lblAuthor.Text = dt.Rows[0]["authorName"].ToString();
                lblGenre.Text = dt.Rows[0]["genreName"].ToString();
                lblPublisher.Text = dt.Rows[0]["publisherName"].ToString();
                lblPublishDate.Text = dt.Rows[0]["bookPublishDate"].ToString();
                lblPageCount.Text = dt.Rows[0]["bookPageCount"].ToString();
                lblQuantity.Text = dt.Rows[0]["bookQuantity"].ToString();
            }            
        }

        private void btnBorrowMember_Click(object sender, EventArgs e)
        {
            fMember = new frmMember();
            fMember.ShowDialog();            

            if (memberID != 0)
            {
                dt = new DataTable();
                dt = db.MemberDataSearch(memberID);

                txtBorrowMember.Text = dt.Rows[0]["name"].ToString();

                lblBorrowMemberID.Text = dt.Rows[0]["memberID"].ToString();                
                lblTCNo.Text = dt.Rows[0]["memberTCNo"].ToString();
                lblName.Text = dt.Rows[0]["name"].ToString();
                lblGender.Text = dt.Rows[0]["memberGender"].ToString();
                lblPhone.Text = dt.Rows[0]["memberPhone"].ToString();
                lblEMail.Text = dt.Rows[0]["memberEMail"].ToString();
                lblAddress.Text = dt.Rows[0]["memberAddress"].ToString();
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (db.AddBorrow(Convert.ToInt32(lblBorrowBookID.Text), Convert.ToInt32(lblBorrowMemberID.Text), dateTimePicker1.Value, dateTimePicker2.Value, txtBorrowNote.Text))
                ClearText();
            else
            {
                msg.DataNotSave();
                btnBorrowBook.Focus();
            }                
        }

        private void ClearText()
        {
            //
            // BORROW
            txtBorrowBook.Text = "";
            lblBorrowBookID.Text = "0";
            txtBorrowMember.Text = "";
            txtBorrowNote.Text = "";
            lblBorrowMemberID.Text = "0";

            txtReturnBook.Text = "";
            txtReturnMember.Text = "";
            txtBorrowNote.Text = "";

            lblISBN.Text = "-";
            lblTitle.Text = "-";
            lblAuthor.Text = "-";
            lblGenre.Text = "-";
            lblPublisher.Text = "-";
            lblPublishDate.Text = "-";
            lblPageCount.Text = "-";
            lblQuantity.Text = "-";
            lblTCNo.Text = "-";
            lblName.Text = "-";
            lblGender.Text = "-";
            lblPhone.Text = "-";
            lblEMail.Text = "-";
            lblAddress.Text = "-";
            lblNumberDays.Text = "-";
            lblStatus.Text = "-";

            //
            // DATE
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker4.Value = DateTime.Now;

            //comboBox1.SelectedIndex = 0;
            //comboBox2.SelectedIndex = 0;
            //txtSearch.Text = "";
        }

        private void addBorrowListColumn()
        {
            borrowSearchList.ColumnCount = 9;

            borrowSearchList.Columns[0].HeaderText = "ID";
            borrowSearchList.Columns[1].HeaderText = "Book's Title";
            borrowSearchList.Columns[2].HeaderText = "Member's Name";
            borrowSearchList.Columns[3].HeaderText = "Status";
            borrowSearchList.Columns[4].HeaderText = "Borrow Date";
            borrowSearchList.Columns[5].HeaderText = "Return Date";
            borrowSearchList.Columns[6].HeaderText = "Note";
            borrowSearchList.Columns[7].HeaderText = "bookID";
            borrowSearchList.Columns[8].HeaderText = "memberID";

            borrowSearchList.Columns[3].Visible = false;
            borrowSearchList.Columns[7].Visible = false;
            borrowSearchList.Columns[8].Visible = false;

            borrowSearchList.Columns[0].DataPropertyName = "ID";
            borrowSearchList.Columns[1].DataPropertyName = "bookTitle";
            borrowSearchList.Columns[2].DataPropertyName = "name";
            borrowSearchList.Columns[3].DataPropertyName = "status";
            borrowSearchList.Columns[4].DataPropertyName = "borrowDate";
            borrowSearchList.Columns[5].DataPropertyName = "returnDate";
            borrowSearchList.Columns[6].DataPropertyName = "note";
            borrowSearchList.Columns[7].DataPropertyName = "bookID";
            borrowSearchList.Columns[8].DataPropertyName = "memberID";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            borrowSearchList.DataSource = db.BorrowDataSearch(comboBox1.SelectedIndex, comboBox2.SelectedIndex, txtSearch.Text);
            borrowSearchList.ClearSelection();
        }

        private void dateTimePicker2_Leave(object sender, EventArgs e)
        {
            NumberOfDays(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void dateTimePicker4_Leave(object sender, EventArgs e)
        {
            NumberOfDays(dateTimePicker3.Value, dateTimePicker4.Value);
        }

        private void NumberOfDays(DateTime date1, DateTime date2)
        {
            TimeSpan numberDays = date2 - date1;

            if (numberDays.Days > 0)
                lblNumberDays.Text = numberDays.Days.ToString();
            else
            {
                MessageBox.Show("The return date cannot be an expired date.", "Expired Date Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker4.Focus();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(borrowSearchList.CurrentRow.Cells[3].Value))
            {
                db.ReturnBorrowed(Convert.ToInt32(txtBorrowID.Text), dateTimePicker4.Value, txtReturnNote.Text);
                borrowSearchList.DataSource = db.BorrowDataSearch(comboBox1.SelectedIndex, comboBox2.SelectedIndex, txtSearch.Text);
                borrowSearchList.ClearSelection();
            }
            else
                msg.UniqueReturned();
                
        }

        private void borrowSearchList_Click(object sender, EventArgs e)
        {
            ClearText();

            if (borrowSearchList.RowCount > 0)
            {
                txtBorrowID.Text = borrowSearchList.CurrentRow.Cells[0].Value.ToString();                
                
                if(Convert.ToBoolean(borrowSearchList.CurrentRow.Cells[3].Value))
                    lblStatus.Text = "BORROWED";
                else
                    lblStatus.Text = "RETURNED";

                dateTimePicker3.Value = Convert.ToDateTime(borrowSearchList.CurrentRow.Cells[4].Value);
                dateTimePicker4.Value = Convert.ToDateTime(borrowSearchList.CurrentRow.Cells[5].Value);
                txtReturnNote.Text = borrowSearchList.CurrentRow.Cells[6].Value.ToString();
                txtReturnBook.Text = borrowSearchList.CurrentRow.Cells[7].Value.ToString();
                txtReturnMember.Text = borrowSearchList.CurrentRow.Cells[8].Value.ToString();

                int bookID = Convert.ToInt32(borrowSearchList.CurrentRow.Cells[1].Value);
                int memberID = Convert.ToInt32(borrowSearchList.CurrentRow.Cells[2].Value);

                if (bookID > 0)
                {
                    dt = new DataTable();
                    dt = db.BookDataSearch("bookID", bookID.ToString());                    

                    lblISBN.Text = dt.Rows[0]["ISBN"].ToString();
                    lblTitle.Text = dt.Rows[0]["bookTitle"].ToString();
                    lblAuthor.Text = dt.Rows[0]["authorName"].ToString();
                    lblGenre.Text = dt.Rows[0]["genreName"].ToString();
                    lblPublisher.Text = dt.Rows[0]["publisherName"].ToString();
                    lblPublishDate.Text = dt.Rows[0]["bookPublishDate"].ToString();
                    lblPageCount.Text = dt.Rows[0]["bookPageCount"].ToString();
                    lblQuantity.Text = dt.Rows[0]["bookQuantity"].ToString();
                }

                if (memberID > 0)
                {
                    dt = new DataTable();
                    dt = db.MemberDataSearch(memberID);

                    lblTCNo.Text = dt.Rows[0]["memberTCNo"].ToString();
                    lblName.Text = dt.Rows[0]["name"].ToString();
                    lblGender.Text = dt.Rows[0]["memberGender"].ToString();
                    lblPhone.Text = dt.Rows[0]["memberPhone"].ToString();
                    lblEMail.Text = dt.Rows[0]["memberEMail"].ToString();
                    lblAddress.Text = dt.Rows[0]["memberAddress"].ToString();
                }

            }            
        }

        public int MemberID
        {
            get
            {
                return memberID;
            }
            set
            {
                memberID = value;
            }
        }

        public int BookID
        {
            get
            {
                return bookID;
            }
            set
            {
                bookID = value;
            }
        }

    }
}
