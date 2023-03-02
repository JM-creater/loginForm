using login.form;
using MaterialSkin;
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

namespace loginForm.Forms
{
    public partial class forgotPassword : Form
    {
        public forgotPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void materialEnter_Click(object sender, EventArgs e)
        {
            if (materialUser.Text != "")
            {
                SqlConnection con = new SqlConnection(Database.ConnectionString);
                SqlCommand Comm1 = new SqlCommand("SELECT User_password FROM dbo.table_user WHERE User_username = '" + materialUser.Text + "'", con);
                con.Open();
                SqlDataReader DR1 = Comm1.ExecuteReader();
                if (DR1.Read())
                {
                    materialPass.Text = Decrypt(DR1.GetValue(0).ToString());
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Input Username", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
