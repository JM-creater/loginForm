using login.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
using System.Windows.Forms;

namespace loginForm.Forms
{
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            try
            {
                var dtt = Transaction.getDataBookTitle().AsEnumerable().Where(myRow => myRow.Field<int>("Book_ID") == int.Parse(cb_Books.SelectedValue.ToString())).CopyToDataTable();
                if (dtt != null)
                {
                    Menu menu = new Menu();
                    Book.Update(dtt.Rows[0]["Book_ID"].ToString(), dtt.Rows[0]["Book_Title"].ToString(), dtt.Rows[0]["Book_Author"].ToString(), int.Parse(dtt.Rows[0]["Book_Quantity"].ToString()) - 1);
                    Transaction.Create(cb_Books.SelectedValue.ToString(), cb_Borrowers.SelectedValue.ToString(), DateTime.Now);
                    notifyIcon1.BalloonTipText = "You've Successfully Borrowed A Book";
                    notifyIcon1.ShowBalloonTip(100);
                    notifyIcon1.Dispose();
                    fillComboBox();
                }
            }
            catch (Exception)
            {

                Menu menu = new Menu(); ;
                notifyIcon1.BalloonTipText = "No Available Books";
                notifyIcon1.ShowBalloonTip(100);
                notifyIcon1.Dispose();
                fillComboBox();
            }
        }

        public void fillComboBox()
        {
            DataTable dt = Transaction.getDataBorrowerName();
            cb_Borrowers.DataSource = dt;
            cb_Borrowers.ValueMember = dt.Columns["Borrower_ID"].ToString();
            cb_Borrowers.DisplayMember = dt.Columns["Fullname"].ToString();

            var dtt = Transaction.getDataBookTitle();
            cb_Books.DataSource = dtt;
            cb_Books.DisplayMember = dtt.Columns["Book_Title"].ToString();
            cb_Books.ValueMember = dtt.Columns["Book_ID"].ToString();
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            fillComboBox();
        }

        private void BorrowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Close();
        }
    }
}
