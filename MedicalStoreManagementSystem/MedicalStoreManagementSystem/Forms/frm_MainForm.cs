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

namespace MedicalStoreManagementSystem.Forms
{
    public partial class frm_MainForm : DevExpress.XtraEditors.XtraForm
    {
        public frm_MainForm()
        {
            InitializeComponent();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Category frm = new frm_Category();
            frm.ShowDialog();
        }
    }
}