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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private User _account;

        public User Source
        {
            get { return _account; }
            set { _account = value; }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowerForm bw = new BorrowerForm();
            bw.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bk = new BookForm();
            bk.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionForm tf = new TransactionForm();
            tf.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            rf.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }
    }
}
