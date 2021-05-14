using MedicalStoreManagementSystem.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreManagementSystem.Forms.AuthenticationForms
{
    public partial class frm_UserCreateUpdateForm : Form
    {
        public frm_UserCreateUpdateForm(string CreateUpdateUser)
        {
            InitializeComponent();
            if(CreateUpdateUser == "Create")
            {
                NewUser();
            }
            if (CreateUpdateUser == "Update")
            {
                UpdateUser();
            }
            cmbUserType.SelectedIndex = 0;
        }

        private void NewUser()
        {
            this.Text = "CREATE USER";
            lblHeader.Text = "Create New User";
            lblNewPassword.Text = "Enter Password";
            btnSignUp.Text = "Create User";
            lblUserName.Text = "New UserName";
            btnSearch.Enabled = false;
            lblOldPassword.Enabled = false;
            txtOldPassword.Enabled = false;
        }

        private void UpdateUser()
        {
            this.Text = "UPDATE USER";
            lblHeader.Text = "Update User";
            lblNewPassword.Text = "New Password";
            btnSignUp.Text = "Update User";
            lblUserName.Text = "Enter User";
            btnSearch.Enabled = true;
            lblOldPassword.Enabled = true;
            txtOldPassword.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbUserType.SelectedIndex == 0)
            {
                ep.SetError(cmbUserType, "Please Select UserType");
                cmbUserType.Focus();
                return;
            }
            if (txtUsername.Text.Trim().Length == 0)
            {
                ep.SetError(txtUsername, "Please Enter Username");
                txtUsername.Focus();
                return;
            }
            if (this.Text == "UPDATE USER")
            {
                if (txtOldPassword.Text.Trim().Length == 0)
                {
                    ep.SetError(txtOldPassword, "Please Enter Old Password for verification...");
                    txtOldPassword.Focus();
                    txtOldPassword.SelectAll();
                    return;
                }
            }
            if (txtContactNo.Text.Trim().Length < 0)
            {
                ep.SetError(txtContactNo, "Please Enter Contact No");
                txtContactNo.Focus();
                txtContactNo.SelectAll();
                return;
            }
            if (txtNewPassword.Text.Trim().Length == 0)
            {
                if (this.Text == "UPDATE USER")
                {
                    ep.SetError(txtNewPassword, "Please ENter New Password");
                }
                else
                {
                    ep.SetError(txtNewPassword, "Please ENter User Password");
                }
                txtNewPassword.Focus();
                txtNewPassword.SelectAll();
                return;
            }
            if (txtConfirmPassword.Text.Trim().Length == 0)
            {
                ep.SetError(txtConfirmPassword, "Please Enter Confirm Password");
                txtConfirmPassword.Focus();
                txtConfirmPassword.SelectAll();
                return;
            }
            if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                ep.SetError(txtConfirmPassword, "Password doesn't match!!!");
                txtConfirmPassword.Focus();
                txtConfirmPassword.SelectAll();
                return;
            }

            if(this.Text == "CREATE USER")
            {
                string checkingQuery = string.Format(@"SELECT * FROM Users WHERE userName = '{0}'", txtUsername.Text);
                DataTable ChkDt = new DataTable();
                ChkDt = DataAccessLayer.Retreiving(checkingQuery);
                if (ChkDt.Rows.Count > 0)
                {
                    ep.SetError(txtUsername, "Username is already Registered!");
                    txtUsername.Focus();
                    txtUsername.SelectAll();
                    return;
                }

                string createQuery = string.Format(@"INSERT INTO Users (userType, userName, contactNo, password) VALUES ('{0}', '{1}', '{2}', '{3}')", cmbUserType.Text, txtUsername.Text, txtContactNo.Text, txtNewPassword.Text);
                DataAccessLayer.Execute(createQuery);
                MessageBox.Show("User created successfully");
            }
            else
            {
                if(txtOldPassword.Text.Trim() != password.Trim())
                {
                    ep.SetError(txtOldPassword, "Password is incorrect Please ENter correct Username and Password");
                    txtOldPassword.Focus();
                    txtOldPassword.SelectAll();
                    return;
                }
                string updateQuery = string.Format(@"UPDATE Users SET userType = '{0}', userName = '{1}', contactNo = '{2}', password = '{3}' WHERE userID = '{4}'", cmbUserType.Text, txtUsername.Text, txtContactNo.Text, txtNewPassword.Text, userID);
                DataAccessLayer.Execute(updateQuery);
                MessageBox.Show("User updated successfully");
            }

            this.Close();
        }


        private string password, userID;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Enter Username");
                txtUsername.Focus();
                return;
            }
            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreiving(string.Format(@"SELECT userID, userType, contactNo, password FROM Users WHERE userName = '"+txtUsername.Text.Trim()+"' "));
            if(dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    userID = row[0].ToString();
                    cmbUserType.Text = row[1].ToString();
                    txtContactNo.Text = row[2].ToString();
                    password = row[3].ToString();
                    break;
                }
            }
            else
            {
                MessageBox.Show("User not found!!!");
            }
        }
    }
}
