using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login.form;
using loginForm.Forms;

namespace loginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register reg = new Register();

            this.Hide();
            reg.Show();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var account = User.Login(txt_username.Text, Encrypt(txt_password.Text));
            if(account != null) 
            {
                MessageBox.Show("Successfully login!","Log In", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Menu menu = new Menu();
                menu.Source = account;

                menu.Show();
                this.Hide();
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
            else
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
        }

        private void chkShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowHide.CheckState == CheckState.Checked) 
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else 
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";     
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        public static string Encrypt(string encryptString)
        {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio"; 
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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
