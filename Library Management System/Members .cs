using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library_Management_System {
    public partial class Members : Form {
        public Members() {
            InitializeComponent();
        }

        private void Members_Load(object sender, EventArgs e) {
            dataGridViewMembers.DataSource = Library_Management_System.BL.MembersBL.MembersBL.GetAll();
            dataGridViewBorrowBooks.DataSource = Library_Management_System.BL.MembersBL.MembersBL.GetAllBorrow();
        }

        private void btn_View_Click(object sender, EventArgs e) {
            dataGridViewMembers.DataSource = Library_Management_System.BL.MembersBL.MembersBL.GetAll();
            dataGridViewBorrowBooks.DataSource = Library_Management_System.BL.MembersBL.MembersBL.GetAllBorrow();
        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void btn_Register_Click(object sender, EventArgs e) {
            try {
                if (Library_Management_System.BL.MembersBL.MembersBL.Register(int.Parse(tbx_MemberID.Text), tbx_Name.Text, tbx_Email.Text, tbx_PhoneNo.Text, tbx_Date.Text) > 0) {
                    MessageBox.Show("successfully Register!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Failed Register", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            dataGridViewMembers.DataSource = Library_Management_System.BL.MembersBL.MembersBL.GetAll();
            dataGridViewBorrowBooks.DataSource = Library_Management_System.BL.MembersBL.MembersBL.GetAllBorrow();
            Clear();
            Focus();
        }

        private void Clear() {
            tbx_MemberID.Text = tbx_BookID.Text = tbx_Email.Text = tbx_Name.Text = tbx_PhoneNo.Text = tbx_Search.Text = "";
            tbx_Date.Text = tbx_ReturnDate.Text = tbx_BorrowDate.Text = tbx_BorrowID.Text = "";
        }

        private void btn_Borrow_Click(object sender, EventArgs e) { // ayman
            try {
                if (Library_Management_System.BL.MembersBL.MembersBL.BorrowBook(int.Parse(tbx_BorrowID.Text), int.Parse(tbx_BookID.Text), int.Parse(tbx_MemberID.Text), tbx_BorrowDate.Text, tbx_ReturnDate.Text) > 0) {
                    MessageBox.Show("Book Borrowed Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Failed to Borrow Book!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }
            dataGridViewMembers.DataSource = Library_Management_System.BL.MembersBL.MembersBL.GetAll();
            dataGridViewBorrowBooks.DataSource = Library_Management_System.BL.MembersBL.MembersBL.GetAllBorrow();
            Clear();
            Focus();
        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void label12_Click(object sender, EventArgs e) {

        }

        private void btn_Return_Click(object sender, EventArgs e) {
            try {
                if (Library_Management_System.BL.MembersBL.MembersBL.ReturnBook(int.Parse(tbx_BookID.Text), int.Parse(tbx_BorrowID.Text)) > 0) {
                    MessageBox.Show("Returned Book successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("not found in Borrow Books", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataGridViewMembers.DataSource = Library_Management_System.BL.MembersBL.MembersBL.GetAll();
                dataGridViewBorrowBooks.DataSource = Library_Management_System.BL.MembersBL.MembersBL.GetAllBorrow();
                Clear();
                Focus();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbx_Search_TextChanged(object sender, EventArgs e) {
            Library_Management_System.BL.MembersBL.MembersBL.search(tbx_Search, dataGridViewMembers);
        }

        private void btn_DeleteReg_Click(object sender, EventArgs e) { // waleed
            string query = "delete from Members where MemberID = @ID";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@ID", int.Parse(tbx_MemberID.Text));
            int res = Library_Management_System.DAL.BooksDAL.BooksDAL.DML(cmd);
            try {
                if (res > 0) {
                    MessageBox.Show("Success!", "Success deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewMembers.DataSource = Library_Management_System.BL.MembersBL.MembersBL.GetAll();
                    dataGridViewBorrowBooks.DataSource = Library_Management_System.BL.MembersBL.MembersBL.GetAllBorrow();
                    Clear();
                }
                else {
                    MessageBox.Show("Failed!", "Fail deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
