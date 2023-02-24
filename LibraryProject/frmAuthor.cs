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
    public partial class frmAuthor : Form
    {
        MYDB db = new MYDB();
        MYMSG msg = new MYMSG();
        TitleBarAction tBarAct = new TitleBarAction();
        

        public frmAuthor()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.AddAuthor(txtAuthorName.Text,txtAuthorCountry.Text);
            authorList.DataSource = db.AuthorDataSearch(txtAuthorName.Text);
            lblAuthorID.Text = authorList.CurrentRow.Cells[0].Value.ToString();
        }

        private void frmAuthor_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void authorList_Click(object sender, EventArgs e)
        {
            lblAuthorID.Text = authorList.CurrentRow.Cells[0].Value.ToString();
            txtAuthorName.Text = authorList.CurrentRow.Cells[1].Value.ToString();
            txtAuthorCountry.Text = authorList.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lblAuthorID.Text);

            if (index > 0)
            {
                db.EditAuthor(index, txtAuthorName.Text, txtAuthorCountry.Text);
                authorList.DataSource = db.AuthorDataSearch(txtAuthorName.Text);
                lblAuthorID.Text = authorList.CurrentRow.Cells[0].Value.ToString();
            }
            else
                msg.SelectItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lblAuthorID.Text);

            if (index > 0)
            {
                int result = db.DeleteAuthor(index);
                if (result == 1)
                {
                    authorList.DataSource = db.AuthorList();
                    authorList.ClearSelection();
                    txtAuthorName.Text = "";
                    txtAuthorCountry.Text = "";
                }
            }
            else
                msg.SelectItem();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtAuthorCountry.Text = "";
            authorList.DataSource = db.AuthorDataSearch(txtAuthorName.Text);
            lblAuthorID.Text = "0";
            authorList.ClearSelection();
            if (authorList.RowCount == 0)
                msg.NotFindItem();        
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void authorList_DoubleClick(object sender, EventArgs e)
        {
            if(authorList.CurrentRow.Cells[1].Value.ToString() != "")
            {
                frmBooks.authorID = Convert.ToInt32(authorList.CurrentRow.Cells[0].Value);
                frmBooks.authorName = authorList.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }                    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            tBarAct.MouseDown(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            tBarAct.MouseMove(MousePosition.X, MousePosition.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            tBarAct.MouseUp();
        }

        private void RefreshList()
        {
            authorList.DataSource = db.AuthorList();
            authorList.ClearSelection();
            lblAuthorID.Text = "0";
            txtAuthorName.Text = "";
            txtAuthorCountry.Text = "";
            txtAuthorName.Focus();            
        }
    }
}
