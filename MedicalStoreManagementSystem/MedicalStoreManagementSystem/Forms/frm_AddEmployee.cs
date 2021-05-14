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
    public partial class frm_AddEmployee : DevExpress.XtraEditors.XtraForm
    {
        private string RecordType;
        private frm_Employees frm_Employees;

        public frm_AddEmployee()
        {
            InitializeComponent();
        }

        // INSERT
        public frm_AddEmployee(string RecordType)
        {
            InitializeComponent();
            this.RecordType = RecordType;
            comboGender.SelectedIndex = 0;
        }


        // EDIT UPDATE
        public frm_AddEmployee(string RecordType, frm_Employees frm_Employees)
        {
            //: this(RecordType)
            InitializeComponent();
            this.RecordType = RecordType;
            this.frm_Employees = frm_Employees;
            this.btnSave.Text = "Update";

            txtEmployeeName.Text = frm_Employees.dgvEmployeeList.CurrentRow.Cells[1].Value.ToString();
            txtContactNo.Text = frm_Employees.dgvEmployeeList.CurrentRow.Cells[2].Value.ToString();
            if (frm_Employees.dgvEmployeeList.CurrentRow.Cells[3].Value.ToString() == "Male")
                comboGender.SelectedIndex = 1;
            if (frm_Employees.dgvEmployeeList.CurrentRow.Cells[3].Value.ToString() == "Female")
                comboGender.SelectedIndex = 2;
            if (frm_Employees.dgvEmployeeList.CurrentRow.Cells[3].Value.ToString() == "Other")
                comboGender.SelectedIndex = 3;
            dtpDateOfJoin.Value = Convert.ToDateTime(frm_Employees.dgvEmployeeList.CurrentRow.Cells[4].Value.ToString());
            txtSalary.Text = frm_Employees.dgvEmployeeList.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(txtEmployeeName.Text.Trim().Length == 0)
            {
                ep.SetError(txtEmployeeName, "Please Enter Employee Name!");
                txtEmployeeName.Focus();
                txtEmployeeName.SelectAll();
                return;
            }

            if (txtContactNo.Text.Trim().Length == 0)
            {
                ep.SetError(txtContactNo, "Please Enter ContactNo!");
                txtContactNo.Focus();
                txtContactNo.SelectAll();
                return;
            }

            if (comboGender.SelectedIndex == 0)
            {
                ep.SetError(comboGender, "Please Select Gender!");
                comboGender.Focus();
                return;
            }

            if (txtSalary.Text.Trim().Length == 0)
            {
                ep.SetError(txtSalary, "Please Enter Salary!");
                txtSalary.Focus();
                txtSalary.SelectAll();
                return;
            }

            int basicSalary = 0;
            int.TryParse(txtSalary.Text.Trim(), out basicSalary);
            if(basicSalary == 0)
            {
                ep.SetError(txtSalary, "Please Enter in Numeric Format eg (123456...)!");
                txtSalary.Focus();
                txtSalary.SelectAll();
                return;
            }

            

            

            if(RecordType == "INSERT")
            {
                string insertSQL = string.Format(@"INSERT INTO Employees (name, address, contactNo, gender, dateofJoin, basicSalary )VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", txtEmployeeName.Text.Trim(), txtAddress.Text.Trim(), txtContactNo.Text.Trim(), comboGender.Text.Trim(), dtpDateOfJoin.Value.ToString("yyyy/MM/dd"), txtSalary.Text.Trim());
                DataAccessLayer.Execute(insertSQL);
                XtraMessageBox.Show("Employee Add Successfully");
            }
            if (RecordType == "UPDATE")
            {
                string updateSQL = string.Format(@"UPDATE Employees SET name = '{0}', address = '{1}', contactno = '{2}', gender = '{3}', dateofjoin = '{4}', basicsalary = '{5}' WHERE empID = '{6}' ", txtEmployeeName.Text.Trim(), txtAddress.Text.Trim(), txtContactNo.Text.Trim(), comboGender.Text.Trim(), dtpDateOfJoin.Value.ToString("yyyy/MM/dd"), txtSalary.Text.Trim(), this.frm_Employees.dgvEmployeeList.CurrentRow.Cells[0].Value.ToString());
                DataAccessLayer.Execute(updateSQL);
                XtraMessageBox.Show("Employee Update Successfully");
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_AddEmployee_Load(object sender, EventArgs e)
        {
            //comboGender.SelectedIndex = 0;
        }
    }
}