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
        //string Title, BName;
        //DateTime BorrowedDate, ReturnedDate;
        //bool Return;
        //int pos = 60;
        private bool isChartVisible = false;

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

        private void btn_Print_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (datagrid_Reports.Rows.Count == 0)
            {
                MessageBox.Show("No data to print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Printing cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Transaction transaction = new Transaction();
            DataTable dt = Transaction.getAllTransaction(DTP_start.Value, DTP_end.Value);

            e.Graphics.DrawString("Library System", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("Title Name BorrowedDate ReturnedDate Return", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));

            Font font = new Font("Arial", 12, FontStyle.Regular);
            int margin = 50;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                e.Graphics.DrawString(dt.Rows[i]["Book Title"].ToString(), font, Brushes.Black, margin, margin + (i * 20));
                e.Graphics.DrawString(dt.Rows[i]["Full Name"].ToString(), font, Brushes.Black, margin + 100, margin + (i * 20));
                e.Graphics.DrawString(dt.Rows[i]["Borrowed Date"].ToString(), font, Brushes.Black, margin + 200, margin + (i * 20));
                e.Graphics.DrawString(dt.Rows[i]["Returned Date"].ToString(), font, Brushes.Black, margin + 300, margin + (i * 20));
                e.Graphics.DrawString(dt.Rows[i]["Returned"].ToString(), font, Brushes.Black, margin + 400, margin + (i * 20));
            }
        }

        private void btn_graphical_Click(object sender, EventArgs e)
        {
            if (isChartVisible)
            {
                chart1.Hide();
                isChartVisible = false;
            }
            else
            {
                var dt = Transaction.getAllTransaction(DTP_start.Value, DTP_end.Value);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                chart1.DataSource = dt;
                chart1.Titles.Add("Books Returned");
                chart1.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);
                chart1.Titles[0].ForeColor = Color.Black;
                chart1.Series[0].XValueMember = "Book Title";
                chart1.Series[0].YValueMembers = "Returned";
                chart1.DataBind();

                chart1.Show();
                isChartVisible = true;
            }
        }
    }
}
