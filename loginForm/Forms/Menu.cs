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
using loginForm.Forms;

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

        private const int dp = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= dp;
                return cp;
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            BorrowerForm borrowerForm = new BorrowerForm();
            AddNewTab(borrowerForm);
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            AddNewTab(rf);
        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void AddNewTab(Form frm)
        {
            TabPage tab = new TabPage(frm.Text);

            frm.TopLevel = false;

            frm.Parent = tab;

            frm.Visible = true;
            frm.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(tab);

            frm.Location = new Point((tab.Width - frm.Width) / 2, (tab.Height - frm.Height) / 2);

            tabControl1.SelectedTab = tab;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            BookForm bk = new BookForm();
            AddNewTab(bk);
        }

        private void gunaGradientButton8_Click(object sender, EventArgs e)
        {
            BorrowForm bk = new BorrowForm();
            AddNewTab(bk);
        }

        private void gunaGradientButton9_Click(object sender, EventArgs e)
        {
            ReturnForm bk = new ReturnForm();
            AddNewTab(bk);
        }

        private void gunaBtn_Dashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            AddNewTab(dashboardForm);
        }
    }
}
