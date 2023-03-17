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


namespace loginForm
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            var dt = Transaction.getAllTransaction(DTP_start.Value, DTP_end.Value);
            datagrid_Reports.DataSource = dt;
        }

        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Close();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
