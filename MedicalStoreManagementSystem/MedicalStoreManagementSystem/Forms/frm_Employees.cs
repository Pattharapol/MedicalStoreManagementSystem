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
    public partial class frm_Employees : DevExpress.XtraEditors.XtraForm
    {
        public frm_Employees()
        {
            InitializeComponent();
            FillGrid();
        }

        private void FillGrid()
        {
            dgvEmployeeList.Rows.Clear();
            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreiving("SELECT * FROM Employees");
            if(dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    DataGridViewRow createRow = new DataGridViewRow();
                    createRow.CreateCells(dgvEmployeeList);
                    createRow.Cells[0].Value = row[0].ToString();
                    createRow.Cells[1].Value = row[1].ToString();
                    createRow.Cells[2].Value = row[3].ToString();
                    createRow.Cells[3].Value = row[4].ToString();
                    createRow.Cells[4].Value = Convert.ToDateTime(row[5]).ToString("dd MMMM, yyyy");
                    createRow.Cells[5].Value = row[6].ToString();
                    createRow.Cells[6].Value = row[2].ToString();
                    dgvEmployeeList.Rows.Add(createRow);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_AddEmployee frm = new frm_AddEmployee("INSERT");
            frm.ShowDialog();
            FillGrid();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            FillGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvEmployeeList.Rows.Count > 0)
            {
                if(dgvEmployeeList.SelectedRows.Count == 1)
                {
                    frm_AddEmployee frm = new frm_AddEmployee("UPDATE", this);
                    frm.ShowDialog();
                    FillGrid();
                }
                else
                {
                    XtraMessageBox.Show("Please Select One");
                }
            }
            else
            {
                XtraMessageBox.Show("Employee List is Empty");
            }
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEmployeeList.Rows.Count > 0)
            {
                if (dgvEmployeeList.SelectedRows.Count == 1)
                {
                    if(XtraMessageBox.Show("U want to DELETE this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string deleteSQL = string.Format(@"DELETE FROM Employees WHERE empID = '{0}'", dgvEmployeeList.CurrentRow.Cells[0].Value.ToString());
                        DataAccessLayer.Execute(deleteSQL);
                        FillGrid();
                    }
                    
                }
                else
                {
                    XtraMessageBox.Show("Please Select One");
                }
            }
            else
            {
                XtraMessageBox.Show("Employee List is Empty");
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}