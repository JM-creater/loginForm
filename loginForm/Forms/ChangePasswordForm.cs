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
            if (string.IsNullOrWhiteSpace(txt_curpass.Text) || string.IsNullOrWhiteSpace(txt_newpass.Text) || string.IsNullOrWhiteSpace(txt_confirmpass.Text) || string.IsNullOrWhiteSpace(txt_username.Text))
            {
                MessageBox.Show("All fields must be filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (txt_newpass.Text != txt_confirmpass.Text)
            {
                MessageBox.Show("New password and Confirm password fields does not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                SqlConnection conn = new SqlConnection(Database.ConnectionString);
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM dbo.table_user WHERE User_username = @username", conn);
                    command.Parameters.AddWithValue("@username", txt_username.Text);
                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        DialogResult cpR = MessageBox.Show("This username is not registered. Would you like to register first?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        //if (cpR == DialogResult.Yes)
                        //{
                            //Registration_Form rForm = new Registration_Form();
                            //this.Hide();
                            //rForm.Show();
                        //}
                        //return;
                    }
                    else
                    {
                        command = new SqlCommand("UPDATE dbo.table_user SET User_password = @newpass WHERE User_username = @username AND User_password = @password", conn);

                        string encryptedNewPass = Encrypt(txt_newpass.Text);

                        command.Parameters.AddWithValue("@newpass", encryptedNewPass);
                        command.Parameters.AddWithValue("@username", txt_username.Text);
                        command.Parameters.AddWithValue("@password", Encrypt(txt_curpass.Text));

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
                            MessageBox.Show("Incorrect current password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
        }

        public static string Encrypt(string encryptString)
        {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement    
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
            });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }
    }
}
