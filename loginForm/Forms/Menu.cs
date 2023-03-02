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
          
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
