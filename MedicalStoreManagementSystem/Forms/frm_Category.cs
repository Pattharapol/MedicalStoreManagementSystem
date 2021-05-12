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

namespace MedicalStoreManagementSystem.Forms
{
    public partial class frm_Category : DevExpress.XtraEditors.XtraForm
    {
        public frm_Category()
        {
            InitializeComponent();
            FillGrid();
        }

        private void FillGrid()
        {

            dgv_Category.Rows.Clear();
            DataTable dt = new DataTable();

            dt = DataAccessLayer.Retreiving("SELECT * FROM Categories");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    // ใชได้ทั้งสองแบบ
                    dgv_Category.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString());
                    //DataGridViewRow categoryRow = new DataGridViewRow();
                    //categoryRow.CreateCells(dgv_Category);
                    //categoryRow.Cells[0].Value = row[0].ToString();
                    //categoryRow.Cells[1].Value = row[1].ToString();
                    //categoryRow.Cells[2].Value = row[2].ToString();
                    //dgv_Category.Rows.Add(categoryRow);
                }
            }
        }

        private void FillGrid(string categoryName)
        {
            if(categoryName.Trim().Length == 0)
            {
                FillGrid();
                return;
            }

            dgv_Category.Rows.Clear();
            DataTable dt = new DataTable();

            dt = DataAccessLayer.Retreiving("SELECT * FROM Categories WHERE categoryName LIKE '%"+categoryName+"%'");
            if(dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    // ใชได้ทั้งสองแบบ
                    dgv_Category.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString());
                    //DataGridViewRow categoryRow = new DataGridViewRow();
                    //categoryRow.CreateCells(dgv_Category);
                    //categoryRow.Cells[0].Value = row[0].ToString();
                    //categoryRow.Cells[1].Value = row[1].ToString();
                    //categoryRow.Cells[2].Value = row[2].ToString();
                    //dgv_Category.Rows.Add(categoryRow);
                }
            }
        }

        private void ClearForm()
        {
            txt_Descriprtion.Clear();
            txt_CategoryName.Clear();
            txt_CategoryName.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(txt_CategoryName.Text.Trim().Length == 0)
            {
                ep.SetError(txt_CategoryName, "Please Enter Category Name");
                txt_CategoryName.Focus();
                return;
            }

            string sql = string.Format(@"INSERT INTO Categories (categoryName, description) VALUES ('{0}', '{1}')", txt_CategoryName.Text.Trim(), txt_Descriprtion.Text.Trim());
            DataAccessLayer.Execute(sql);
            XtraMessageBox.Show("OK");
            ClearForm();
            FillGrid();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(dgv_Category.Rows.Count > 0)
            {
                if(dgv_Category.SelectedRows.Count == 1)
                {
                    if(XtraMessageBox.Show("U want to DELETE this?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = string.Format(@"DELETE FROM Categories WHERE categoryID = '{0}'", dgv_Category.CurrentRow.Cells[0].Value.ToString());
                        DataAccessLayer.Execute(sql);
                        XtraMessageBox.Show("Delete OK");
                        FillGrid();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Please Select One Record");
                }
            }
            else
            {
                XtraMessageBox.Show("Category is EMPTY");
            }
        }

        private void EnableEditUpdate()
        {
            dgv_Category.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Update.Enabled = true;
            btn_Cancel.Enabled = true;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = false;
            btn_Clear.Enabled = false;
            txt_CategoryName.SelectAll();
            txt_CategoryName.Focus();
        }

        private void DisableEditUpdate()
        {
            dgv_Category.Enabled = true;
            btn_Edit.Enabled = true;
            btn_Update.Enabled = false;
            btn_Cancel.Enabled = false;
            btn_Delete.Enabled = true;
            btn_Save.Enabled = true;
            btn_Clear.Enabled = true;
            txt_CategoryName.SelectAll();
            txt_CategoryName.Focus();
        }

        private string updateID;
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            EnableEditUpdate();

            if (dgv_Category.Rows.Count > 0)
            {
                if (dgv_Category.SelectedRows.Count == 1)
                {
                    updateID = dgv_Category.CurrentRow.Cells[0].Value.ToString();
                    txt_CategoryName.Text = dgv_Category.CurrentRow.Cells[1].Value.ToString();
                    txt_Descriprtion.Text = dgv_Category.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    XtraMessageBox.Show("Please Select One Record");
                }
            }
            else
            {
                XtraMessageBox.Show("Category is EMPTY");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_CategoryName.Clear();
            txt_Descriprtion.Clear();
            DisableEditUpdate();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(txt_CategoryName.Text.Trim().Length == 0)
            {
                ep.SetError(txt_CategoryName, "Please Enter Category Name");
                txt_CategoryName.Focus();
                return;
            }

            if (XtraMessageBox.Show("U want to UPDATE this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = string.Format(@"UPDATE Categories SET categoryName = '{0}', description = '{1}' WHERE categoryID = '{2}'", txt_CategoryName.Text.Trim(), txt_Descriprtion.Text.Trim(), updateID);
                DataAccessLayer.Execute(sql);
                XtraMessageBox.Show("Update OK");
                DisableEditUpdate();
                ClearForm();
                FillGrid();
            }
            else
            {
                DisableEditUpdate();
                ClearForm();
                FillGrid();
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txt_Search.Text.Trim());
        }
    }
}