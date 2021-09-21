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

namespace WindowsExpenseTracker
{
    public partial class ExpenseSearch : Form
    {
        public ExpenseSearch()
        {
            InitializeComponent();
        }

        private void ExpenseSearch_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jeske\source\repos\WindowsExpenseTracker\Database\WindowsExpenseTracker.accdb";

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    using (OleDbCommand command = conn.CreateCommand())
                    {

                        command.CommandText = "SELECT * FROM Expenses WHERE " + cboSearchCategory.Text + " like '%" + txtSearchCriteria.Text + "%'";

                        Debug.WriteLine(command.CommandText);

                        OleDbDataAdapter da = new OleDbDataAdapter(command.CommandText, conn);

                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }

                        conn.Close();
                        conn.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
