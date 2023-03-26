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
                Borrower.Create(txt_Firstname.Text, txt_Lastname.Text);
                MessageBox.Show("You've Successfully Added Borrower", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Firstname.Clear();
                txt_Lastname.Clear();
                txt_Firstname.Focus();
                loadData();
            }

            else if (txt_Firstname.Text != "" && txt_Lastname.Text == "")
            {
                MessageBox.Show("Please Input the Borrower Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Firstname.Text == "" && txt_Lastname.Text != "")
            {
                MessageBox.Show("Please Input the Borrower First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please Input the Book Title, Book Author and Book Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("You've successfully Edited Borrower", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Select Borrower that you want to Edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("You've successfully Delete Borrower", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Select Borrower that you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
