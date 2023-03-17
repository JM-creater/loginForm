using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.form
{
    public class Transaction
    {
        public int Transaction_ID { get; set; }
        public int Transaction_Book_ID { get; set; }
        public int Transaction_Borrower_ID { get; set; }
        public bool Transaction_IsReturned { get; set; }
        public int Transaction_Borrowed_Date { get; set; }
        public bool Transaction_Returned_Date { get; set; }

        public static void Create(string Transaction_Book_ID, string Transaction_Borrower_ID, DateTime Transaction_Borrowed_Date)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString); 
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Create_Transaction", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Transaction_Book_ID", Transaction_Book_ID);
                cmd.Parameters.AddWithValue("@Transaction_Borrower_ID", Transaction_Borrower_ID);
                cmd.Parameters.AddWithValue("@Transaction_Borrowed_Date", Transaction_Borrowed_Date);
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
            this.Transaction_ID = int.Parse(record["Transaction_ID"].ToString());
            this.Transaction_Book_ID = int.Parse(record["Transaction_Book_ID"].ToString());
            this.Transaction_Borrower_ID = int.Parse(record["Transaction_Borrower_ID"].ToString());
            this.Transaction_IsReturned = bool.Parse(record["Transaction_IsReturned"].ToString());

        }

        public static void Update(string Transaction_ID, int Transaction_IsReturned, DateTime Transaction_Returned_Date)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update_Transaction", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Transaction_ID", Transaction_ID);
                cmd.Parameters.AddWithValue("@Transaction_IsReturned", Transaction_IsReturned);
                cmd.Parameters.AddWithValue("@Transaction_Returned_Date", Transaction_Returned_Date);
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

        public static DataTable getDataBorrowerName()
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ReadByBorrowers_Transaction", con);
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

        public static DataTable getDataBookTitle()
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ReadByBooks_Transaction", con);
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

        public static DataTable getAllTransaction(DateTime startDate, DateTime endDate)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ReadAll_Transaction", con);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
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

        public static DataTable getAllUnReturendBooks()
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ReadAll_Not_Returned_Books", con);
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
