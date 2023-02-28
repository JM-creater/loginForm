using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace login.form
{
    public class User
    {
        public string User_Id { get; set; }
        public string User_username { get; set; }
        public string User_password { get; set; }

        public static void Create(string User_username, string User_password)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.Create_User", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@User_username", User_username);
                cmd.Parameters.AddWithValue("@User_password", User_password);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            { 
                con.Close(); 
            }
            
        }

        public void ExtractFromReader(IDataRecord record)
        {
            this.User_Id = record["User_Id"].ToString();
            this.User_username = record["User_username"].ToString();
            this.User_password = record["User_password"].ToString();
        }

        public static User Read(string User_username)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            User sr = null;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.Read_User", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@User_username", User_username);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) 
                {
                    sr = new User();
                    sr.ExtractFromReader(dr);
                }
            }
            catch(Exception) 
            {
            
            }
            finally
            { 
                con.Close(); 
            }

            return sr;
        }

        public static User Login(string User_username, string User_password)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            User sr = null;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.LogIn_User", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@User_username", User_username);
                cmd.Parameters.AddWithValue("@User_password", User_password);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) 
                { 
                    sr = new User();
                    sr.ExtractFromReader(dr);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            { 
                con.Close(); 
            }
            return sr;
        }

        public static User Extract_Pass(string User_username)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            User sr = null;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Extract_Pass", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@User_username", User_username);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    sr = new User();
                    sr.ExtractFromReader(dr);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return sr;
        }

    }
}
