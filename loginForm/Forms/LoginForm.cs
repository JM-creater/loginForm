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

        private const int dp = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp =  base.CreateParams;
                cp.ClassStyle |= dp; 
                return cp;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();

            this.Hide();
            reg.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPassword fp = new forgotPassword();
            fp.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var account = User.Login(txt_username.Text, Encrypt(txt_password.Text));
            if (account != null)
            {
                notifyIcon1.BalloonTipTitle = "LOGIN";
                notifyIcon1.BalloonTipText = txt_username.Text + " has Successfully login!";
                notifyIcon1.ShowBalloonTip(100);
                notifyIcon1.Dispose();
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
                notifyIcon1.BalloonTipTitle = "ERROR";
                notifyIcon1.BalloonTipText = "User not found";
                notifyIcon1.ShowBalloonTip(100);
                notifyIcon1.Dispose();
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
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

      
    }
}
