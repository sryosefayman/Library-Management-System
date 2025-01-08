using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.DAL.BooksDAL;
using Library_Management_System.BL.BooksBL;
using System.Net;
using System.Drawing;


namespace Library_Management_System.BL.BooksBL {
    public static class BooksBL { // yara
        
        public static int NewBook(int BookID, string Title, string Author, string ISBN, int PublishedYear, string Genre, int AvailableCopies) {
            string query = "insert into Books values (@BookID , @Title, @Author, @ISBN, @PublishedYear, @Genre, @AvailableCopies)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@BookID", BookID);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Author", Author);
            cmd.Parameters.AddWithValue("@ISBN", ISBN);
            cmd.Parameters.AddWithValue("@PublishedYear", PublishedYear);
            cmd.Parameters.AddWithValue("@Genre", Genre);
            cmd.Parameters.AddWithValue("@AvailableCopies", AvailableCopies);
            return Library_Management_System.DAL.BooksDAL.BooksDAL.DML(cmd);
        }

        public static DataTable GetById(int id) {
            string query = "select * from Books where id = @id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", id);
            return Library_Management_System.DAL.BooksDAL.BooksDAL.Select(cmd);
        }
      
        public static DataTable GetAll() {
            string query = "select * from Books";
            SqlCommand cmd = new SqlCommand(query);
            return Library_Management_System.DAL.BooksDAL.BooksDAL.Select(cmd);
        }
        public static DataTable GetAllBorrows() {
            string query = "select * from BorrowedBooks";
            SqlCommand cmd = new SqlCommand(query);
            return Library_Management_System.DAL.BooksDAL.BooksDAL.Select(cmd);
        }
        public static bool BorrowBook(int memberId, int bookId) {
            if (BooksDAL.IsBookAvailable(bookId)) {
                if (BooksDAL.UpdateBookAvailability(bookId)) {
                    return BooksDAL.RecordBorrowing(memberId, bookId);
                }
            }
            return false;
        }
        public static void Search(TextBox tbx_Search,DataGridView d1) { 
            string query = "SELECT * FROM Books WHERE Title LIKE @search OR Author LIKE @search OR Genre LIKE @search OR PublishedYear LIKE @search";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@search", "%" + tbx_Search.Text + "%");
            d1.DataSource = Library_Management_System.DAL.BooksDAL.BooksDAL.Select(cmd);
        }
    }
}
