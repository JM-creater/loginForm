using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace loginForm.Forms
{
    public partial class loadingScreenForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int RightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse

            );

        public loadingScreenForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Progressbar1.Value = 0;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Progressbar1.Value += 1;
            Progressbar1.Text = Progressbar1.Value.ToString() + "%";

            if ( Progressbar1.Value == 100 ) 
            {
                timer1.Enabled = false;
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
        }
    }
}
