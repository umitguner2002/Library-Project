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
    public partial class frmMember : Form
    {
        MYDB db = new MYDB();
        MYMSG msg = new MYMSG();
        TitleBarAction tBarAct = new TitleBarAction();
        private int editMode = 0;

        public frmMember()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {            
            RefreshList();
            StateControl(true);
            editMode = 0;
            txtTCNo.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtTCNo.Text != "")
            {
                if(editMode == 0)
                {
                    if(db.AddMember(txtTCNo.Text, txtName.Text, txtSurname.Text, lblGender.Text, txtBirthDate.Value, txtPhone.Text, txtEMail.Text, txtAddress.Text))
                    {
                        memberList.DataSource = db.MemberDataSearch(txtTCNo.Text);
                        lblMemberID.Text = memberList.CurrentRow.Cells[0].Value.ToString();
                        editMode = 0;
                        StateControl(false);                          
                    }
                    else
                    {
                        StateControl(true);
                        txtTCNo.Focus();
                        txtTCNo.SelectAll();
                    }
                }
                else
                {
                    int index = Convert.ToInt32(lblMemberID.Text);

                    if (index > 0)
                    {
                        db.EditMember(index, txtTCNo.Text, txtName.Text, txtSurname.Text, lblGender.Text, txtBirthDate.Value, txtPhone.Text, txtEMail.Text, txtAddress.Text);
                        memberList.DataSource = db.MemberDataSearch(txtTCNo.Text);
                        lblMemberID.Text = memberList.CurrentRow.Cells[0].Value.ToString();
                        editMode = 0;
                        StateControl(false);
                    }
                    else
                        msg.SelectItem();
                }                
            }
            else
            {
                MessageBox.Show("T.C.No Value is not empty.", "T.C.No Value Empty Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTCNo.Focus();
            }            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lblMemberID.Text != "0")
            {
                StateControl(true);
                editMode = 1;
                txtTCNo.Enabled = false;
            }
            else
                msg.SelectItem();                        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lblMemberID.Text);

            if (index > 0)
            {
                int result = db.DeleteMember(index);
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
            memberList.DataSource = db.MemberDataSearch(txtTCNo.Text);
            lblMemberID.Text = "0";
            memberList.ClearSelection();
            if (memberList.RowCount == 0)
                msg.NotFindItem();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshList()
        {
            memberList.DataSource = db.MemberList();
            memberList.ClearSelection();
            lblMemberID.Text = "0";
            txtTCNo.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            rdbMale.Checked = true;
            lblGender.Text = "Male";
            txtBirthDate.Value = DateTime.Now;
            txtPhone.Text = "";
            txtEMail.Text = "";
            txtAddress.Text = "";
        }

        private void StateControl(bool state)
        {
            if(state)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnList.Enabled = false;
                btnNew.Enabled = false;
                btnSearch.Enabled = false;
                memberList.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                if (editMode == 0)
                {
                    txtTCNo.Enabled = true;
                    panel2.BackColor = Color.DarkKhaki;
                }
                    
                else
                {
                    txtTCNo.Enabled = false;
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
                memberList.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                panel2.BackColor = Color.DarkSeaGreen;
            }            
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            lblGender.Text = "Male";
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            lblGender.Text = "Female";
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            RefreshList();
            StateControl(false);
        }

        private void memberList_Click(object sender, EventArgs e)
        {
            lblMemberID.Text = memberList.CurrentRow.Cells[0].Value.ToString();
            txtTCNo.Text = memberList.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = memberList.CurrentRow.Cells[2].Value.ToString();
            txtSurname.Text = memberList.CurrentRow.Cells[3].Value.ToString();

            if (memberList.CurrentRow.Cells[4].Value.ToString() == "Male")
                rdbMale.Checked = true;
            else
                rdbFemale.Checked = true;       

            txtBirthDate.Text = memberList.CurrentRow.Cells[5].Value.ToString();
            txtPhone.Text = memberList.CurrentRow.Cells[6].Value.ToString();
            txtEMail.Text = memberList.CurrentRow.Cells[7].Value.ToString();
            txtAddress.Text = memberList.CurrentRow.Cells[8].Value.ToString();
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
                            case 6 :
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

        private void memberList_DoubleClick(object sender, EventArgs e)
        {
            if (memberList.CurrentRow.Cells[1].Value.ToString() != "")
            {
                frmCirculation fCirc = new frmCirculation();
                fCirc.MemberID = Convert.ToInt32(memberList.CurrentRow.Cells[0].Value);
                this.Close();
                fCirc.Dispose();
            }
        }
    }
}
