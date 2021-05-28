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
    public partial class frmSupplierPayment : Form
    {
        public frmSupplierPayment()
        {
            InitializeComponent();
        }

        private void ClearSearchSupplier()
        {
            lblSupplierContactNo.Text = "";
            lblSupplierDescription.Text = "";
            lblSupplierID.Text = "";
            txtSupplierName.Focus();
        }

        //private decimal totalPaidAmount = 0.0m;

        private void CalculatePaymentDetail()
        {
            string sql = string.Format(@"SELECT SUM(paid) FROM SupplierPayment WHERE supp_ID = '{0}'", lblSupplierID.Text);
            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreiving(sql);

            if (string.IsNullOrEmpty(dt.Rows[0][0].ToString()) || dt.Rows.Count == 0)
            {
                lblBalanceAmount.Text = lblTotalAmount.Text;
                lblPaidAmount.Text = "0.00";
            }
            else
            {
                //decimal.TryParse(dt.Rows[0][0].ToString(), out totalPaidAmount);
                lblBalanceAmount.Text = Convert.ToString(Convert.ToDecimal(lblTotalAmount.Text) - Convert.ToDecimal(dt.Rows[0][0].ToString()));
                lblPaidAmount.Text = Convert.ToString(dt.Rows[0][0].ToString());
            }
        }

        // for sum totalAmount in btnSearchSupplier_Click event
        private decimal totalAmount;

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            totalAmount = 0.00m;
            ep.Clear();
            dgvPurchases.ClearSelection();
            dgvPurchaseItemList.Rows.Clear();
            dgvPurchases.Rows.Clear();
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
                    break;
                }
            }

            DataTable dtPurchases = new DataTable();
            dtPurchases = DataAccessLayer.Retreiving(string.Format(@"SELECT * FROM Purchases WHERE suppID = '{0}'", lblSupplierID.Text));
            if (dtPurchases.Rows.Count > 0)
            {
                dgvPurchases.Rows.Clear();
                foreach (DataRow row in dtPurchases.Rows)
                {
                    DataGridViewRow createRow = new DataGridViewRow();
                    createRow.CreateCells(dgvPurchases);
                    createRow.Cells[0].Value = row[0].ToString();

                    createRow.Cells[1].Value = CommonCodeClass.GetThaiDateTime(row[2].ToString());
                    createRow.Cells[2].Value = row[4].ToString();
                    createRow.Cells[3].Value = row[3].ToString();
                    createRow.Cells[4].Value = row[5].ToString();
                    createRow.Cells[5].Value = row[6].ToString();
                    dgvPurchases.Rows.Add(createRow);

                    totalAmount += Convert.ToDecimal(row[5].ToString());
                }
            }
            lblTotalAmount.Text = totalAmount.ToString();
            CalculatePaymentDetail();
            FillPaymentGrid();
        }

        private void dgvPurchases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPurchaseItemList.Rows.Clear();
            if (dgvPurchases.Rows.Count > 0)
            {
                if (dgvPurchases.SelectedRows.Count == 1)
                {
                    DataTable dt = new DataTable();
                    dt = DataAccessLayer.Retreiving(string.Format(@"SELECT * FROM Purchase_Details WHERE pur_ID = '{0}'", dgvPurchases.CurrentRow.Cells[0].Value.ToString()));
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            DataGridViewRow createRow = new DataGridViewRow();
                            createRow.CreateCells(dgvPurchaseItemList);
                            if (Convert.ToInt32(row[2].ToString()) > 0)
                            {
                                createRow.Cells[0].Value = "Medicine";
                                createRow.Cells[1].Value = CommonCodeClass.GetMedicineName(row[2].ToString());
                            }
                            if (Convert.ToInt32(row[3].ToString()) > 0)
                            {
                                createRow.Cells[0].Value = "General";
                                createRow.Cells[1].Value = CommonCodeClass.GetGeneralName(row[3].ToString());
                            }

                            createRow.Cells[2].Value = row[4].ToString();
                            createRow.Cells[3].Value = row[5].ToString();
                            createRow.Cells[4].Value = CommonCodeClass.GetThaiDateTime(row[6].ToString());
                            createRow.Cells[5].Value = CommonCodeClass.GetThaiDateTime(row[7].ToString());
                            createRow.Cells[6].Value = row[8].ToString();
                            createRow.Cells[7].Value = row[9].ToString();
                            createRow.Cells[8].Value = Convert.ToDecimal(row[8].ToString()) * Convert.ToDecimal(row[9].ToString());
                            dgvPurchaseItemList.Rows.Add(createRow);
                        }
                    }
                }
            }
        }

        private void txtSupplierName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchSupplier_Click(sender, e);
            }
        }

        private void dgvPurchases_Click(object sender, EventArgs e)
        {
            dgvPurchaseItemList.Rows.Clear();
            if (dgvPurchases.Rows.Count > 0)
            {
                if (dgvPurchases.SelectedRows.Count == 1)
                {
                    DataTable dt = new DataTable();
                    dt = DataAccessLayer.Retreiving(string.Format(@"SELECT * FROM Purchase_Details WHERE pur_ID = '{0}'", dgvPurchases.CurrentRow.Cells[0].Value.ToString()));
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            DataGridViewRow createRow = new DataGridViewRow();
                            createRow.CreateCells(dgvPurchaseItemList);
                            if (Convert.ToInt32(row[2].ToString()) > 0)
                            {
                                createRow.Cells[0].Value = "Medicine";
                                createRow.Cells[1].Value = CommonCodeClass.GetMedicineName(row[2].ToString());
                            }
                            if (Convert.ToInt32(row[3].ToString()) > 0)
                            {
                                createRow.Cells[0].Value = "General";
                                createRow.Cells[1].Value = CommonCodeClass.GetGeneralName(row[3].ToString());
                            }

                            createRow.Cells[2].Value = row[4].ToString();
                            createRow.Cells[3].Value = row[5].ToString();
                            createRow.Cells[4].Value = CommonCodeClass.GetThaiDateTime(row[6].ToString());
                            createRow.Cells[5].Value = CommonCodeClass.GetThaiDateTime(row[7].ToString());
                            createRow.Cells[6].Value = row[8].ToString();
                            createRow.Cells[7].Value = row[9].ToString();
                            createRow.Cells[8].Value = Convert.ToDecimal(row[8].ToString()) * Convert.ToDecimal(row[9].ToString());
                            dgvPurchaseItemList.Rows.Add(createRow);
                        }
                    }
                }
                else
                {
                }
            }
            else
            {
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            decimal remainBalance = 0.0m;
            decimal paidAmount = 0.0m;
            decimal.TryParse(txtPaidAmount.Text, out paidAmount);
            decimal.TryParse(lblBalanceAmount.Text, out remainBalance);
            txtRemainingBalance.Text = Convert.ToString(remainBalance - paidAmount);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            decimal remainBalance = 0.0m;
            decimal paidAmount = 0.0m;
            decimal.TryParse(txtPaidAmount.Text, out paidAmount);
            decimal.TryParse(lblBalanceAmount.Text, out remainBalance);

            if (remainBalance < 0)
            {
                ep.SetError(txtRemainingBalance, "Remaining must be greater than 0");
                txtRemainingBalance.Focus();
                txtRemainingBalance.SelectAll();
                return;
            }
            if (paidAmount == 0)
            {
                ep.SetError(txtPaidAmount, "Please Enter Suppplier Payment!!!");
                txtPaidAmount.Focus();
                txtPaidAmount.SelectAll();
                return;
            }
            if (paidAmount > remainBalance)
            {
                ep.SetError(txtPaidAmount, "You cannot Paid more than Remaining!!!");
                txtPaidAmount.Focus();
                txtPaidAmount.SelectAll();
                return;
            }

            string query = string.Format(@"INSERT INTO SupplierPayment (supp_ID, totalAmount, paid, balanceAmount, paidDate, description) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", lblSupplierID.Text, lblTotalAmount.Text, paidAmount, txtRemainingBalance.Text, dtpPaidDate.Value.ToString("yyyy-MM-dd"), txtPaymentDescription.Text);
            DataAccessLayer.Execute(query);
            MessageBox.Show("Supplier Payment Successfully...");
            CalculatePaymentDetail();
            FillPaymentGrid();
            tabControl1.SelectedIndex = 0;
            txtPaymentDescription.Clear();
            txtPaidAmount.Text = "0.00";
            txtRemainingBalance.Text = "0.00";
        }

        private void FillPaymentGrid()
        {
            dgvPayment.Rows.Clear();
            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreiving(string.Format(@"SELECT * FROM SupplierPayment WHERE supp_ID = '{0}' ORDER BY paidDate ASC", lblSupplierID.Text));
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow paymentRow = new DataGridViewRow();
                    paymentRow.CreateCells(dgvPayment);
                    paymentRow.Cells[0].Value = CommonCodeClass.GetThaiDateTime(row[5].ToString());
                    paymentRow.Cells[1].Value = row[2].ToString();
                    paymentRow.Cells[2].Value = row[3].ToString();
                    paymentRow.Cells[3].Value = row[4].ToString();
                    paymentRow.Cells[4].Value = row[6].ToString();
                    dgvPayment.Rows.Add(paymentRow);
                }
            }
        }
    }
}