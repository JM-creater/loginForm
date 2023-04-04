using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
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

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            if (txt_BookTitle.Text != "" && txt_BookAuthor.Text != "" && numeric_BookQty.Value != 0)
            {
                DataTable dt = Book.IsAlreadyExistBook(txt_BookTitle.Text, txt_BookAuthor.Text);
                if (dt.Rows.Count > 0)
                {
                    notifyIcon2.BalloonTipTitle = "Error";
                    notifyIcon2.BalloonTipText = "Book Already Exists";
                    notifyIcon2.ShowBalloonTip(100);
                    notifyIcon2.Dispose();
                    return;
                }

                Book.Create(txt_BookTitle.Text, txt_BookAuthor.Text, ((int)numeric_BookQty.Value));
                notifyIcon1.BalloonTipTitle = "Information";
                notifyIcon1.BalloonTipText = "You've Successfully Added Book";
                notifyIcon1.ShowBalloonTip(100);
                notifyIcon1.Dispose();

                txt_BookTitle.Clear();
                txt_BookAuthor.Clear();
                txt_BookTitle.Focus();
                numeric_BookQty.Value = 1;
                loadData();
            }

            else if (txt_BookTitle.Text != "" && txt_BookAuthor.Text == "" && numeric_BookQty.Value != 0)
            {
                notifyIcon2.BalloonTipTitle = "Error";
                notifyIcon2.BalloonTipText = "Please Input the Book Author";
                notifyIcon2.ShowBalloonTip(100);
                notifyIcon2.Dispose();
            }
            else if (txt_BookTitle.Text == "" && txt_BookAuthor.Text != "" && numeric_BookQty.Value != 0)
            {
                notifyIcon2.BalloonTipTitle = "Error";
                notifyIcon2.BalloonTipText = "Please Input the Book Title";
                notifyIcon2.ShowBalloonTip(100);
                notifyIcon2.Dispose();
            }
            else if (txt_BookTitle.Text != "" && txt_BookAuthor.Text != "" && numeric_BookQty.Value == 0)
            {
                notifyIcon2.BalloonTipTitle = "Error";
                notifyIcon2.BalloonTipText = "Please Input the Book Quantity";
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

        private void txt_SearchBox_TextChanged(object sender, EventArgs e)
        {
            var dt = Book.getDataFromSearch(txt_SearchBox.Text);
            dt.DefaultView.RowFilter = "Book_Quantity > 0";
            datagrid_Book.DataSource = dt.DefaultView;

            dt.Columns["Book_ID"].ColumnName = "ID";
            dt.Columns["Book_Title"].ColumnName = "Book Title";
            dt.Columns["Book_Author"].ColumnName = "Book Author";
            dt.Columns["Book_Quantity"].ColumnName = "Book Quantity";
        }

        public void loadData()
        {
            var dt = Book.getAllData();
            dt.DefaultView.RowFilter = "Book_Quantity > 0";
            datagrid_Book.DataSource = dt.DefaultView;

            dt.Columns["Book_ID"].ColumnName = "ID";
            dt.Columns["Book_Title"].ColumnName = "Book Title";
            dt.Columns["Book_Author"].ColumnName = "Book Author";
            dt.Columns["Book_Quantity"].ColumnName = "Book Quantity";
        }

        private void Book_Load(object sender, EventArgs e)
        {
            loadData();
            //txt_SearchBox.Text = "Search";
            //txt_SearchBox.ForeColor = SystemColors.GrayText;
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
                    notifyIcon1.BalloonTipTitle = "Information";
                    notifyIcon1.BalloonTipText = "You've successfully Edited Book";
                    notifyIcon1.ShowBalloonTip(100);
                    notifyIcon1.Dispose();
                }
            }
            else
            {
                notifyIcon2.BalloonTipTitle = "Error";
                notifyIcon2.BalloonTipText = "Please Select Book that you want to Edit";
                notifyIcon2.ShowBalloonTip(100);
                notifyIcon2.Dispose();
            }
        }

        private void btn_DeleteBook_Click(object sender, EventArgs e)
        {
            if (txt_BookID.Text != "")
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    DialogResult confirmRes = MessageBox.Show("Are you sure you want to permanently delete the data from the database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmRes == DialogResult.Yes)
                    {
                        Book.Delete(txt_BookID.Text);
                        txt_BookID.Clear();
                        txt_BookTitle.Clear();
                        txt_BookAuthor.Clear();
                        txt_BookTitle.Focus();
                        loadData();
                        notifyIcon1.BalloonTipTitle = "Information";
                        notifyIcon1.BalloonTipText = "You've successfully Delete Book";
                        notifyIcon1.ShowBalloonTip(100);
                        notifyIcon1.Dispose();
                    }
                }
            }
            else
            {
                notifyIcon2.BalloonTipTitle = "Error";
                notifyIcon2.BalloonTipText = "Please Select Book that you want to delete";
                notifyIcon2.ShowBalloonTip(100);
                notifyIcon2.Dispose();
            }
        }
    }
}
