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
using Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;

namespace LibraryProject
{
    public partial class frmMain : Form
    {
        public String userLabel = "";

        MYDB db = new MYDB();
        TitleBarAction tBarAct = new TitleBarAction();

        frmGenre fGenre;
        frmAuthor fAuthor;
        frmPublisher fPublisher;
        frmMember fMember;
        frmBooks fBooks;
        frmCirculation fCirculation;
        frmUser fUser;
        frmExcelExporting fExcelExp;



        public frmMain()
        {
            InitializeComponent();
        }
        

        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = userLabel;
            comboBox1.SelectedIndex = 0;
            addListsColumn();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            lblNumberOfUsers.Text = db.UserDataCount().ToString();
            lblNumberOfGenres.Text = db.GenreDataCount().ToString();
            lblNumberOfAuthors.Text = db.AuthorDataCount().ToString();
            lblNumberOfPublishers.Text = db.PublisherDataCount().ToString();
            lblNumberOfMembers.Text = db.MemberDataCount().ToString();
            lblNumberOfBooks.Text = db.BookDataCount().ToString();
            
            listMostMembers.DataSource = db.MembersBorrowed();
            listMostBooks.DataSource = db.BooksBorrowed();           

            this.Opacity = 1;
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.25;
            fAuthor = new frmAuthor();
            fAuthor.ShowDialog();
        }

        private void btnPublishers_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.25;
            fPublisher = new frmPublisher();
            fPublisher.ShowDialog();
        }

        private void btnGenres_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.25;
            fGenre = new frmGenre();
            fGenre.ShowDialog();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.25;
            fMember = new frmMember();
            fMember.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.25;
            fUser = new frmUser();
            fUser.ShowDialog();            
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.25;
            fBooks = new frmBooks();
            fBooks.ShowDialog();
        }

        private void btnCirculation_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.25;
            fCirculation = new frmCirculation();
            fCirculation.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            tBarAct.MouseDown(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            tBarAct.MouseUp();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            tBarAct.MouseMove(MousePosition.X, MousePosition.Y);
        }

        private void addListsColumn()
        {
            //
            // MEMBERS - BORROWED
            listMostMembers.ColumnCount = 2;
            listMostMembers.Columns[0].HeaderText = "Name";
            listMostMembers.Columns[1].HeaderText = "Count";
            listMostMembers.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            listMostMembers.Columns[0].DataPropertyName = "NameSurname";
            listMostMembers.Columns[1].DataPropertyName = "NumberOfMember";

            //
            // BOOKS - BORROWED
            listMostBooks.ColumnCount = 2;
            listMostBooks.Columns[0].HeaderText = "Title";
            listMostBooks.Columns[1].HeaderText = "Count";
            listMostBooks.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            listMostBooks.Columns[0].DataPropertyName = "bookTitle";
            listMostBooks.Columns[1].DataPropertyName = "NumberOfBook";
        }

        private void btnBooksExcel_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            fExcelExp = new frmExcelExporting();
            fExcelExp.Show();
            

            excel.Application app = new excel.Application();            
            Workbook wBook = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet wSheet = (Worksheet)wBook.Sheets[1];           
            
            System.Data.DataTable dt = new System.Data.DataTable();

            int indexDB = comboBox1.SelectedIndex;            

            switch (indexDB)
            {
                case 0:
                    dt = db.AuthorExcelList();
                    break;

                case 1:
                    dt = db.BookExcelList();
                    break;

                case 2:
                    dt = db.GenreExcelList();
                    break;

                case 3:
                    dt = db.MemberExcelList();
                    break;

                case 4:
                    dt = db.PublisherExcelList();
                    break;

                case 5:
                    dt = db.UserExcelList();
                    break;

                default:
                    break;
            }

            int startCol = 1;
            int startRow = 1;
            int columnCount = dt.Columns.Count;
            int rowCount = dt.Rows.Count;            

            for (int i=0; i< columnCount; i++) 
            {
                excel.Range range = (excel.Range) wSheet.Cells[startRow, startCol];
                range.Cells[startRow, startCol + i] = dt.Columns[i].ColumnName;
                range.Cells[startRow, startCol + i].Font.Bold = true;
                range.Cells[startRow, startCol + i].Font.Color = excel.XlRgbColor.rgbWhite;
                range.Cells[startRow, startCol + i].Interior.Color = excel.XlRgbColor.rgbDarkOliveGreen;
                range.Cells[startRow, startCol + i].Borders.LineStyle = excel.XlLineStyle.xlContinuous;
            }

            startRow++;

            for (int j=0; j< rowCount; j++)
            {
                for (int k = 0; k < columnCount; k++)
                {
                    excel.Range range2 = (excel.Range)wSheet.Cells[startRow + j, startCol + k];
                    if ((j % 2) == 1)
                        range2.Cells[startRow - 1, startCol].Interior.Color = excel.XlRgbColor.rgbDarkSeaGreen;
                    range2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    range2.Value = dt.Rows[j][k].ToString();                    
                 }
             }


            fExcelExp.Close();
            app.Columns.AutoFit();
            app.Visible = true;
            this.Opacity = 1;

        }

    }
}
