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
    public partial class frmPublisher : Form
    {
        MYDB db = new MYDB();
        MYMSG msg = new MYMSG();
        TitleBarAction tBarAct = new TitleBarAction();

        public frmPublisher()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.AddPublisher(txtPublisherName.Text);
            publisherList.DataSource = db.PublisherDataSearch(txtPublisherName.Text);
            lblPublisherID.Text = publisherList.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lblPublisherID.Text);

            if (index > 0)
            {
                db.EditPublisher(index, txtPublisherName.Text);
                publisherList.DataSource = db.PublisherDataSearch(txtPublisherName.Text);
                lblPublisherID.Text = publisherList.CurrentRow.Cells[0].Value.ToString();
            }
            else
                msg.SelectItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lblPublisherID.Text);

            if (index > 0)
            {
                int result = db.DeletePublisher(index);
                if (result == 1)
                {
                    publisherList.DataSource = db.PublisherList();
                    publisherList.ClearSelection();
                    txtPublisherName.Text = "";
                }
            }
            else
                msg.SelectItem();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            publisherList.DataSource = db.PublisherDataSearch(txtPublisherName.Text);
            lblPublisherID.Text = "0";
            publisherList.ClearSelection();
            if (publisherList.RowCount == 0)
                msg.NotFindItem();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void publisherList_Click(object sender, EventArgs e)
        {
            lblPublisherID.Text = publisherList.CurrentRow.Cells[0].Value.ToString();
            txtPublisherName.Text = publisherList.CurrentRow.Cells[1].Value.ToString();
        }

        private void publisherList_DoubleClick(object sender, EventArgs e)
        {
            if (publisherList.CurrentRow.Cells[1].Value.ToString() != "")
            {
                frmBooks.publisherID = Convert.ToInt32(publisherList.CurrentRow.Cells[0].Value);
                frmBooks.publisherName = publisherList.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
        }

        private void frmPublisher_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshList()
        {            
            publisherList.DataSource = db.PublisherList();            
            publisherList.ClearSelection();
            lblPublisherID.Text = "0";
            txtPublisherName.Text = "";
            txtPublisherName.Focus();
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
    }
}
