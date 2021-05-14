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
    public partial class frm_NewPurchase : Form
    {
        public frm_NewPurchase()
        {
            InitializeComponent();
            rdbGeneral.Checked = true;
            cmbSelectProduct.SelectedIndex = 0;
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(txtSupplierName.Text.Trim().Length == 0)
            {
                ep.SetError(txtSupplierName, "Please Enter Supplier Name...");
                txtSupplierName.Focus();
                return;
            }

            string query = string.Format(@"SELECT * FROM Suppliers WHERE Name = '{0}'", txtSupplierName.Text.Trim());
            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreiving(query);
            if(dt.Rows.Count == 0)
            {
                ClearSearchSupplier();
                return;
            }
            if(dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
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
            if(e.KeyCode == Keys.Enter)
            {
                btnSearchSupplier_Click(sender, e);
            }
        }

        private void rdbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbGeneral.Checked == true)
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
            if(rdbMedicine.Checked == true)
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
    }
}
