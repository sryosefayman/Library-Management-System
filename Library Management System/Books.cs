using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_System.BL.BooksBL;
using Library_Management_System.DAL.BooksDAL;
using Microsoft.Data.SqlClient;

namespace Library_Management_System {
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            try
            {
                if (Library_Management_System.BL.BooksBL.BooksBL.NewBook(int.Parse(tbx_Id.Text), tbx_Title.Text, tbx_Author.Text, tbx_ISBN.Text, int.Parse(tbx_PublishedYear.Text), tbx_Genre.Text, int.Parse(tbx_AvailableCopies.Text)) > 0)
                {
                    MessageBox.Show("Book Added", "Success Addition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("NOt Added", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridViewBooks.DataSource = Library_Management_System.BL.BooksBL.BooksBL.GetAll();
            dataGridBorrowBooks.DataSource = Library_Management_System.BL.BooksBL.BooksBL.GetAllBorrows();
            Clear();
            Focus();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            DataTable dt2 = Library_Management_System.BL.BooksBL.BooksBL.GetAllBorrows();
            dataGridViewBooks.DataSource = Library_Management_System.BL.BooksBL.BooksBL.GetAll();
            dataGridBorrowBooks.DataSource = Library_Management_System.BL.BooksBL.BooksBL.GetAllBorrows();
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        { // Nour
            string query = "delete from Books where BookID = @ID";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@ID", tbx_Id.Text);
            int res = Library_Management_System.DAL.BooksDAL.BooksDAL.DML(cmd);
            try
            {
                if (res > 0)
                {
                    MessageBox.Show("Success!", "Success deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewBooks.DataSource = Library_Management_System.BL.BooksBL.BooksBL.GetAll();
                    dataGridBorrowBooks.DataSource = Library_Management_System.BL.BooksBL.BooksBL.GetAllBorrows();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed!", "Fail deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Clear()
        {
            tbx_PublishedYear.Text = tbx_Author.Text = tbx_Genre.Text = tbx_Id.Text = tbx_Search.Text = tbx_Title.Text = tbx_ISBN.Text = tbx_AvailableCopies.Text = "";
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            dataGridViewBooks.DataSource = Library_Management_System.BL.BooksBL.BooksBL.GetAll();
            dataGridBorrowBooks.DataSource = Library_Management_System.BL.BooksBL.BooksBL.GetAllBorrows();
        }

        private void dataGridBorrowBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbx_Search_TextChanged(object sender, EventArgs e)
        {
            Library_Management_System.BL.BooksBL.BooksBL.Search(tbx_Search, dataGridViewBooks);
        }

        private void btn_Borrow_Click_1(object sender, EventArgs e)
        {
            Members m1 = new Members();
            m1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbx_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
