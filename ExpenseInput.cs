using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsExpenseTracker
{
    public partial class ExpenseInput : Form
    {
        public ExpenseInput()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO: Connect to database.

        }
        private void txtInvoiceDate_OnDoubleClick(object sender, EventArgs e)
        {
            //Opens Invoice Date Calendar
            invoiceDateCalendar.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddExpense(txtInvoiceDate.Text, txtInvoiceNo.Text, cboInvoiceType.Text, cboInvoiceCategory.Text, txtVendorName.Text, txtTotal.Text);
        }

        private void invoiceDateCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Sets Invoice Date text box text to the selected date.
            txtInvoiceDate.Text = invoiceDateCalendar.SelectionEnd.ToShortDateString();

            invoiceDateCalendar.Visible = false;
        }

        // Validates the Invoice Date Text Box
        private void txtInvoiceDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime dDate;

            // Checks if the Invoice Date textbox is empty.
            if (string.IsNullOrEmpty(txtInvoiceDate.Text))
            {
                e.Cancel = true;
                txtInvoiceDate.Focus();
                errorProvider1.SetError(txtInvoiceDate, "Should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtInvoiceDate, "");

                // Checks if the Invoice Date textbox is not in the proper formnat.
                if (DateTime.TryParse(txtInvoiceDate.Text, out dDate))
                {
                    String.Format("{0:d/MM/yyyy}", dDate);
                    e.Cancel = false;
                    errorProvider1.SetError(txtInvoiceDate, "");
                }
                else
                {
                    e.Cancel = true;
                    txtInvoiceDate.Focus();
                    errorProvider1.SetError(txtInvoiceDate, "Should be in MM/DD/YYYY format!");
                }
            }
        }

        private void txtInvoiceNo_Validating(object sender, CancelEventArgs e)
        {
            SpecialCharValidation(txtInvoiceNo, e);
        }

        private void txtVendorName_Validating(object sender, CancelEventArgs e)
        {
            SpecialCharValidation(txtVendorName, e);
            //TODO: Check database for vendor.
            //If no match open Add Vendor Window.
        }

        private void cboInvoiceCategory_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboInvoiceCategory.Text))
            {
                e.Cancel = true;
                cboInvoiceCategory.Focus();
                errorProvider1.SetError(cboInvoiceCategory, "Should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboInvoiceCategory, "");
            }
        }
        private void cboInvoiceType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboInvoiceType.Text))
            {
                e.Cancel = true;
                cboInvoiceType.Focus();
                errorProvider1.SetError(cboInvoiceType, "Should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboInvoiceType, "");
            }
        }

        private void txtTotal_Validating(object sender, CancelEventArgs e)
        {
            NumericValidation(txtTotal, e);
        }

        public void SpecialCharValidation(TextBox toBeValidated, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(toBeValidated.Text))
            {
                e.Cancel = true;
                toBeValidated.Focus();
                errorProvider1.SetError(toBeValidated, "Should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(toBeValidated, "");

                if (toBeValidated.Text.Any(ch => !char.IsLetterOrDigit(ch)))
                {
                    if (toBeValidated.Text.Contains(" "))
                    {
                        return;
                    }
                    e.Cancel = true;
                    toBeValidated.Focus();
                    errorProvider1.SetError(toBeValidated, "Should not contain special characters!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(toBeValidated, "");
                }
            }
        }

        public void NumericValidation(TextBox toBeValidated, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(toBeValidated.Text))
            {
                e.Cancel = true;
                toBeValidated.Focus();
                errorProvider1.SetError(toBeValidated, "Should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(toBeValidated, "");

                if (toBeValidated.Text.Any(ch => !char.IsDigit(ch)))
                {
                    if (toBeValidated.Text.Contains("."))
                    {
                        return;
                    }
                    e.Cancel = true;
                    toBeValidated.Focus();
                    errorProvider1.SetError(toBeValidated, "Should contain only numbers and .");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(toBeValidated, "");
                }
            }
        }

        public void AddExpense(string invoiceDate, string invoiceNo, string invoiceType, string invoiceCategory, string vendorName, string total)
        {
            try
            {
                string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jeske\source\repos\WindowsExpenseTracker\Database\WindowsExpenseTracker.accdb";

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    using (OleDbCommand command = conn.CreateCommand())
                    {

                        command.CommandText = "INSERT INTO Expenses (InvoiceDate, InvoiceNumber, InvoiceType, InvoiceCategory, VendorName, Total) VALUES (@param1, @param2, @param3, @param4, @param5, @param6);";

                        command.Parameters.AddWithValue("@param1", invoiceDate);
                        command.Parameters.AddWithValue("@param2", invoiceNo);
                        command.Parameters.AddWithValue("@param3", invoiceType);
                        command.Parameters.AddWithValue("@param4", invoiceCategory);
                        command.Parameters.AddWithValue("@param5", vendorName);
                        command.Parameters.AddWithValue("@param6", total);

                        command.ExecuteNonQuery();

                        conn.Close();
                        conn.Dispose();
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        private void txtTotal_Enter(object sender, EventArgs e)
        {
            double total;

            Double.TryParse(txtTotal.Text, out total);

            txtTotal.Text = total.ToString("0.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInvoiceDate.Text = null;
            txtInvoiceNo.Text = null;
            cboInvoiceType.Text = null;
            cboInvoiceCategory.Text = null;
            txtVendorName.Text = null;
            txtTotal.Text = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form search = new ExpenseSearch();

            search.Show();

            AutoValidate = AutoValidate.Disable;
            Application.OpenForms["ExpenseInput"].Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            this.Close();
        }
    }
}
