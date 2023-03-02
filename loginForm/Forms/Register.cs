using login.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace loginForm
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public static bool IsValidPass(string newPass)
        {
            string strRegex = @"^(?:[A-Z][a-zA-Z0-9_\W]+)?$"; //@"^[A-Z][a-zA-Z0-9_\W]+$"
            Regex reg = new Regex(strRegex);
            if (reg.IsMatch(newPass))
            {
                return true;
            }
            else
            {
                return false;  
            }
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement, but the decryption key should be same as encryption key    
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

        private void btn_signup_Click(object sender, EventArgs e)
        {
            var acc = User.Read(txt_user.Text);
            
            if (txt_user.Text != "" && txt_pass.Text == txt_conpass.Text && acc == null)
            {
                User.Create(txt_user.Text.ToLower(), Encrypt(txt_pass.Text));
                MessageBox.Show("You Have Successfully Registered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_user.Clear();
                txt_pass.Clear();
                txt_conpass.Clear();
                txt_user.Focus();

            }
            else
            {
                MessageBox.Show("Unable to register!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_user.Clear();
                txt_pass.Clear();
                txt_conpass.Clear();
                txt_user.Focus();
            }
        }
    }
}
