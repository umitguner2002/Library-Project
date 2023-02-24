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
    public partial class frmUser : Form
    {
        MYDB db = new MYDB();
        MYMSG msg = new MYMSG();
        TitleBarAction tBarAct = new TitleBarAction();
        private int editMode = 0;

        public frmUser()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            RefreshList();
            StateControl(true);
            editMode = 0;
            txtUsername.Focus();
        }

        private void RefreshList()
        {
            userList.DataSource = db.UserList();
            userList.ClearSelection();
            lblUserID.Text = "0";
            txtUsername.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            rdbMale.Checked = true;
            lblGender.Text = "Male";
            txtBirthDate.Text = "";
            txtPhone.Text = "";
            txtEMail.Text = "";
        }

        private void StateControl(bool state)
        {
            if (state)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnList.Enabled = false;
                btnNew.Enabled = false;
                btnSearch.Enabled = false;
                userList.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                if (editMode == 0)
                {
                    txtUsername.Enabled = true;
                    panel2.BackColor = Color.DarkKhaki;
                }

                else
                {
                    txtUsername.Enabled = false;
                    panel2.BackColor = Color.DarkSeaGreen;
                }

            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnList.Enabled = true;
                btnNew.Enabled = true;
                btnSearch.Enabled = true;
                userList.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                panel2.BackColor = Color.DarkSeaGreen;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                if (editMode == 0)
                {
                    if (db.AddUser(txtUsername.Text, txtPassword.Text, txtName.Text, txtSurname.Text, lblGender.Text, txtBirthDate.Value, txtPhone.Text, txtEMail.Text))
                    {
                        userList.DataSource = db.UserDataSearch(txtUsername.Text);
                        lblUserID.Text = userList.CurrentRow.Cells[0].Value.ToString();
                        editMode = 0;
                        StateControl(false);
                    }
                    else
                    {
                        StateControl(true);
                        txtUsername.Focus();
                        txtUsername.SelectAll();
                    }
                }
                else
                {
                    int index = Convert.ToInt32(lblUserID.Text);

                    if (index > 0)
                    {
                        db.EditUser(index, txtUsername.Text, txtPassword.Text, txtName.Text, txtSurname.Text, lblGender.Text, txtBirthDate.Value, txtPhone.Text, txtEMail.Text);
                        userList.DataSource = db.UserDataSearch(txtUsername.Text);
                        lblUserID.Text = userList.CurrentRow.Cells[0].Value.ToString();
                        editMode = 0;
                        StateControl(false);
                    }
                    else
                        msg.SelectItem();
                }
            }
            else
            {
                MessageBox.Show("Username Value is not empty.", "Username Value Empty Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lblUserID.Text != "0")
            {
                StateControl(true);
                editMode = 1;
                txtUsername.Enabled = false;
            }
            else
                msg.SelectItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lblUserID.Text);

            if (index > 0)
            {
                int result = db.DeleteUser(index);
                if (result == 1)
                    RefreshList();
            }
            else
                msg.SelectItem();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StateControl(false);
            editMode = 0;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            userList.DataSource = db.UserDataSearch(txtUsername.Text);
            lblUserID.Text = "0";
            userList.ClearSelection();
            if (userList.RowCount == 0)
                msg.NotFindItem();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            lblGender.Text = "Male";
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            lblGender.Text = "Female";
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            addBookListColumn();
            RefreshList();
            StateControl(false);
        }

        private void userList_Click(object sender, EventArgs e)
        {
            lblUserID.Text = userList.CurrentRow.Cells[0].Value.ToString();
            txtUsername.Text = userList.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = userList.CurrentRow.Cells[2].Value.ToString();
            

            if (userList.CurrentRow.Cells[4].Value.ToString() == "Male")
                rdbMale.Checked = true;
            else
                rdbFemale.Checked = true;

            txtBirthDate.Text = userList.CurrentRow.Cells[5].Value.ToString();
            txtPhone.Text = userList.CurrentRow.Cells[6].Value.ToString();
            txtEMail.Text = userList.CurrentRow.Cells[7].Value.ToString();
            txtName.Text = userList.CurrentRow.Cells[8].Value.ToString();
            txtSurname.Text = userList.CurrentRow.Cells[9].Value.ToString();
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            String phone = txtPhone.Text;
            String newPhone = "";

            if (txtPhone.Text != "")
            {
                if (phone.Length == 10)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                newPhone += "0(" + phone[i];
                                break;
                            case 3:
                                newPhone += ") " + phone[i];
                                break;
                            case 6:
                                newPhone += " " + phone[i];
                                break;
                            case 8:
                                newPhone += " " + phone[i];
                                break;
                            default:
                                newPhone += phone[i];
                                break;
                        }
                    }
                    txtPhone.Text = newPhone;
                }
                else
                {
                    MessageBox.Show("Wrong Phone Number Value! \n Please enter 10 characters.", "Phone Number Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    txtPhone.SelectAll();
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addBookListColumn()
        {
            userList.ColumnCount = 10;

            userList.Columns[0].HeaderText = "ID";
            userList.Columns[1].HeaderText = "Username";
            userList.Columns[2].HeaderText = "Password";
            userList.Columns[3].HeaderText = "Name-Surname";            
            userList.Columns[4].HeaderText = "Gender";
            userList.Columns[5].HeaderText = "Birth Date";
            userList.Columns[6].HeaderText = "Phone";
            userList.Columns[7].HeaderText = "E-Mail";
            userList.Columns[8].HeaderText = "Name";
            userList.Columns[9].HeaderText = "Surname";

            userList.Columns[2].Visible = false;
            userList.Columns[8].Visible = false;
            userList.Columns[9].Visible = false;

            userList.Columns[0].DataPropertyName = "id";
            userList.Columns[1].DataPropertyName = "username";
            userList.Columns[2].DataPropertyName = "password";
            userList.Columns[3].DataPropertyName = "NameSurname";
            userList.Columns[4].DataPropertyName = "gender";
            userList.Columns[5].DataPropertyName = "birthDate";
            userList.Columns[6].DataPropertyName = "phone";
            userList.Columns[7].DataPropertyName = "email";
            userList.Columns[8].DataPropertyName = "name";
            userList.Columns[9].DataPropertyName = "surname";
        }
    }
}
