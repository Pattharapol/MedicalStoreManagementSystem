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

namespace MedicalStoreManagementSystem.Forms.PurchaseForms
{
    public partial class frm_Supplier : Form
    {
        public frm_Supplier()
        {
            InitializeComponent();
            FillGrid(string.Empty);
        }

        private void FillGrid(string searchValue)
        {
            dgvSupplierLuist.Rows.Clear();
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(searchValue))
            {
                dt = DataAccessLayer.Retreiving("SELECT * FROM Suppliers");
                foreach (DataRow row in dt.Rows)
                {
                    dgvSupplierLuist.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                }
            }
            else
            {
                dt = DataAccessLayer.Retreiving("SELECT * FROM Suppliers WHERE Name LIKE '%"+searchValue+"%'");
                foreach (DataRow row in dt.Rows)
                {
                    dgvSupplierLuist.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                }
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim().Length == 0)
            {
                FillGrid(string.Empty);
            }
            else
            {
                FillGrid(txtSearch.Text.Trim());
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvSupplierLuist.Rows.Count > 0)
            {
                if(dgvSupplierLuist.SelectedRows.Count == 1)
                {
                    if(MessageBox.Show("U want to DELETE this?" + Environment.NewLine + dgvSupplierLuist.CurrentRow.Cells[1].Value.ToString() + " " + dgvSupplierLuist.CurrentRow.Cells[2].Value.ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataAccessLayer.Execute(string.Format(@"DELETE FROM Suppliers WHERE suppID = '{0}'", dgvSupplierLuist.CurrentRow.Cells[0].Value.ToString()));
                        MessageBox.Show("Supplier Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid(string.Empty);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select One Row", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Add New Supplier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(txtSupplierName.Text.Trim().Length == 0)
            {
                ep.SetError(txtSupplierName, "Please ENter Supplier");
                txtSupplierName.Focus();
                return;
            }
            if (txtContactNo.Text.Trim().Length == 0)
            {
                ep.SetError(txtContactNo, "Please ENter Supplier");
                txtContactNo.Focus();
                return;
            }

            string sql = string.Format(@"INSERT INTO Suppliers (Name, contactNo, address, description) VALUES ('{0}', '{1}', '{2}', '{3}')", txtSupplierName.Text, txtContactNo.Text, txtAddress.Text, txtDescription.Text);

            DataAccessLayer.Execute(sql);
            MessageBox.Show("Supplier Added Successfully");
            FillGrid(string.Empty);
            ClearForm();
        }

        private void ClearForm()
        {
            txtSupplierName.Clear();
            txtContactNo.Clear();
            txtAddress.Clear();
            txtDescription.Clear();
            txtSupplierName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ENableComponent()
        {
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            txtSearch.Enabled = false;
            dgvSupplierLuist.Enabled = false;
            btnClear.Enabled = false;
        }

        private void DisableComponent()
        {
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            txtSearch.Enabled = true;
            dgvSupplierLuist.Enabled = true;
            btnClear.Enabled = true;
        }

        private string updateSupllierID;
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSupplierLuist.Rows.Count > 0)
            {
                if (dgvSupplierLuist.SelectedRows.Count == 1)
                {
                    updateSupllierID = dgvSupplierLuist.CurrentRow.Cells[0].Value.ToString();
                    txtSupplierName.Text = dgvSupplierLuist.CurrentRow.Cells[1].Value.ToString();
                    txtContactNo.Text = dgvSupplierLuist.CurrentRow.Cells[2].Value.ToString();
                    txtAddress.Text = dgvSupplierLuist.CurrentRow.Cells[3].Value.ToString();
                    txtDescription.Text = dgvSupplierLuist.CurrentRow.Cells[4].Value.ToString();
                    ENableComponent();
                }
                else
                {
                    MessageBox.Show("Please Select One Row", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Add New Supplier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtSupplierName.Text.Trim().Length == 0)
            {
                ep.SetError(txtSupplierName, "Please ENter Supplier");
                txtSupplierName.Focus();
                return;
            }
            if (txtContactNo.Text.Trim().Length == 0)
            {
                ep.SetError(txtContactNo, "Please ENter Supplier");
                txtContactNo.Focus();
                return;
            }

            string sql = string.Format(@"UPDATE Suppliers SET Name = '{0}', contactNo = '{1}', address = '{2}', description = '{3}' WHERE suppID = '{4}'", txtSupplierName.Text, txtContactNo.Text, txtAddress.Text, txtDescription.Text, updateSupllierID);

            DataAccessLayer.Execute(sql);
            MessageBox.Show("Supplier Updated Successfully");
            FillGrid(string.Empty);
            ClearForm();
            DisableComponent();
        }
    }
}
