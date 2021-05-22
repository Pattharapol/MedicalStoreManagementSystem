using MedicalStoreManagementSystem.Code;
using System;
using System.Data;
using System.Windows.Forms;

namespace MedicalStoreManagementSystem.Forms.PurchaseForms
{
    public partial class frm_NewPurchase : Form
    {
        public frm_NewPurchase()
        {
            InitializeComponent();
            rdbGeneral.Checked = true;
            cmbSelectProduct.SelectedIndex = 0;
            CalculateTotalAmount();
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtSupplierName.Text.Trim().Length == 0)
            {
                ep.SetError(txtSupplierName, "Please Enter Supplier Name...");
                txtSupplierName.Focus();
                return;
            }

            string query = string.Format(@"SELECT * FROM Suppliers WHERE Name = '{0}'", txtSupplierName.Text.Trim());
            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreiving(query);
            if (dt.Rows.Count == 0)
            {
                ClearSearchSupplier();
                return;
            }
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lblSupplierID.Text = row[0].ToString();
                    lblSupplierContactNo.Text = row[2].ToString();
                    lblSupplierDescription.Text = row[4].ToString();
                }
            }
        }

        private void ClearSearchSupplier()
        {
            lblSupplierContactNo.Text = "";
            lblSupplierDescription.Text = "";
            lblSupplierID.Text = "";
            txtSupplierName.Focus();
        }

        private void txtSupplierName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchSupplier_Click(sender, e);
            }
        }

        private void rdbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGeneral.Checked == true)
            {
                cmbSelectProduct.Items.Clear();
                cmbSelectProduct.Items.Add("Select Product");
                cmbSelectProduct.SelectedIndex = 0;
                DataTable dt = new DataTable();
                dt = DataAccessLayer.Retreiving("SELECT gen_Name FROM General");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        cmbSelectProduct.Items.Add(row[0].ToString());
                    }
                }
            }
        }

        private void rdbMedicine_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMedicine.Checked == true)
            {
                cmbSelectProduct.Items.Clear();
                cmbSelectProduct.Items.Add("Select Product");
                cmbSelectProduct.SelectedIndex = 0;
                DataTable dt = new DataTable();
                dt = DataAccessLayer.Retreiving("SELECT med_Name FROM Medicines");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        cmbSelectProduct.Items.Add(row[0].ToString());
                    }
                }
            }
        }

        private void cmbSelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectProduct.Items.Count > 0)
            {
                if (cmbSelectProduct.SelectedIndex > 0)
                {
                    DataTable dt = new DataTable();
                    if (rdbGeneral.Checked == true)
                    {
                        dt = CommonCodeClass.GetProductCurrentDetail(cmbSelectProduct.Text.Trim(), "G");
                    }

                    if (rdbMedicine.Checked == true)
                    {
                        dt = CommonCodeClass.GetProductCurrentDetail(cmbSelectProduct.Text.Trim(), "M");
                    }

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            lblSelectProductName.Text = cmbSelectProduct.Text;
                            lblSelectProductQUantity.Text = row[1].ToString();
                            lblSelectProductUnitPrice.Text = row[2].ToString();
                        }
                    }
                    else
                    {
                        lblSelectProductName.Text = "Not Available";
                        lblSelectProductQUantity.Text = "0";
                        lblSelectProductUnitPrice.Text = "0.00";
                    }
                }
                else
                {
                    lblSelectProductName.Text = "Not Available";
                    lblSelectProductQUantity.Text = "0";
                    lblSelectProductUnitPrice.Text = "0.00";
                }
            }
            else
            {
                lblSelectProductName.Text = "Not Available";
                lblSelectProductQUantity.Text = "0";
                lblSelectProductUnitPrice.Text = "0.00";
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only number
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only number and decimal point
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only number and decimal point
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CalculateTotalAmount()
        {
            decimal TotalAmount = 0;
            decimal DIscount = 0;
            decimal NetAmount = 0;

            if (dgvPurchaseItemList.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvPurchaseItemList.Rows)
                {
                    TotalAmount = TotalAmount + Convert.ToDecimal(row.Cells[9].Value);
                }
                decimal.TryParse(txtDiscount.Text.Trim(), out DIscount);
                DIscount = DIscount * (TotalAmount / 100);
                NetAmount = TotalAmount - DIscount;

                txtNetAmount.Text = Convert.ToString(NetAmount);
                txtTotalAmount.Text = Convert.ToString(TotalAmount);
            }
            else
            {
                txtTotalAmount.Text = "0.00";
                txtDiscount.Text = "0.00";
                txtNetAmount.Text = "0.00";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (lblSupplierID.Text.Trim().Length == 0)
            {
                ep.SetError(txtSupplierName, "Please First Search Supplier...");
                txtSupplierName.Focus();
                return;
            }

            if (cmbSelectProduct.SelectedIndex > 0)
            {
                if (dgvPurchaseItemList.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvPurchaseItemList.Rows)
                    {
                        string type = "";
                        if (rdbGeneral.Checked)
                        {
                            type = "General";
                        }
                        if (rdbGeneral.Checked)
                        {
                            type = "Medicine";
                        }

                        if (Convert.ToString(row.Cells[0].Value) == type && Convert.ToString(row.Cells[1].Value) == cmbSelectProduct.Text)
                        {
                            row.Selected = true;
                        }
                    }
                }

                if (txtQuantity.Text.Trim().Length == 0)
                {
                    ep.SetError(txtQuantity, "Please Enter quantity");
                    txtQuantity.Focus();
                    return;
                }
                if (txtPurchasePrice.Text.Trim().Length == 0)
                {
                    ep.SetError(txtPurchasePrice, "Please Enter purchase price");
                    txtPurchasePrice.Focus();
                    return;
                }
                if (txtSalePrice.Text.Trim().Length == 0)
                {
                    ep.SetError(txtSalePrice, "Please Enter Sale price");
                    txtSalePrice.Focus();
                    return;
                }

                string MFGDate = dtpMFGDate.Value.ToString("dd MMMM,yyyy");
                string ExpDate = dtpEXPDATE.Value.ToString("dd MMMM,yyyy");
                decimal ItemCost = Convert.ToDecimal(txtQuantity.Text.Trim()) * Convert.ToDecimal(txtPurchasePrice.Text.Trim());

                DataGridViewRow CreateRow = new DataGridViewRow();
                CreateRow.CreateCells(dgvPurchaseItemList);
                if (rdbGeneral.Checked)
                {
                    CreateRow.Cells[0].Value = "General";
                    bool status = false;
                    string batchNo;
                    CommonCodeClass.GetBatchNo(cmbSelectProduct.Text.Trim(), "G", out status, out batchNo);
                    if (dgvPurchaseItemList.Rows.Count > 0)
                    {
                        if (status)
                        {
                            foreach (DataGridViewRow CheckBatchNoRow in dgvPurchaseItemList.Rows)
                            {
                                if (Convert.ToInt32(batchNo) < Convert.ToInt32(CheckBatchNoRow.Cells[3].Value))
                                {
                                    batchNo = Convert.ToString(Convert.ToInt32(CheckBatchNoRow.Cells[3].Value) + 1);
                                }
                                if (Convert.ToInt32(batchNo) == Convert.ToInt32(CheckBatchNoRow.Cells[3].Value))
                                {
                                    batchNo = Convert.ToString(Convert.ToInt32(CheckBatchNoRow.Cells[3].Value) + 1);
                                }
                            }
                        }
                    }
                    CreateRow.Cells[3].Value = batchNo;
                }
                if (rdbMedicine.Checked)
                {
                    CreateRow.Cells[0].Value = "Medicine";
                    bool status = false;
                    string batchNo;
                    CommonCodeClass.GetBatchNo(cmbSelectProduct.Text.Trim(), "M", out status, out batchNo);
                    if (dgvPurchaseItemList.Rows.Count > 0)
                    {
                        if (status)
                        {
                            foreach (DataGridViewRow CheckBatchNoRow in dgvPurchaseItemList.Rows)
                            {
                                if (Convert.ToInt32(batchNo) < Convert.ToInt32(CheckBatchNoRow.Cells[3].Value))
                                {
                                    batchNo = Convert.ToString(Convert.ToInt32(CheckBatchNoRow.Cells[3].Value) + 1);
                                }
                                if (Convert.ToInt32(batchNo) == Convert.ToInt32(CheckBatchNoRow.Cells[3].Value))
                                {
                                    batchNo = Convert.ToString(Convert.ToInt32(CheckBatchNoRow.Cells[3].Value) + 1);
                                }
                            }
                        }
                    }
                    CreateRow.Cells[3].Value = batchNo;
                }

                CreateRow.Cells[1].Value = cmbSelectProduct.Text.Trim();
                CreateRow.Cells[2].Value = txtSupplierName.Text.Trim();
                CreateRow.Cells[4].Value = MFGDate;
                CreateRow.Cells[5].Value = ExpDate;
                CreateRow.Cells[6].Value = txtPurchasePrice.Text.Trim();
                CreateRow.Cells[7].Value = txtSalePrice.Text.Trim();
                CreateRow.Cells[8].Value = txtQuantity.Text.Trim();
                CreateRow.Cells[9].Value = ItemCost.ToString();

                dgvPurchaseItemList.Rows.Add(CreateRow);
            }
            else
            {
                ep.SetError(cmbSelectProduct, "Please Select Product First...");
                cmbSelectProduct.Focus();
                return;
            }
            CalculateTotalAmount();
            ClearFormMethod();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormMethod();
        }

        private void ClearFormMethod()
        {
            cmbSelectProduct.SelectedIndex = 0;
            dtpEXPDATE.Value = DateTime.Now;
            dtpMFGDate.Value = DateTime.Now;
            txtQuantity.Clear();
            txtPurchasePrice.Clear();
            txtSalePrice.Clear();
            rdbGeneral.Checked = true;
        }

        private void SelectRecordForEdit()
        {
            if (dgvPurchaseItemList.CurrentRow.Cells[0].Value.ToString() == "General")
            {
                rdbGeneral.Checked = true;
                cmbSelectProduct.Text = dgvPurchaseItemList.CurrentRow.Cells[1].Value.ToString();
            }

            if (dgvPurchaseItemList.CurrentRow.Cells[0].Value.ToString() == "Medicine")
            {
                rdbMedicine.Checked = true;
                cmbSelectProduct.Text = dgvPurchaseItemList.CurrentRow.Cells[1].Value.ToString();
            }

            dtpMFGDate.Value = Convert.ToDateTime(dgvPurchaseItemList.CurrentRow.Cells[4].Value);
            dtpEXPDATE.Value = Convert.ToDateTime(dgvPurchaseItemList.CurrentRow.Cells[5].Value);
            txtPurchasePrice.Text = Convert.ToString(dgvPurchaseItemList.CurrentRow.Cells[6].Value);
            txtQuantity.Text = Convert.ToString(dgvPurchaseItemList.CurrentRow.Cells[8].Value);
            txtSalePrice.Text = Convert.ToString(dgvPurchaseItemList.CurrentRow.Cells[7].Value);
            lblSelectProductName.Text = dgvPurchaseItemList.CurrentRow.Cells[1].Value.ToString();
        }

        private void EnableControls()
        {
            grpPurchaseItemList.Enabled = false;
            btnAdd.Enabled = false;
            btnClear.Enabled = false;
            btnNewPurchase.Enabled = false;
            btnFinalizeProduct.Enabled = false;
            btnClearForm.Enabled = false;
        }

        private void lnkEditItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvPurchaseItemList.Rows.Count > 0)
            {
                if (dgvPurchaseItemList.SelectedRows.Count == 1)
                {
                    SelectRecordForEdit();
                    EnableControls();
                }
                else
                {
                    MessageBox.Show("Please Select One Record...");
                }
            }
            else
            {
                MessageBox.Show("List is Empty!!!");
            }
        }

        private void lnkDeleteItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvPurchaseItemList.Rows.Count > 0)
            {
                if (dgvPurchaseItemList.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("U want to DELETE this Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dgvPurchaseItemList.Rows.Remove(dgvPurchaseItemList.CurrentRow);
                        CalculateTotalAmount();
                        ClearFormMethod();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select One Record...");
                }
            }
            else
            {
                MessageBox.Show("List is Empty!!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (lblSupplierID.Text.Trim().Length == 0)
            {
                ep.SetError(txtSupplierName, "Please First Search Supplier...");
                txtSupplierName.Focus();
                return;
            }

            if (cmbSelectProduct.SelectedIndex > 0)
            {
                if (dgvPurchaseItemList.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvPurchaseItemList.Rows)
                    {
                        string type = "";
                        if (rdbGeneral.Checked)
                        {
                            type = "General";
                        }
                        if (rdbGeneral.Checked)
                        {
                            type = "Medicine";
                        }

                        if (Convert.ToString(row.Cells[0].Value) == type && Convert.ToString(row.Cells[1].Value) == cmbSelectProduct.Text)
                        {
                            row.Selected = true;
                        }
                    }
                }

                if (txtQuantity.Text.Trim().Length == 0)
                {
                    ep.SetError(txtQuantity, "Please Enter quantity");
                    txtQuantity.Focus();
                    return;
                }
                if (txtPurchasePrice.Text.Trim().Length == 0)
                {
                    ep.SetError(txtPurchasePrice, "Please Enter purchase price");
                    txtPurchasePrice.Focus();
                    return;
                }
                if (txtSalePrice.Text.Trim().Length == 0)
                {
                    ep.SetError(txtSalePrice, "Please Enter Sale price");
                    txtSalePrice.Focus();
                    return;
                }

                string MFGDate = dtpMFGDate.Value.ToString("dd MMMM,yyyy");
                string ExpDate = dtpEXPDATE.Value.ToString("dd MMMM,yyyy");
                decimal ItemCost = Convert.ToDecimal(txtQuantity.Text.Trim()) * Convert.ToDecimal(txtPurchasePrice.Text.Trim());

                DataGridViewRow CreateRow = new DataGridViewRow();
                CreateRow.CreateCells(dgvPurchaseItemList);
                if (rdbGeneral.Checked)
                {
                    CreateRow.Cells[0].Value = "General";
                    bool status = false;
                    string batchNo;
                    CommonCodeClass.GetBatchNo(cmbSelectProduct.Text.Trim(), "G", out status, out batchNo);
                    if (dgvPurchaseItemList.Rows.Count > 0)
                    {
                        if (status)
                        {
                            foreach (DataGridViewRow CheckBatchNoRow in dgvPurchaseItemList.Rows)
                            {
                                if (Convert.ToInt32(batchNo) < Convert.ToInt32(CheckBatchNoRow.Cells[3].Value))
                                {
                                    batchNo = Convert.ToString(Convert.ToInt32(CheckBatchNoRow.Cells[3].Value) + 1);
                                }
                                if (Convert.ToInt32(batchNo) == Convert.ToInt32(CheckBatchNoRow.Cells[3].Value))
                                {
                                    batchNo = Convert.ToString(Convert.ToInt32(CheckBatchNoRow.Cells[3].Value) + 1);
                                }
                            }
                        }
                    }
                    CreateRow.Cells[3].Value = batchNo;
                }
                if (rdbMedicine.Checked)
                {
                    CreateRow.Cells[0].Value = "Medicine";
                    bool status = false;
                    string batchNo;
                    CommonCodeClass.GetBatchNo(cmbSelectProduct.Text.Trim(), "M", out status, out batchNo);
                    if (dgvPurchaseItemList.Rows.Count > 0)
                    {
                        if (status)
                        {
                            foreach (DataGridViewRow CheckBatchNoRow in dgvPurchaseItemList.Rows)
                            {
                                if (Convert.ToInt32(batchNo) < Convert.ToInt32(CheckBatchNoRow.Cells[3].Value))
                                {
                                    batchNo = Convert.ToString(Convert.ToInt32(CheckBatchNoRow.Cells[3].Value) + 1);
                                }
                                if (Convert.ToInt32(batchNo) == Convert.ToInt32(CheckBatchNoRow.Cells[3].Value))
                                {
                                    batchNo = Convert.ToString(Convert.ToInt32(CheckBatchNoRow.Cells[3].Value) + 1);
                                }
                            }
                        }
                    }
                    CreateRow.Cells[3].Value = batchNo;
                }

                CreateRow.Cells[1].Value = cmbSelectProduct.Text.Trim();
                CreateRow.Cells[2].Value = txtSupplierName.Text.Trim();
                CreateRow.Cells[4].Value = MFGDate;
                CreateRow.Cells[5].Value = ExpDate;
                CreateRow.Cells[6].Value = txtPurchasePrice.Text.Trim();
                CreateRow.Cells[7].Value = txtSalePrice.Text.Trim();
                CreateRow.Cells[8].Value = txtQuantity.Text.Trim();
                CreateRow.Cells[9].Value = ItemCost.ToString();

                dgvPurchaseItemList.Rows.Add(CreateRow);
            }
            else
            {
                ep.SetError(cmbSelectProduct, "Please Select Product First...");
                cmbSelectProduct.Focus();
                return;
            }
            CalculateTotalAmount();
            ClearFormMethod();
        }
    }
}