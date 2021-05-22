
namespace MedicalStoreManagementSystem.Forms.PurchaseForms
{
    partial class frm_NewPurchase
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.lblSupplierDescription = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSupplierContactNo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSelectProductUnitPrice = new System.Windows.Forms.Label();
            this.lblSelectProductQUantity = new System.Windows.Forms.Label();
            this.lblSelectProductName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpEXPDATE = new System.Windows.Forms.DateTimePicker();
            this.dtpMFGDate = new System.Windows.Forms.DateTimePicker();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.rdbGeneral = new System.Windows.Forms.RadioButton();
            this.rdbMedicine = new System.Windows.Forms.RadioButton();
            this.cmbSelectProduct = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grpPurchaseItemList = new System.Windows.Forms.GroupBox();
            this.lnkDeleteItem = new System.Windows.Forms.LinkLabel();
            this.dgvPurchaseItemList = new System.Windows.Forms.DataGridView();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMFG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchasePRice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkEditItem = new System.Windows.Forms.LinkLabel();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnNewPurchase = new System.Windows.Forms.Button();
            this.btnFinalizeProduct = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpPurchaseItemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchSupplier);
            this.groupBox1.Controls.Add(this.lblSupplierDescription);
            this.groupBox1.Controls.Add(this.lblSupplierID);
            this.groupBox1.Controls.Add(this.txtSupplierName);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Supplier";
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSearchSupplier.Location = new System.Drawing.Point(264, 61);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(84, 34);
            this.btnSearchSupplier.TabIndex = 2;
            this.btnSearchSupplier.Text = "Search";
            this.btnSearchSupplier.UseVisualStyleBackColor = true;
            this.btnSearchSupplier.Click += new System.EventHandler(this.btnSearchSupplier_Click);
            // 
            // lblSupplierDescription
            // 
            this.lblSupplierDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSupplierDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSupplierDescription.Location = new System.Drawing.Point(434, 102);
            this.lblSupplierDescription.Name = "lblSupplierDescription";
            this.lblSupplierDescription.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblSupplierDescription.Size = new System.Drawing.Size(184, 79);
            this.lblSupplierDescription.TabIndex = 3;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSupplierID.Location = new System.Drawing.Point(434, 33);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblSupplierID.Size = new System.Drawing.Size(184, 24);
            this.lblSupplierID.TabIndex = 4;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSupplierName.Location = new System.Drawing.Point(137, 33);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(211, 22);
            this.txtSupplierName.TabIndex = 1;
            this.txtSupplierName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSupplierName_KeyDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label18.Location = new System.Drawing.Point(403, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "ID";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label21.Location = new System.Drawing.Point(348, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 16);
            this.label21.TabIndex = 0;
            this.label21.Text = "Description";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label19.Location = new System.Drawing.Point(350, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Contact No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Supplier Name ";
            // 
            // lblSupplierContactNo
            // 
            this.lblSupplierContactNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSupplierContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSupplierContactNo.Location = new System.Drawing.Point(446, 81);
            this.lblSupplierContactNo.Name = "lblSupplierContactNo";
            this.lblSupplierContactNo.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblSupplierContactNo.Size = new System.Drawing.Size(184, 24);
            this.lblSupplierContactNo.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpPurchaseDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 167);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDescription.Location = new System.Drawing.Point(91, 63);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(216, 88);
            this.txtDescription.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(9, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.CustomFormat = "dd MMMM,yyyy";
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(91, 24);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(216, 22);
            this.dtpPurchaseDate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order Date";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSelectProductUnitPrice);
            this.groupBox3.Controls.Add(this.lblSelectProductQUantity);
            this.groupBox3.Controls.Add(this.lblSelectProductName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 149);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Product Detail";
            // 
            // lblSelectProductUnitPrice
            // 
            this.lblSelectProductUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectProductUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSelectProductUnitPrice.Location = new System.Drawing.Point(106, 97);
            this.lblSelectProductUnitPrice.Name = "lblSelectProductUnitPrice";
            this.lblSelectProductUnitPrice.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblSelectProductUnitPrice.Size = new System.Drawing.Size(200, 24);
            this.lblSelectProductUnitPrice.TabIndex = 2;
            // 
            // lblSelectProductQUantity
            // 
            this.lblSelectProductQUantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectProductQUantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSelectProductQUantity.Location = new System.Drawing.Point(107, 60);
            this.lblSelectProductQUantity.Name = "lblSelectProductQUantity";
            this.lblSelectProductQUantity.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblSelectProductQUantity.Size = new System.Drawing.Size(200, 24);
            this.lblSelectProductQUantity.TabIndex = 1;
            // 
            // lblSelectProductName
            // 
            this.lblSelectProductName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSelectProductName.Location = new System.Drawing.Point(107, 22);
            this.lblSelectProductName.Name = "lblSelectProductName";
            this.lblSelectProductName.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblSelectProductName.Size = new System.Drawing.Size(200, 24);
            this.lblSelectProductName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(0, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Product Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(20, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(23, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quantity";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.dtpEXPDATE);
            this.groupBox4.Controls.Add(this.dtpMFGDate);
            this.groupBox4.Controls.Add(this.txtSalePrice);
            this.groupBox4.Controls.Add(this.txtPurchasePrice);
            this.groupBox4.Controls.Add(this.txtQuantity);
            this.groupBox4.Controls.Add(this.rdbGeneral);
            this.groupBox4.Controls.Add(this.rdbMedicine);
            this.groupBox4.Controls.Add(this.cmbSelectProduct);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(342, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(398, 427);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Item To Purchase";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAdd.Location = new System.Drawing.Point(156, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 34);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClear.Location = new System.Drawing.Point(246, 242);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 34);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancel.Location = new System.Drawing.Point(246, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 34);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnUpdate.Location = new System.Drawing.Point(156, 282);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 34);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpEXPDATE
            // 
            this.dtpEXPDATE.CustomFormat = "dd MMMM,yyyy";
            this.dtpEXPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpEXPDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEXPDATE.Location = new System.Drawing.Point(105, 108);
            this.dtpEXPDATE.Name = "dtpEXPDATE";
            this.dtpEXPDATE.Size = new System.Drawing.Size(225, 22);
            this.dtpEXPDATE.TabIndex = 4;
            // 
            // dtpMFGDate
            // 
            this.dtpMFGDate.CustomFormat = "dd MMMM,yyyy";
            this.dtpMFGDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpMFGDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMFGDate.Location = new System.Drawing.Point(105, 80);
            this.dtpMFGDate.Name = "dtpMFGDate";
            this.dtpMFGDate.Size = new System.Drawing.Size(225, 22);
            this.dtpMFGDate.TabIndex = 3;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSalePrice.Location = new System.Drawing.Point(105, 192);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(225, 22);
            this.txtSalePrice.TabIndex = 7;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalePrice_KeyPress);
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPurchasePrice.Location = new System.Drawing.Point(105, 164);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(225, 22);
            this.txtPurchasePrice.TabIndex = 6;
            this.txtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchasePrice_KeyPress);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtQuantity.Location = new System.Drawing.Point(105, 136);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(225, 22);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // rdbGeneral
            // 
            this.rdbGeneral.AutoSize = true;
            this.rdbGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdbGeneral.Location = new System.Drawing.Point(169, 52);
            this.rdbGeneral.Name = "rdbGeneral";
            this.rdbGeneral.Size = new System.Drawing.Size(74, 20);
            this.rdbGeneral.TabIndex = 0;
            this.rdbGeneral.TabStop = true;
            this.rdbGeneral.Text = "General";
            this.rdbGeneral.UseVisualStyleBackColor = true;
            this.rdbGeneral.CheckedChanged += new System.EventHandler(this.rdbGeneral_CheckedChanged);
            // 
            // rdbMedicine
            // 
            this.rdbMedicine.AutoSize = true;
            this.rdbMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdbMedicine.Location = new System.Drawing.Point(249, 52);
            this.rdbMedicine.Name = "rdbMedicine";
            this.rdbMedicine.Size = new System.Drawing.Size(81, 20);
            this.rdbMedicine.TabIndex = 1;
            this.rdbMedicine.TabStop = true;
            this.rdbMedicine.Text = "Medicine";
            this.rdbMedicine.UseVisualStyleBackColor = true;
            this.rdbMedicine.CheckedChanged += new System.EventHandler(this.rdbMedicine_CheckedChanged);
            // 
            // cmbSelectProduct
            // 
            this.cmbSelectProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cmbSelectProduct.FormattingEnabled = true;
            this.cmbSelectProduct.Location = new System.Drawing.Point(105, 25);
            this.cmbSelectProduct.Name = "cmbSelectProduct";
            this.cmbSelectProduct.Size = new System.Drawing.Size(225, 24);
            this.cmbSelectProduct.TabIndex = 2;
            this.cmbSelectProduct.SelectedIndexChanged += new System.EventHandler(this.cmbSelectProduct_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label17.Location = new System.Drawing.Point(5, 195);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Sale Price";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label16.Location = new System.Drawing.Point(6, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Purchase Price";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.Location = new System.Drawing.Point(7, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Quantity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.Location = new System.Drawing.Point(7, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Exp Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(7, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mfg Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(6, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Select Product";
            // 
            // grpPurchaseItemList
            // 
            this.grpPurchaseItemList.Controls.Add(this.lnkDeleteItem);
            this.grpPurchaseItemList.Controls.Add(this.dgvPurchaseItemList);
            this.grpPurchaseItemList.Controls.Add(this.lnkEditItem);
            this.grpPurchaseItemList.Controls.Add(this.btnClearForm);
            this.grpPurchaseItemList.Controls.Add(this.btnNewPurchase);
            this.grpPurchaseItemList.Controls.Add(this.btnFinalizeProduct);
            this.grpPurchaseItemList.Controls.Add(this.label24);
            this.grpPurchaseItemList.Controls.Add(this.label23);
            this.grpPurchaseItemList.Controls.Add(this.txtNetAmount);
            this.grpPurchaseItemList.Controls.Add(this.txtDiscount);
            this.grpPurchaseItemList.Controls.Add(this.txtTotalAmount);
            this.grpPurchaseItemList.Controls.Add(this.label22);
            this.grpPurchaseItemList.Location = new System.Drawing.Point(746, 28);
            this.grpPurchaseItemList.Name = "grpPurchaseItemList";
            this.grpPurchaseItemList.Size = new System.Drawing.Size(571, 601);
            this.grpPurchaseItemList.TabIndex = 2;
            this.grpPurchaseItemList.TabStop = false;
            this.grpPurchaseItemList.Text = "Purchase Item List";
            // 
            // lnkDeleteItem
            // 
            this.lnkDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkDeleteItem.AutoSize = true;
            this.lnkDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lnkDeleteItem.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkDeleteItem.Location = new System.Drawing.Point(450, 16);
            this.lnkDeleteItem.Name = "lnkDeleteItem";
            this.lnkDeleteItem.Size = new System.Drawing.Size(117, 16);
            this.lnkDeleteItem.TabIndex = 1;
            this.lnkDeleteItem.TabStop = true;
            this.lnkDeleteItem.Text = "Delete Select Item";
            this.lnkDeleteItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDeleteItem_LinkClicked);
            // 
            // dgvPurchaseItemList
            // 
            this.dgvPurchaseItemList.AllowUserToAddRows = false;
            this.dgvPurchaseItemList.AllowUserToDeleteRows = false;
            this.dgvPurchaseItemList.AllowUserToResizeColumns = false;
            this.dgvPurchaseItemList.AllowUserToResizeRows = false;
            this.dgvPurchaseItemList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPurchaseItemList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseItemList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPurchaseItemList.ColumnHeadersHeight = 35;
            this.dgvPurchaseItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCategory,
            this.colProduct,
            this.colCompany,
            this.colBatchNo,
            this.colMFG,
            this.colExpDate,
            this.colPurchasePRice,
            this.colSalePrice,
            this.colQuantity,
            this.colItemCost});
            this.dgvPurchaseItemList.Location = new System.Drawing.Point(6, 45);
            this.dgvPurchaseItemList.MultiSelect = false;
            this.dgvPurchaseItemList.Name = "dgvPurchaseItemList";
            this.dgvPurchaseItemList.ReadOnly = true;
            this.dgvPurchaseItemList.RowHeadersVisible = false;
            this.dgvPurchaseItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseItemList.Size = new System.Drawing.Size(559, 417);
            this.dgvPurchaseItemList.TabIndex = 2;
            // 
            // colCategory
            // 
            this.colCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCategory.HeaderText = "Type";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 56;
            // 
            // colProduct
            // 
            this.colProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            this.colProduct.Width = 69;
            // 
            // colCompany
            // 
            this.colCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCompany.HeaderText = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.ReadOnly = true;
            this.colCompany.Width = 76;
            // 
            // colBatchNo
            // 
            this.colBatchNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBatchNo.HeaderText = "Batch No";
            this.colBatchNo.Name = "colBatchNo";
            this.colBatchNo.ReadOnly = true;
            this.colBatchNo.Width = 71;
            // 
            // colMFG
            // 
            this.colMFG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMFG.HeaderText = "Mfg Date";
            this.colMFG.Name = "colMFG";
            this.colMFG.ReadOnly = true;
            this.colMFG.Width = 70;
            // 
            // colExpDate
            // 
            this.colExpDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colExpDate.HeaderText = "Exp Date";
            this.colExpDate.Name = "colExpDate";
            this.colExpDate.ReadOnly = true;
            this.colExpDate.Width = 70;
            // 
            // colPurchasePRice
            // 
            this.colPurchasePRice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPurchasePRice.HeaderText = "Purchase Price";
            this.colPurchasePRice.Name = "colPurchasePRice";
            this.colPurchasePRice.ReadOnly = true;
            this.colPurchasePRice.Width = 96;
            // 
            // colSalePrice
            // 
            this.colSalePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSalePrice.HeaderText = "Sale Price";
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.ReadOnly = true;
            this.colSalePrice.Width = 74;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 71;
            // 
            // colItemCost
            // 
            this.colItemCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemCost.HeaderText = "Item Cost";
            this.colItemCost.Name = "colItemCost";
            this.colItemCost.ReadOnly = true;
            this.colItemCost.Width = 70;
            // 
            // lnkEditItem
            // 
            this.lnkEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkEditItem.AutoSize = true;
            this.lnkEditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lnkEditItem.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkEditItem.Location = new System.Drawing.Point(344, 16);
            this.lnkEditItem.Name = "lnkEditItem";
            this.lnkEditItem.Size = new System.Drawing.Size(100, 16);
            this.lnkEditItem.TabIndex = 0;
            this.lnkEditItem.TabStop = true;
            this.lnkEditItem.Text = "Edit Select Item";
            this.lnkEditItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditItem_LinkClicked);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClearForm.Location = new System.Drawing.Point(426, 541);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(139, 54);
            this.btnClearForm.TabIndex = 5;
            this.btnClearForm.Text = "Reset";
            this.btnClearForm.UseVisualStyleBackColor = true;
            // 
            // btnNewPurchase
            // 
            this.btnNewPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnNewPurchase.Location = new System.Drawing.Point(6, 541);
            this.btnNewPurchase.Name = "btnNewPurchase";
            this.btnNewPurchase.Size = new System.Drawing.Size(139, 54);
            this.btnNewPurchase.TabIndex = 5;
            this.btnNewPurchase.Text = "New Purchase";
            this.btnNewPurchase.UseVisualStyleBackColor = true;
            // 
            // btnFinalizeProduct
            // 
            this.btnFinalizeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnFinalizeProduct.Location = new System.Drawing.Point(272, 541);
            this.btnFinalizeProduct.Name = "btnFinalizeProduct";
            this.btnFinalizeProduct.Size = new System.Drawing.Size(139, 54);
            this.btnFinalizeProduct.TabIndex = 5;
            this.btnFinalizeProduct.Text = "Finalize Purchase";
            this.btnFinalizeProduct.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label24.Location = new System.Drawing.Point(367, 474);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 16);
            this.label24.TabIndex = 0;
            this.label24.Text = "Net Amount";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label23.Location = new System.Drawing.Point(208, 474);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 16);
            this.label23.TabIndex = 0;
            this.label23.Text = "Discount (%)";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtNetAmount.Location = new System.Drawing.Point(370, 493);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Size = new System.Drawing.Size(195, 29);
            this.txtNetAmount.TabIndex = 5;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDiscount.Location = new System.Drawing.Point(211, 493);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(122, 29);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTotalAmount.Location = new System.Drawing.Point(9, 493);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(155, 29);
            this.txtTotalAmount.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label22.Location = new System.Drawing.Point(6, 474);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "Total Amount";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // frm_NewPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 641);
            this.Controls.Add(this.lblSupplierContactNo);
            this.Controls.Add(this.grpPurchaseItemList);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_NewPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Purchase";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpPurchaseItemList.ResumeLayout(false);
            this.grpPurchaseItemList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox grpPurchaseItemList;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSupplierContactNo;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectProductUnitPrice;
        private System.Windows.Forms.Label lblSelectProductQUantity;
        private System.Windows.Forms.Label lblSelectProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbGeneral;
        private System.Windows.Forms.RadioButton rdbMedicine;
        private System.Windows.Forms.ComboBox cmbSelectProduct;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker dtpEXPDATE;
        private System.Windows.Forms.DateTimePicker dtpMFGDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvPurchaseItemList;
        private System.Windows.Forms.LinkLabel lnkEditItem;
        private System.Windows.Forms.LinkLabel lnkDeleteItem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblSupplierDescription;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnFinalizeProduct;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnNewPurchase;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMFG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchasePRice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCost;
    }
}