using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library_Management_System.BL.MembersBL {
    internal class MembersBL
    {
        public static int Register(int MemberID, string Name, string Email, string PhoneNumber, string JoinDate) {
            string query = "INSERT INTO Members (MemberID, Name, Email, PhoneNumber, JoinDate) VALUES (@MemberID, @Name, @Email, @PhoneNumber, @JoinDate)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MemberID", MemberID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            cmd.Parameters.AddWithValue("@JoinDate", JoinDate);
            return Library_Management_System.DAL.BooksDAL.BooksDAL.DML(cmd);
        }

        public static DataTable GetById(int id) {
            string query = "select * from Members where id = @id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", id);
            return Library_Management_System.DAL.BooksDAL.BooksDAL.Select(cmd);
        }
        public static DataTable GetAll() {
            string query = "select * from Members";
            SqlCommand cmd = new SqlCommand(query);
            return Library_Management_System.DAL.BooksDAL.BooksDAL.Select(cmd);
        }
        public static DataTable GetAllBorrow() {
            string query = "select * from BorrowedBooks";
            SqlCommand cmd = new SqlCommand(query);
            return Library_Management_System.DAL.BooksDAL.BooksDAL.Select(cmd);
        }
        public static int DeleteMember(int MemberId) { // Nour
            string query = "DELETE FROM Members WHERE MemberID = @MemberID";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MemberID", MemberId);
            int rowsAffected = Library_Management_System.DAL.BooksDAL.BooksDAL.DML(cmd);
            return rowsAffected;
        }
        public static int BorrowBook(int BorrowID, int bookID, int MemberID, string BorrowDate, string ReturnDate) // Ayman
        { 
            if (BorrowValid(bookID)) {
                string query = "INSERT INTO BorrowedBooks VALUES (@BorrowID, @BookID, @MemberID, @BorrowDate, @ReturnDate)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@BorrowID", BorrowID);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.Parameters.AddWithValue("@MemberID", MemberID);
                cmd.Parameters.AddWithValue("@BorrowDate", BorrowDate);
                cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);
                int rowsAffected = Library_Management_System.DAL.BooksDAL.BooksDAL.DML(cmd);
                string edit = "UPDATE Books SET AvailableCopies = AvailableCopies - 1 WHERE BookID = @bookID";
                SqlCommand cmd_edit = new SqlCommand(edit);
                cmd_edit.Parameters.AddWithValue("@bookID", bookID);
                Library_Management_System.DAL.BooksDAL.BooksDAL.DML(cmd_edit);
                return rowsAffected;
            }
            else {
                MessageBox.Show("Not found copies of this book", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
        }
        public static int ReturnBook(int bookID, int borrowID) // Ayman
        {
            string query_edit = "UPDATE Books SET AvailableCopies = AvailableCopies + 1 WHERE BookID = @bookID";
            SqlCommand cmd_edit = new SqlCommand(query_edit);
            cmd_edit.Parameters.AddWithValue("@bookID", bookID);
            int rowsAffected = Library_Management_System.DAL.BooksDAL.BooksDAL.DML(cmd_edit);
            string query_delete = "DELETE FROM BorrowedBooks WHERE BorrowID = @borrowID";
            SqlCommand cmd_delete = new SqlCommand(query_delete);
            cmd_delete.Parameters.AddWithValue("@borrowID", borrowID);
            Library_Management_System.DAL.BooksDAL.BooksDAL.DML(cmd_edit);
            Library_Management_System.DAL.BooksDAL.BooksDAL.DML(cmd_delete);
            return rowsAffected;
        }
        private static bool BorrowValid(int bookID) { // Ayman
            string query = "SELECT AvailableCopies FROM Books WHERE BookID = @BookID";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@BookID", bookID);
            DataTable dt = Library_Management_System.DAL.BooksDAL.BooksDAL.Select(cmd);
            if (dt.Rows.Count > 0) {
                int value = Convert.ToInt32(dt.Rows[0][0]);
                return value > 0;
            }
            return false;
        }

        public static void search(TextBox tbx_Search, DataGridView d1) { // sherif
            string query = "SELECT * FROM Members Where Name Like @search Or Email Like @search Or PhoneNumber Like @search Or JoinDate Like @search";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@search", "%" + tbx_Search.Text + "%");
            d1.DataSource = Library_Management_System.DAL.BooksDAL.BooksDAL.Select(cmd);
        }
    }
}
