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

namespace MedicalStoreManagementSystem.Forms.StockForms
{
    public partial class frm_StockGeneral : Form
    {

        private string updateGeneralID;

        public frm_StockGeneral()
        {
            InitializeComponent();
            FillGrid(string.Empty);
            FillCmbCategoryList();
            DisableComponent();
        }

        private void FillCmbCategoryList()
        {
            cmbCategoryList.Items.Clear();
            cmbCategoryList.Items.Add("Select Category");
            if(CommonCodeClass.GetAllCategory().Rows.Count > 0)
            {
                foreach(DataRow item in CommonCodeClass.GetAllCategory().Rows)
                {
                    cmbCategoryList.Items.Add(item[0]);
                }
            }

            cmbCategoryList.SelectedIndex = 0;
        }

        private void FillGrid(string value)
        {
            dgvGeneralList.Rows.Clear();
            DataTable dt = new DataTable();
            string sql = "";
            if(value == "")
            {
                sql = "SELECT * FROM General";
            }
            else
            {
                sql = string.Format(@"SELECT * FROM General WHERE gen_Name LIKE '%{0}%' ", value);
            }
            dt = DataAccessLayer.Retreiving(sql);
            if(dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    DataGridViewRow addRow = new DataGridViewRow();
                    addRow.CreateCells(dgvGeneralList);
                    addRow.Cells[0].Value = row[0].ToString();
                    addRow.Cells[1].Value = row[2].ToString();
                    addRow.Cells[2].Value = CommonCodeClass.GetCategoryName(row[1].ToString());
                    addRow.Cells[3].Value = row[3].ToString();
                    addRow.Cells[4].Value = row[4].ToString();
                    dgvGeneralList.Rows.Add(addRow);
                }
            }
        }

        private void ClearForm()
        {
            cmbCategoryList.SelectedIndex = 0;
            txtGeneralName.Text = "";
            txtDescription.Text = "";
            txtSearch.Text = "";
            txtUserFOr.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvGeneralList.Rows.Count > 0)
            {
                if(dgvGeneralList.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Are u sure u want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataAccessLayer.Execute(string.Format(@"DELETE FROM General WHERE gen_ID = '{0}'", dgvGeneralList.CurrentRow.Cells[0].Value.ToString()));
                        FillGrid("");
                        MessageBox.Show("Deleted Complete");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please Select One Row U want to DELETE...");
                    return;
                }
            }
            else
            {
                MessageBox.Show("General List is EMPTY...");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(cmbCategoryList.SelectedIndex == 0)
            {
                ep.SetError(cmbCategoryList, "Please Select Category Name");
                cmbCategoryList.Focus();
                return;
            }
            if(txtGeneralName.Text.Trim().Length == 0)
            {
                ep.SetError(txtGeneralName, "Please Enter General Name");
                txtGeneralName.Focus();
                txtGeneralName.SelectAll();
                return;
            }
            if (txtUserFOr.Text.Trim().Length == 0)
            {
                ep.SetError(txtUserFOr, "Please Enter Using Detail of Product");
                txtUserFOr.Focus();
                txtUserFOr.SelectAll();
                return;
            }

            string sql = string.Format(@"INSERT INTO General (categoryID, gen_Name, usefor, description) VALUES ('{0}', '{1}', '{2}', '{3}')", CommonCodeClass.GetCategoryID(cmbCategoryList.Text.Trim()), txtGeneralName.Text, txtUserFOr.Text, txtDescription.Text);
            DataAccessLayer.Execute(sql);
            MessageBox.Show("General Product Successfully Added...");
            FillGrid("");
            ClearForm();
        }

        private void EnableComponent()
        {
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            dgvGeneralList.Enabled = false;
            txtSearch.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void DisableComponent()
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            dgvGeneralList.Enabled = true;
            txtSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableComponent();
            ClearForm();
            FillGrid("");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbCategoryList.SelectedIndex == 0)
            {
                ep.SetError(cmbCategoryList, "Please Select Category Name");
                cmbCategoryList.Focus();
                return;
            }
            if (txtGeneralName.Text.Trim().Length == 0)
            {
                ep.SetError(txtGeneralName, "Please Enter General Name");
                txtGeneralName.Focus();
                txtGeneralName.SelectAll();
                return;
            }
            if (txtUserFOr.Text.Trim().Length == 0)
            {
                ep.SetError(txtUserFOr, "Please Enter Using Detail of Product");
                txtUserFOr.Focus();
                txtUserFOr.SelectAll();
                return;
            }

            string sql = string.Format(@"UPDATE General SET categoryID = '{0}', gen_Name='{1}', usefor='{2}', description='{3}' WHERE gen_ID = '{4}'", CommonCodeClass.GetCategoryID(cmbCategoryList.Text.Trim()), txtGeneralName.Text, txtUserFOr.Text, txtDescription.Text, updateGeneralID);
            DataAccessLayer.Execute(sql);
            MessageBox.Show("General Product Successfully Updated...");
            btnCancel_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvGeneralList.Rows.Count > 0)
            {
                if (dgvGeneralList.SelectedRows.Count == 1)
                {
                    updateGeneralID = dgvGeneralList.CurrentRow.Cells[0].Value.ToString();
                    txtGeneralName.Text = dgvGeneralList.CurrentRow.Cells[1].Value.ToString();
                    cmbCategoryList.Text = dgvGeneralList.CurrentRow.Cells[2].Value.ToString();
                    txtUserFOr.Text = dgvGeneralList.CurrentRow.Cells[4].Value.ToString();
                    txtDescription.Text = dgvGeneralList.CurrentRow.Cells[4].Value.ToString();
                    EnableComponent();
                }
                else
                {
                    MessageBox.Show("Please Select One Row U want to DELETE...");
                    return;
                }
            }
            else
            {
                MessageBox.Show("General List is EMPTY...");
            }
        }
    }
}
