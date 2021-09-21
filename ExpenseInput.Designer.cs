
namespace WindowsExpenseTracker
{
    partial class ExpenseInput
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblInoviceNo = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.cboInvoiceCategory = new System.Windows.Forms.ComboBox();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.invoiceDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cboInvoiceType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(12, 58);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(72, 15);
            this.lblInvoiceDate.TabIndex = 1;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // lblInoviceNo
            // 
            this.lblInoviceNo.AutoSize = true;
            this.lblInoviceNo.Location = new System.Drawing.Point(166, 58);
            this.lblInoviceNo.Name = "lblInoviceNo";
            this.lblInoviceNo.Size = new System.Drawing.Size(67, 15);
            this.lblInoviceNo.TabIndex = 3;
            this.lblInoviceNo.Text = "Invoice No.";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(166, 76);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(125, 23);
            this.txtInvoiceNo.TabIndex = 4;
            this.txtInvoiceNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtInvoiceNo_Validating);
            // 
            // cboInvoiceCategory
            // 
            this.cboInvoiceCategory.FormattingEnabled = true;
            this.cboInvoiceCategory.Items.AddRange(new object[] {
            "Food",
            "Admin",
            "Kitchen",
            "Cleaning",
            "Miscellaneous"});
            this.cboInvoiceCategory.Location = new System.Drawing.Point(166, 120);
            this.cboInvoiceCategory.Name = "cboInvoiceCategory";
            this.cboInvoiceCategory.Size = new System.Drawing.Size(125, 23);
            this.cboInvoiceCategory.TabIndex = 8;
            this.cboInvoiceCategory.Validating += new System.ComponentModel.CancelEventHandler(this.cboInvoiceCategory_Validating);
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Location = new System.Drawing.Point(166, 102);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(96, 15);
            this.lblItemCategory.TabIndex = 7;
            this.lblItemCategory.Text = "Invoice Category";
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(12, 146);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(79, 15);
            this.lblVendorName.TabIndex = 9;
            this.lblVendorName.Text = "Vendor Name";
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(12, 164);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(125, 23);
            this.txtVendorName.TabIndex = 10;
            this.txtVendorName.Validating += new System.ComponentModel.CancelEventHandler(this.txtVendorName_Validating);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(166, 146);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 15);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(166, 164);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(125, 23);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.Enter += new System.EventHandler(this.txtTotal_Enter);
            this.txtTotal.Validating += new System.ComponentModel.CancelEventHandler(this.txtTotal_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(112, 214);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.CausesValidation = false;
            this.btnSearch.Location = new System.Drawing.Point(12, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // invoiceDateCalendar
            // 
            this.invoiceDateCalendar.Location = new System.Drawing.Point(35, 47);
            this.invoiceDateCalendar.Name = "invoiceDateCalendar";
            this.invoiceDateCalendar.TabIndex = 20;
            this.invoiceDateCalendar.Visible = false;
            this.invoiceDateCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.invoiceDateCalendar_DateChanged);
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(12, 76);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.Size = new System.Drawing.Size(125, 23);
            this.txtInvoiceDate.TabIndex = 2;
            this.txtInvoiceDate.DoubleClick += new System.EventHandler(this.txtInvoiceDate_OnDoubleClick);
            this.txtInvoiceDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtInvoiceDate_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Invoice Type";
            // 
            // cboInvoiceType
            // 
            this.cboInvoiceType.FormattingEnabled = true;
            this.cboInvoiceType.Items.AddRange(new object[] {
            "Cash",
            "Credit",
            "Debit",
            "Check",
            "Tim",
            "Pui"});
            this.cboInvoiceType.Location = new System.Drawing.Point(12, 120);
            this.cboInvoiceType.Name = "cboInvoiceType";
            this.cboInvoiceType.Size = new System.Drawing.Size(125, 23);
            this.cboInvoiceType.TabIndex = 22;
            this.cboInvoiceType.Validating += new System.ComponentModel.CancelEventHandler(this.cboInvoiceType_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Location = new System.Drawing.Point(215, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ExpenseInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 251);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.invoiceDateCalendar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboInvoiceType);
            this.Controls.Add(this.txtInvoiceDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.lblItemCategory);
            this.Controls.Add(this.cboInvoiceCategory);
            this.Controls.Add(this.lblInoviceNo);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.lblInvoiceDate);
            this.Name = "ExpenseInput";
            this.Text = "Clear";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblInoviceNo;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.ComboBox cboInvoiceCategory;
        private System.Windows.Forms.Label lblItemCategory;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MonthCalendar invoiceDateCalendar;
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboInvoiceType;
        private System.Windows.Forms.Button btnCancel;
    }
}

