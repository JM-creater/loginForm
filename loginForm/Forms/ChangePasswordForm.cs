using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using login.form;

namespace loginForm.Forms
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Database.ConnectionString);
            connect.Open();
            string username = txt_username.Text;
            string password = txt_curpass.Text;
            string newPassword = txt_newpass.Text;
            string confirmPassword = txt_confirmpass.Text;
            string sqlquery = "UPDATE dbo.table_user SET User_password=@newpass where User_username=@username";
            SqlCommand cmd = new SqlCommand(sqlquery, connect);
            cmd.Parameters.AddWithValue("@newpass", txt_confirmpass.Text);
            cmd.Parameters.AddWithValue("@username", txt_username.Text);
            cmd.Parameters.AddWithValue("@password", txt_curpass.Text);
            cmd.Connection = connect;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((txt_newpass.Text == reader["newPassword"].ToString()) & (txt_confirmpass.Text == (reader["confirmPassword"].ToString()))) { }
            }
            MessageBox.Show("Password Changed Successfully!");
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }
    }
}
