using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.form
{
    public class Borrower
    {
        public string Borrower_ID { get; set; }
        public string Borrower_Fname { get; set; }
        public string Borrower_Lname { get; set; }

        public static void Create(string Borrower_Fname, string Borrower_Lname)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Create_Borrower", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Borrower_Fname", Borrower_Fname);
                cmd.Parameters.AddWithValue("@Borrower_Lname", Borrower_Lname);
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

        public static void Delete(string Borrower_ID)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete_Borrower", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Borrower_ID", Borrower_ID);
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
        public static void Update(string Borrower_ID, string Borrower_Fname, string Borrower_Lname)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update_Borrower", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Borrower_ID", Borrower_ID);
                cmd.Parameters.AddWithValue("@Borrower_Fname", Borrower_Fname);
                cmd.Parameters.AddWithValue("@Borrower_Lname", Borrower_Lname);
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

        public static DataTable getDataFromSearch(string Borrower_Fname)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Read_Borrower", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Borrower_Fname", "%" + Borrower_Fname + "%");
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public static DataTable getAllData()
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ReadAll_Borrower", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public static DataTable IsAlreadyExistBorrower(string Borrower_Fname, string Borrower_Lname) 
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("AlreadyExist_Borrower", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Borrower_Fname", Borrower_Fname);
                cmd.Parameters.AddWithValue("@Borrower_Lname", Borrower_Lname);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                con.Close();
            }
            return dt;
        }

    }
}
