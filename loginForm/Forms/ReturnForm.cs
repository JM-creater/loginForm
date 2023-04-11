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
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            var dt = Transaction.getAllUnReturendBooks();
            datagrid_Transaction.DataSource = dt;
        }

        private void datagrid_Transaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = datagrid_Transaction.Rows[e.RowIndex];

            txt_ID.Text = datagrid_Transaction.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txt_BookTitle.Text = datagrid_Transaction.Rows[e.RowIndex].Cells["Book Title"].Value.ToString();
            txt_Fullname.Text = datagrid_Transaction.Rows[e.RowIndex].Cells["Full Name"].Value.ToString();
            txt_IsReturned.Text = datagrid_Transaction.Rows[e.RowIndex].Cells["Returned"].Value.ToString();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            if (txt_IsReturned.Text != "True" && txt_ID.Text != "")
            {
                var IsReturned = 1;
                Transaction.Update(txt_ID.Text, IsReturned, DateTime.Now);
                MessageBox.Show("You've Successfully Returned the Book", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //notifyIcon1.BalloonTipText = "You've Successfully Returned the Book";
                //notifyIcon1.ShowBalloonTip(100);
                //notifyIcon1.Dispose();
                
                txt_IsReturned.Clear();
                txt_BookTitle.Clear();
                txt_Fullname.Clear();
                txt_ID.Clear();
                loadData();
            }
            else if (txt_IsReturned.Text == "True")
            {
                MessageBox.Show("You've Already Returned the Book", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //notifyIcon1.BalloonTipText = "You've Already Returned the Book";
                //notifyIcon1.ShowBalloonTip(100);
                //notifyIcon1.Dispose();

            }
            else
            {
                MessageBox.Show("Please Select Data that you want to return a book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //notifyIcon1.BalloonTipText = "Please Select Data that you want to return a book";
                //notifyIcon1.ShowBalloonTip(100);
                //notifyIcon1.Dispose();
            }
        }

        private void ReturnForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnForm returnForm = new ReturnForm();
            returnForm.Close();
        }
    }
}
