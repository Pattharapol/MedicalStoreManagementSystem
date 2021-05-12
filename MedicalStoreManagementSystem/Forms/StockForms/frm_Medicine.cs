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
    public partial class frm_Medicine : Form
    {
        public frm_Medicine()
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
            if (CommonCodeClass.GetAllCategory().Rows.Count > 0)
            {
                foreach (DataRow item in CommonCodeClass.GetAllCategory().Rows)
                {
                    cmbCategoryList.Items.Add(item[0]);
                }
            }

            cmbCategoryList.SelectedIndex = 0;
        }

        private void FillGrid(string value)
        {
            dgvMedicineList.Rows.Clear();
            DataTable dt = new DataTable();
            string sql = "";
            if (value == "")
            {
                sql = "SELECT * FROM Medicines";
            }
            else
            {
                sql = string.Format(@"SELECT * FROM Medicines WHERE med_Name LIKE '%{0}%' ", value);
            }
            dt = DataAccessLayer.Retreiving(sql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow addRow = new DataGridViewRow();
                    addRow.CreateCells(dgvMedicineList);
                    addRow.Cells[0].Value = row[0].ToString();
                    addRow.Cells[1].Value = row[2].ToString();
                    addRow.Cells[2].Value = CommonCodeClass.GetCategoryName(row[1].ToString());
                    addRow.Cells[3].Value = row[3].ToString();
                    addRow.Cells[4].Value = row[4].ToString();
                    dgvMedicineList.Rows.Add(addRow);
                }
            }
        }

        private void ClearForm()
        {
            cmbCategoryList.SelectedIndex = 0;
            txtMedicineName.Text = "";
            txtDescription.Text = "";
            txtSearch.Text = "";
            txtUserFOr.Text = "";

        }

        private void EnableComponent()
        {
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            dgvMedicineList.Enabled = false;
            txtSearch.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void DisableComponent()
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            dgvMedicineList.Enabled = true;
            txtSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbCategoryList.SelectedIndex == 0)
            {
                ep.SetError(cmbCategoryList, "Please Select Category Name");
                cmbCategoryList.Focus();
                return;
            }
            if (txtMedicineName.Text.Trim().Length == 0)
            {
                ep.SetError(txtMedicineName, "Please Enter Medicine Name");
                txtMedicineName.Focus();
                txtMedicineName.SelectAll();
                return;
            }
            if (txtUserFOr.Text.Trim().Length == 0)
            {
                ep.SetError(txtUserFOr, "Please Enter Using Detail of Product");
                txtUserFOr.Focus();
                txtUserFOr.SelectAll();
                return;
            }

            string sql = string.Format(@"INSERT INTO Medicines (categoryID, med_Name, usefor, description) VALUES ('{0}', '{1}', '{2}', '{3}')", CommonCodeClass.GetCategoryID(cmbCategoryList.Text.Trim()), txtMedicineName.Text, txtUserFOr.Text, txtDescription.Text);
            DataAccessLayer.Execute(sql);
            MessageBox.Show("Medicine Product Successfully Added...");
            FillGrid("");
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMedicineList.Rows.Count > 0)
            {
                if (dgvMedicineList.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Are u sure u want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataAccessLayer.Execute(string.Format(@"DELETE FROM Medicines WHERE medID = '{0}'", dgvMedicineList.CurrentRow.Cells[0].Value.ToString()));
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


        private string updateMedicineID;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMedicineList.Rows.Count > 0)
            {
                if (dgvMedicineList.SelectedRows.Count == 1)
                {
                    updateMedicineID = dgvMedicineList.CurrentRow.Cells[0].Value.ToString();
                    txtMedicineName.Text = dgvMedicineList.CurrentRow.Cells[1].Value.ToString();
                    cmbCategoryList.Text = dgvMedicineList.CurrentRow.Cells[2].Value.ToString();
                    txtUserFOr.Text = dgvMedicineList.CurrentRow.Cells[4].Value.ToString();
                    txtDescription.Text = dgvMedicineList.CurrentRow.Cells[4].Value.ToString();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbCategoryList.SelectedIndex == 0)
            {
                ep.SetError(cmbCategoryList, "Please Select Category Name");
                cmbCategoryList.Focus();
                return;
            }
            if (txtMedicineName.Text.Trim().Length == 0)
            {
                ep.SetError(txtMedicineName, "Please Enter Medicine Name");
                txtMedicineName.Focus();
                txtMedicineName.SelectAll();
                return;
            }
            if (txtUserFOr.Text.Trim().Length == 0)
            {
                ep.SetError(txtUserFOr, "Please Enter Using Detail of Product");
                txtUserFOr.Focus();
                txtUserFOr.SelectAll();
                return;
            }

            string sql = string.Format(@"UPDATE Medicines SET categoryID = '{0}', med_Name='{1}', usefor='{2}', description='{3}' WHERE medID = '{4}'", CommonCodeClass.GetCategoryID(cmbCategoryList.Text.Trim()), txtMedicineName.Text, txtUserFOr.Text, txtDescription.Text, updateMedicineID);
            DataAccessLayer.Execute(sql);
            MessageBox.Show("Medicines Successfully Updated...");
            btnCancel_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableComponent();
            ClearForm();
            FillGrid("");
        }
    }
}
