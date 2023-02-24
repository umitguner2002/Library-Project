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
    public partial class frmLogin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-12FASN2\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public frmLogin()
        {
            InitializeComponent();
        }        

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            lblWrongPass.Visible = false;            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
                btnLogin.Enabled = false;
            else
                btnLogin.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Username value cannot be empty !", "Library Project - Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password value cannot be empty !", "Library Project - Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("SELECT username,password FROM Users where username = @user AND password = @pass", conn);
                    cmd.Parameters.AddWithValue("@user", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        this.Hide();
                        frmMain fMain = new frmMain();
                        fMain.userLabel = txtUserName.Text;
                        fMain.Show();
                    }
                    else
                    {
                        lblWrongPass.Visible = true;
                        txtUserName.Focus();
                        txtUserName.SelectAll();
                    }
                    conn.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                    throw;
                }
            }           

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();           
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            txtUserName.SelectAll();            
        }
    }
}