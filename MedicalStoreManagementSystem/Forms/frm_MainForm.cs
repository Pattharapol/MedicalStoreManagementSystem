using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MedicalStoreManagementSystem.Forms.Other_Forms;
using MedicalStoreManagementSystem.Forms.PurchaseForms;
using MedicalStoreManagementSystem.Forms.AuthenticationForms;
using MedicalStoreManagementSystem.Forms.StockForms;

namespace MedicalStoreManagementSystem.Forms
{
    public partial class frm_MainForm : DevExpress.XtraEditors.XtraForm
    {
        frm_UserLoginForm2 _UserLoginForm2;

        public frm_MainForm()
        {
            InitializeComponent();
        }

        public frm_MainForm(bool userType, frm_UserLoginForm2 _UserLoginForm2)
        {
            InitializeComponent();
            this._UserLoginForm2 = _UserLoginForm2;
            employeeToolStripMenuItem.Enabled = userType;
            configurationToolStripMenuItem.Enabled = userType;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Category frm = new frm_Category();
            frm.ShowDialog();
        }

        private void medicalProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CompanyProfile frm = new frm_CompanyProfile();
            frm.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Employees frm = new frm_Employees();
            frm.ShowDialog();
        }

        private void newSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Supplier frm = new frm_Supplier();
            frm.ShowDialog();
        }

        private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_UserLoginForm2 frm = new frm_UserLoginForm2();
            frm.ShowDialog();
        }

        private void userCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_UserCreateUpdateForm frm = new frm_UserCreateUpdateForm("Create");
            frm.ShowDialog();
        }

        private void userUpdationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_UserCreateUpdateForm frm = new frm_UserCreateUpdateForm("Update");
            frm.ShowDialog();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_StockGeneral frm = new frm_StockGeneral();
            frm.ShowDialog();
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Medicine frm = new frm_Medicine();
            frm.ShowDialog();
        }

        private void newPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NewPurchase frm = new frm_NewPurchase();
            frm.ShowDialog();
        }
    }
}