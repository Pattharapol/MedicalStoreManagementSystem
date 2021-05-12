namespace MedicalStoreManagementSystem.Forms
{
    partial class frm_MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGenralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleReturnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReturnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.returnListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expirtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userCreationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userUpdationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSlaesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineExpiryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.expirtToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1470, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminLoginToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // adminLoginToolStripMenuItem
            // 
            this.adminLoginToolStripMenuItem.Name = "adminLoginToolStripMenuItem";
            this.adminLoginToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.adminLoginToolStripMenuItem.Text = "Sign In";
            this.adminLoginToolStripMenuItem.Click += new System.EventHandler(this.adminLoginToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.generalToolStripMenuItem,
            this.medicineToolStripMenuItem,
            this.viewGenralToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medicineToolStripMenuItem.Text = "Medicine";
            this.medicineToolStripMenuItem.Click += new System.EventHandler(this.medicineToolStripMenuItem_Click);
            // 
            // viewGenralToolStripMenuItem
            // 
            this.viewGenralToolStripMenuItem.Name = "viewGenralToolStripMenuItem";
            this.viewGenralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewGenralToolStripMenuItem.Text = "View Genral";
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.saleToolStripMenuItem.Text = "Sale";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.newToolStripMenuItem.Text = "New Sale";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.viewToolStripMenuItem.Text = "Search Sale";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPurchaseToolStripMenuItem,
            this.searchPurchaseToolStripMenuItem,
            this.newSupplierToolStripMenuItem});
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // newPurchaseToolStripMenuItem
            // 
            this.newPurchaseToolStripMenuItem.Name = "newPurchaseToolStripMenuItem";
            this.newPurchaseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.newPurchaseToolStripMenuItem.Text = "New Purchase";
            // 
            // searchPurchaseToolStripMenuItem
            // 
            this.searchPurchaseToolStripMenuItem.Name = "searchPurchaseToolStripMenuItem";
            this.searchPurchaseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.searchPurchaseToolStripMenuItem.Text = "Search Purchase";
            // 
            // newSupplierToolStripMenuItem
            // 
            this.newSupplierToolStripMenuItem.Name = "newSupplierToolStripMenuItem";
            this.newSupplierToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.newSupplierToolStripMenuItem.Text = "New Supplier";
            this.newSupplierToolStripMenuItem.Click += new System.EventHandler(this.newSupplierToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleReturnToolStripMenuItem1,
            this.purchaseReturnToolStripMenuItem1,
            this.returnListToolStripMenuItem});
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.returnToolStripMenuItem.Text = "Return";
            // 
            // saleReturnToolStripMenuItem1
            // 
            this.saleReturnToolStripMenuItem1.Name = "saleReturnToolStripMenuItem1";
            this.saleReturnToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.saleReturnToolStripMenuItem1.Text = "Sale Return";
            // 
            // purchaseReturnToolStripMenuItem1
            // 
            this.purchaseReturnToolStripMenuItem1.Name = "purchaseReturnToolStripMenuItem1";
            this.purchaseReturnToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.purchaseReturnToolStripMenuItem1.Text = "Purchase Return";
            // 
            // returnListToolStripMenuItem
            // 
            this.returnListToolStripMenuItem.Name = "returnListToolStripMenuItem";
            this.returnListToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.returnListToolStripMenuItem.Text = "Return List";
            // 
            // expirtToolStripMenuItem
            // 
            this.expirtToolStripMenuItem.Name = "expirtToolStripMenuItem";
            this.expirtToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.expirtToolStripMenuItem.Text = "Expirt";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Enabled = false;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userCreationToolStripMenuItem,
            this.userUpdationToolStripMenuItem,
            this.medicalProfileToolStripMenuItem});
            this.configurationToolStripMenuItem.Enabled = false;
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // userCreationToolStripMenuItem
            // 
            this.userCreationToolStripMenuItem.Name = "userCreationToolStripMenuItem";
            this.userCreationToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.userCreationToolStripMenuItem.Text = "User Creation";
            this.userCreationToolStripMenuItem.Click += new System.EventHandler(this.userCreationToolStripMenuItem_Click);
            // 
            // userUpdationToolStripMenuItem
            // 
            this.userUpdationToolStripMenuItem.Name = "userUpdationToolStripMenuItem";
            this.userUpdationToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.userUpdationToolStripMenuItem.Text = "User Updation";
            this.userUpdationToolStripMenuItem.Click += new System.EventHandler(this.userUpdationToolStripMenuItem_Click);
            // 
            // medicalProfileToolStripMenuItem
            // 
            this.medicalProfileToolStripMenuItem.Name = "medicalProfileToolStripMenuItem";
            this.medicalProfileToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.medicalProfileToolStripMenuItem.Text = "Company Profile";
            this.medicalProfileToolStripMenuItem.Click += new System.EventHandler(this.medicalProfileToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseReturnToolStripMenuItem,
            this.saleReturnToolStripMenuItem,
            this.viewSlaesToolStripMenuItem,
            this.viewPurchasesToolStripMenuItem,
            this.stockReportToolStripMenuItem,
            this.medicineExpiryReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // purchaseReturnToolStripMenuItem
            // 
            this.purchaseReturnToolStripMenuItem.Name = "purchaseReturnToolStripMenuItem";
            this.purchaseReturnToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.purchaseReturnToolStripMenuItem.Text = "Purchase Return";
            // 
            // saleReturnToolStripMenuItem
            // 
            this.saleReturnToolStripMenuItem.Name = "saleReturnToolStripMenuItem";
            this.saleReturnToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saleReturnToolStripMenuItem.Text = "Sale Reports";
            // 
            // viewSlaesToolStripMenuItem
            // 
            this.viewSlaesToolStripMenuItem.Name = "viewSlaesToolStripMenuItem";
            this.viewSlaesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.viewSlaesToolStripMenuItem.Text = "View Slaes";
            // 
            // viewPurchasesToolStripMenuItem
            // 
            this.viewPurchasesToolStripMenuItem.Name = "viewPurchasesToolStripMenuItem";
            this.viewPurchasesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.viewPurchasesToolStripMenuItem.Text = "View Purchases";
            // 
            // stockReportToolStripMenuItem
            // 
            this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.stockReportToolStripMenuItem.Text = "Stock Report";
            // 
            // medicineExpiryReportToolStripMenuItem
            // 
            this.medicineExpiryReportToolStripMenuItem.Name = "medicineExpiryReportToolStripMenuItem";
            this.medicineExpiryReportToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.medicineExpiryReportToolStripMenuItem.Text = "Medicine Expiry Report";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 627);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1470, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frm_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 649);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_MainForm";
            this.Text = "Medical Store Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewGenralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleReturnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem purchaseReturnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem returnListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expirtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userCreationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userUpdationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSlaesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineExpiryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem newSupplierToolStripMenuItem;
    }
}