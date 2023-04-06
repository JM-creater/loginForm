using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using login.form;
using Microsoft.VisualBasic;

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
            SqlConnection conn = new SqlConnection(Database.ConnectionString);

            try
            {
                conn.Open();
                string sqlQuery = "UPDATE dbo.table_user SET User_password=@newpass WHERE User_username=@username AND User_password=@password";
                SqlCommand command = new SqlCommand(sqlQuery, conn);
                command.Parameters.AddWithValue("@newpass", txt_newpass.Text);
                command.Parameters.AddWithValue("@username", txt_username.Text);
                command.Parameters.AddWithValue("@password", txt_curpass.Text);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginForm login = new LoginForm();
                    this.Close();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or current password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }
    }
}
