using login.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForm.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            countBooks();
            countBorrower();
            qtyBooks();
        }

        SqlConnection con = new SqlConnection(Database.ConnectionString);

        private void countBooks()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Table_Book", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            bookLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void countBorrower()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Table_Borrower", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblBorrower.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void qtyBooks()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(Book_Quantity) FROM Table_Book", con);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
               int qty = (int)result;
               lblqtyBooks.Text = qty.ToString();
            }
            con.Close();
        }

    }
}
