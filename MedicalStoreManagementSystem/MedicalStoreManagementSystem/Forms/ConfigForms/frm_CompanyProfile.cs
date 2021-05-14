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
using MedicalStoreManagementSystem.Code;

namespace MedicalStoreManagementSystem.Forms.Other_Forms
{
    public partial class frm_CompanyProfile : DevExpress.XtraEditors.XtraForm
    {
        public frm_CompanyProfile()
        {
            InitializeComponent();
            RetrieveMedicalPRofile();
        }

        private void RetrieveMedicalPRofile()
        {
            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreiving("SELECT * FROM MedicalStoreProfile");
            if(dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    txt_MedicalName.Text = row[0].ToString();
                    txt_ContactNo.Text = row[1].ToString();
                    txt_ShopNo.Text = row[2].ToString();
                    txt_Address.Text = row[3].ToString();
                    txt_Email.Text = row[4].ToString();
                    txt_Website.Text = row[5].ToString();
                    txt_Description.Text = row[6].ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(txt_MedicalName.Text.Trim().Length == 0)
            {
                ep.SetError(txt_MedicalName, "Please Enter out Business Name!");
                txt_MedicalName.SelectAll();
                txt_MedicalName.Focus();
                return;
            }

            DataAccessLayer.Execute("DELETE FROM MedicalStoreProfile");

            string sql = string.Format(@"INSERT INTO MedicalStoreProfile VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", txt_MedicalName.Text.Trim(), txt_ContactNo.Text.Trim(), txt_ShopNo.Text.Trim(), txt_Address.Text.Trim(), txt_Email.Text.Trim(), txt_Website.Text.Trim(), txt_Description.Text.Trim());

            DataAccessLayer.Execute(sql);
            XtraMessageBox.Show("Business Profile Save Successfully!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}