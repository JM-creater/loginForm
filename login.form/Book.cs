using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.form
{
    public class Book
    {
        public string Book_ID { get; set; }
        public string Book_Title { get; set; }
        public string Book_Author { get; set;}

        public static void Create(string Book_Title, string Book_Author, int Book_Quantity)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Create_Book", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Book_Title", Book_Title);
                cmd.Parameters.AddWithValue("@Book_Author", Book_Author);
                cmd.Parameters.AddWithValue("@Book_Quantity", Book_Quantity);
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


        public static void Delete(string Book_ID)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete_Book", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Book_ID", Book_ID);
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

        public static void Update(string Book_ID, string Book_Title, string Book_Author, int Book_Quantity)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update_Book", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Book_ID", Book_ID);
                cmd.Parameters.AddWithValue("@Book_Title", Book_Title);
                cmd.Parameters.AddWithValue("@Book_Author", Book_Author);
                cmd.Parameters.AddWithValue("@Book_Quantity", Book_Quantity);
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

        public static DataTable getDataFromSearch(string Book_Title)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Read_Book", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Book_Title", "%" + Book_Title + "%");
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
                SqlCommand cmd = new SqlCommand("ReadAll_Book", con);
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

    }
}
