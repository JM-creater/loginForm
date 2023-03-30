using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login.form;

namespace loginForm
{
    public partial class BorrowerForm : Form
    {
        public BorrowerForm()
        {
            InitializeComponent();
        }

        private void Borrower_Load(object sender, EventArgs e)
        {
            loadData();
            txt_FnameSearch.Text = "Search";
            txt_FnameSearch.ForeColor = SystemColors.GrayText;
        }

        private void btn_AddBorrower_Click(object sender, EventArgs e)
        {

            if (txt_Firstname.Text != "" && txt_Lastname.Text != "")
            {
                DataTable dt = Borrower.IsAlreadyExistBorrower(txt_Firstname.Text, txt_Lastname.Text);
                if (dt.Rows.Count > 0)
                {
                    notifyIcon2.BalloonTipTitle = "Error";
                    notifyIcon2.BalloonTipText = "Borrower Already Exists";
                    notifyIcon2.ShowBalloonTip(100);
                    notifyIcon2.Dispose();
                    return;
                }

                Borrower.Create(txt_Firstname.Text, txt_Lastname.Text);
                notifyIcon1.BalloonTipTitle = "Information";
                notifyIcon1.BalloonTipText = "You've Successfully Added Borrower";
                notifyIcon1.ShowBalloonTip(100);
                notifyIcon1.Dispose();
                txt_Firstname.Clear();
                txt_Lastname.Clear();
                txt_Firstname.Focus();
                loadData();
            }

            else if (txt_Firstname.Text != "" && txt_Lastname.Text == "")
            {
                notifyIcon2.BalloonTipTitle = "Error";
                notifyIcon2.BalloonTipText = "Please Input the Borrower Last Name";
                notifyIcon2.ShowBalloonTip(100);
                notifyIcon2.Dispose();
            }
            else if (txt_Firstname.Text == "" && txt_Lastname.Text != "")
            {
                notifyIcon2.BalloonTipTitle = "Error";
                notifyIcon2.BalloonTipText = "Please Input the Borrower First Name";
                notifyIcon2.ShowBalloonTip(100);
                notifyIcon2.Dispose();
            }
            else
            {
                notifyIcon2.BalloonTipTitle = "Error";
                notifyIcon2.BalloonTipText = "Please Input the Book Title, Book Author and Book Quantity";
                notifyIcon2.ShowBalloonTip(100);
                notifyIcon2.Dispose();
            }
        }

        private void btn_EditBorrower_Click(object sender, EventArgs e)
        {
            if (txt_BorrowerID.Text != "")
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Borrower.Update(txt_BorrowerID.Text, txt_Firstname.Text, txt_Lastname.Text);
                    txt_BorrowerID.Clear();
                    txt_Firstname.Clear();
                    txt_Lastname.Clear();
                    txt_Firstname.Focus();
                    loadData();
                    notifyIcon1.BalloonTipTitle = "Information";
                    notifyIcon1.BalloonTipText = "You've successfully Edited Borrower";
                    notifyIcon1.ShowBalloonTip(100);
                    notifyIcon1.Dispose();
                }
            }
            else
            {
                notifyIcon2.BalloonTipTitle = "Error";
                notifyIcon2.BalloonTipText = "Please Select Borrower that you want to Edit";
                notifyIcon2.ShowBalloonTip(100);
                notifyIcon2.Dispose();
            }
        }

        private void btn_UpdateBorrower_Click(object sender, EventArgs e)
        {
            if (txt_BorrowerID.Text != "")
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Borrower.Delete(txt_BorrowerID.Text);
                    txt_BorrowerID.Clear();
                    txt_Firstname.Clear();
                    txt_Lastname.Clear();
                    txt_Firstname.Focus();
                    loadData();
                    notifyIcon1.BalloonTipTitle = "Information";
                    notifyIcon1.BalloonTipText = "You've successfully Delete Borrower";
                    notifyIcon1.ShowBalloonTip(100);
                    notifyIcon1.Dispose();
                }
            }
            else
            {
                notifyIcon2.BalloonTipTitle = "Error";
                notifyIcon2.BalloonTipText = "Please Select Borrower that you want to delete";
                notifyIcon2.ShowBalloonTip(100);
                notifyIcon2.Dispose();
            }
        }

        public void loadData()
        {
            var dt = Borrower.getAllData();
            datagrid_Borrower.DataSource = dt;

            dt.Columns["Borrower_ID"].ColumnName = "ID";
            dt.Columns["Borrower_Fname"].ColumnName = "First Name";
            dt.Columns["Borrower_Lname"].ColumnName = "Last Name";
        }

        private void txt_FnameSearch_TextChanged(object sender, EventArgs e)
        {
            var dt = Borrower.getDataFromSearch(txt_FnameSearch.Text);
            datagrid_Borrower.DataSource = dt;

            dt.Columns["Borrower_ID"].ColumnName = "ID";
            dt.Columns["Borrower_Fname"].ColumnName = "First Name";
            dt.Columns["Borrower_Lname"].ColumnName = "Last Name";
        }

        private void datagrid_Borrower_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = datagrid_Borrower.Rows[e.RowIndex];

            txt_BorrowerID.Text = datagrid_Borrower.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txt_Firstname.Text = datagrid_Borrower.Rows[e.RowIndex].Cells["First Name"].Value.ToString();
            txt_Lastname.Text = datagrid_Borrower.Rows[e.RowIndex].Cells["Last Name"].Value.ToString();
        }

        private void BorrowerForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            BorrowerForm borrow = new BorrowerForm();
            borrow.Close();
        }
    }
}
