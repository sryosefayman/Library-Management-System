using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.DAL.BooksDAL
{
    public class BooksDAL
    {
        static string ConnectionString = "Data Source=.;Initial Catalog=LibraryManagementSystem;Integrated Security=True;Trust Server Certificate=True";
        static SqlConnection con = new SqlConnection(ConnectionString);
        public static DataTable Select(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            cmd.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public static int DML(SqlCommand cmd)
        {
            try {
                cmd.Connection = con;
                con.Open();
                int RowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return RowsAffected;
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public static bool IsBookAvailable(int bookId) {
            string ConnectionString = "Data Source=.;Initial Catalog=LibraryManagementSystem;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            string query = "SELECT AvailableCopies FROM Books WHERE BookID = @BookID";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@BookID", bookId);
            cmd.Connection = con;
            con.Open();
            object result = cmd.ExecuteScalar();
            if (result != null && int.TryParse(result.ToString(), out int availableCopies)) {
                con.Close();
                return availableCopies > 0;
            }
            con.Close();
            return false;
        }
        public static bool UpdateBookAvailability(int bookId) {
            string query = "UPDATE Books SET AvailableCopies = AvailableCopies - 1 WHERE BookID = @BookID AND AvailableCopies > 0";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@BookID", bookId);
            string ConnectionString = "Data Source=.;Initial Catalog=LibraryManagementSystem;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            cmd.Connection = con;
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
        public static bool RecordBorrowing(int memberId, int bookId) {
            string query = "INSERT INTO BorrowedBooks (MemberID, BookID) VALUES (@MemberID, @BookID)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MemberID", memberId);
            cmd.Parameters.AddWithValue("@BookID", bookId);
            string ConnectionString = "Data Source=.;Initial Catalog=LibraryManagementSystem;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(ConnectionString);
            cmd.Connection = connection;
            connection.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }
}
