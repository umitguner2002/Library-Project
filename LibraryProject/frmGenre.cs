using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryProject
{
    public partial class frmGenre : Form
    {
        MYDB db = new MYDB();
        MYMSG msg = new MYMSG();
        TitleBarAction tBarAct = new TitleBarAction();

        public frmGenre()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.AddGenre(txtGenreName.Text);
            genreList.DataSource = db.GenreDataSearch(txtGenreName.Text);
            lblGenreID.Text = genreList.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lblGenreID.Text);

            if (index > 0)
            {
                db.EditGenre(index, txtGenreName.Text);
                genreList.DataSource = db.GenreDataSearch(txtGenreName.Text);
                lblGenreID.Text = genreList.CurrentRow.Cells[0].Value.ToString();
            }
            else
                msg.SelectItem();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lblGenreID.Text);

            if (index > 0)
            {
                int result = db.DeleteGenre(index);
                if(result==1)
                {
                    genreList.DataSource = db.GenreList();
                    genreList.ClearSelection();
                    txtGenreName.Text = "";
                }                
            }
            else
                msg.SelectItem();            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            genreList.DataSource = db.GenreDataSearch(txtGenreName.Text);
            lblGenreID.Text = "0";
            genreList.ClearSelection();
            if (genreList.RowCount == 0)
                msg.NotFindItem();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void genreList_Click(object sender, EventArgs e)
        {
            lblGenreID.Text = genreList.CurrentRow.Cells[0].Value.ToString();
            txtGenreName.Text = genreList.CurrentRow.Cells[1].Value.ToString();
        }

        private void genreList_DoubleClick(object sender, EventArgs e)
        {
            if (genreList.CurrentRow.Cells[1].Value.ToString() != "")
            {
                frmBooks.genreID = Convert.ToInt32(genreList.CurrentRow.Cells[0].Value);
                frmBooks.genreName = genreList.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
        }       

        private void frmGenre_Load(object sender, EventArgs e)
        {
            RefreshList();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            tBarAct.MouseDown(e.X,e.Y);   
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
            genreList.DataSource = db.GenreList();
            genreList.ClearSelection();
            lblGenreID.Text = "0";
            txtGenreName.Text = "";
            txtGenreName.Focus();
        }
    }
}
