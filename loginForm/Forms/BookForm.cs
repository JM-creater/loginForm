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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            if (txt_BookTitle.Text != "" && txt_BookAuthor.Text != "" && numeric_BookQty.Value != 0)
            {
                Book.Create(txt_BookTitle.Text, txt_BookAuthor.Text, ((int)numeric_BookQty.Value));
                MessageBox.Show("You've Successfully Added Book", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_BookTitle.Clear();
                txt_BookAuthor.Clear();
                txt_BookTitle.Focus();
                numeric_BookQty.Value = 1;
                loadData();
            }

            else if (txt_BookTitle.Text != "" && txt_BookAuthor.Text == "" && numeric_BookQty.Value != 0)
            {
                MessageBox.Show("Please Input the Book Author", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_BookTitle.Text == "" && txt_BookAuthor.Text != "" && numeric_BookQty.Value != 0)
            {
                MessageBox.Show("Please Input the Book Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_BookTitle.Text != "" && txt_BookAuthor.Text != "" && numeric_BookQty.Value == 0)
            {
                MessageBox.Show("Please Input the Book Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please Input the Book Title, Book Author and Book Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_SearchBox_TextChanged(object sender, EventArgs e)
        {
            var dt = Book.getDataFromSearch(txt_SearchBox.Text);
            datagrid_Book.DataSource = dt;

            dt.Columns["Book_ID"].ColumnName = "ID";
            dt.Columns["Book_Title"].ColumnName = "Book Title";
            dt.Columns["Book_Author"].ColumnName = "Book Author";
            dt.Columns["Book_Quantity"].ColumnName = "Book Quantity";
        }

        public void loadData()
        {
            var dt = Book.getAllData();
            datagrid_Book.DataSource = dt;

            dt.Columns["Book_ID"].ColumnName = "ID";
            dt.Columns["Book_Title"].ColumnName = "Book Title";
            dt.Columns["Book_Author"].ColumnName = "Book Author";
            dt.Columns["Book_Quantity"].ColumnName = "Book Quantity";
        }

        private void Book_Load(object sender, EventArgs e)
        {
            loadData();
            txt_SearchBox.Text = "Search";
            txt_SearchBox.ForeColor = SystemColors.GrayText;
        }

        private void datagrid_Book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = datagrid_Book.Rows[e.RowIndex];

            txt_BookID.Text = datagrid_Book.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txt_BookTitle.Text = datagrid_Book.Rows[e.RowIndex].Cells["Book Title"].Value.ToString();
            txt_BookAuthor.Text = datagrid_Book.Rows[e.RowIndex].Cells["Book Author"].Value.ToString();
            numeric_BookQty.Value = int.Parse(datagrid_Book.Rows[e.RowIndex].Cells["Book Quantity"].Value.ToString());
        }

        private void btn_EditBook_Click(object sender, EventArgs e)
        {
            if (txt_BookID.Text != "")
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Book.Update(txt_BookID.Text, txt_BookTitle.Text, txt_BookAuthor.Text, ((int)numeric_BookQty.Value));
                    txt_BookID.Clear();
                    txt_BookTitle.Clear();
                    txt_BookAuthor.Clear();
                    txt_BookTitle.Focus();
                    numeric_BookQty.Value = 0;
                    loadData();
                    MessageBox.Show("You've successfully Edited Book", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Select Book that you want to Edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DeleteBook_Click(object sender, EventArgs e)
        {
            if (txt_BookID.Text != "")
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Book.Delete(txt_BookID.Text);
                    txt_BookID.Clear();
                    txt_BookTitle.Clear();
                    txt_BookAuthor.Clear();
                    txt_BookTitle.Focus();
                    loadData();
                    MessageBox.Show("You've successfully Delete Book", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Select Book that you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_SearchBox_Click(object sender, EventArgs e)
        {
            if (txt_SearchBox.Text != "")
            {
                txt_SearchBox.Clear();
            }
        }
    }
}
