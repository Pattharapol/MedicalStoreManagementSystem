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
    public partial class frm_UserLoginForm2 : Form
    {
        public frm_UserLoginForm2()
        {
            InitializeComponent();
            cmbUserType.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // เอาไว้นับ 3
        int count = 1;
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbUserType.SelectedIndex == 0)
            {
                ep.SetError(cmbUserType, "Please Select User Type");
                cmbUserType.Focus();
                return;
            }

            if (txtUsername.Text.Trim().Length == 0)
            {
                ep.SetError(txtUsername, "Please Enter Username");
                txtUsername.Focus();
                return;
            }

            if (txtPassword.Text.Trim().Length == 0)
            {
                ep.SetError(txtPassword, "Please Enter Password");
                txtPassword.Focus();
                return;
            }

            if (txtPassword.Text.Contains("OR") || txtPassword.Text.Contains("or") || txtPassword.Text.Contains("'") || txtPassword.Text.Contains("\""))
            {
                ep.SetError(txtPassword, "Please Contact Admin");
                MessageBox.Show("What are you doing? Please Contact Administrator immediatly...","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            DataTable dt = new DataTable();
            string sql = string.Format(@"SELECT * FROM Users WHERE userType = '{0}' AND userName = '{1}'  AND password = '{2}'", cmbUserType.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text.Trim());
            dt = DataAccessLayer.Retreiving(sql);
            if (dt.Rows.Count == 1)
            {
                if (cmbUserType.SelectedIndex == 1)
                {
                    frm_MainForm frm = new frm_MainForm(true, this);
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    frm_MainForm frm = new frm_MainForm(false, this);
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Not OK : " + count);
                if (count == 3)
                {
                    Application.Exit();
                }
                else
                {
                    count += 1;
                }
            }

            
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
