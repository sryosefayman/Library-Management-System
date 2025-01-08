namespace Library_Management_System {
    partial class Members {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            btn_DeleteReg = new Button();
            label1 = new Label();
            tbx_Search = new TextBox();
            btn_View = new Button();
            btn_Register = new Button();
            btn_Borrow = new Button();
            btn_Return = new Button();
            panel1 = new Panel();
            tbx_ReturnDate = new TextBox();
            label10 = new Label();
            tbx_BorrowDate = new TextBox();
            label7 = new Label();
            tbx_BorrowID = new TextBox();
            lab21 = new Label();
            label2 = new Label();
            tbx_BookID = new TextBox();
            label5 = new Label();
            tbx_Date = new TextBox();
            label4 = new Label();
            tbx_PhoneNo = new TextBox();
            label3 = new Label();
            tbx_Email = new TextBox();
            label8 = new Label();
            tbx_Name = new TextBox();
            label9 = new Label();
            tbx_MemberID = new TextBox();
            panel4 = new Panel();
            dataGridViewMembers = new DataGridView();
            label6 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel3 = new Panel();
            dataGridViewBorrowBooks = new DataGridView();
            label12 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) dataGridViewMembers).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) dataGridViewBorrowBooks).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_DeleteReg);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tbx_Search);
            panel2.Controls.Add(btn_View);
            panel2.Controls.Add(btn_Register);
            panel2.Controls.Add(btn_Borrow);
            panel2.Controls.Add(btn_Return);
            panel2.Location = new Point(706, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 258);
            panel2.TabIndex = 3;
            // 
            // btn_DeleteReg
            // 
            btn_DeleteReg.BackColor = SystemColors.ActiveCaptionText;
            btn_DeleteReg.ForeColor = SystemColors.ButtonHighlight;
            btn_DeleteReg.Location = new Point(143, 56);
            btn_DeleteReg.Name = "btn_DeleteReg";
            btn_DeleteReg.Size = new Size(94, 39);
            btn_DeleteReg.TabIndex = 32;
            btn_DeleteReg.Text = "UnRegister";
            btn_DeleteReg.UseVisualStyleBackColor = false;
            btn_DeleteReg.Click += btn_DeleteReg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(9, 14);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 31;
            label1.Text = "Search";
            // 
            // tbx_Search
            // 
            tbx_Search.Location = new Point(90, 13);
            tbx_Search.Name = "tbx_Search";
            tbx_Search.Size = new Size(142, 27);
            tbx_Search.TabIndex = 4;
            tbx_Search.TextChanged += tbx_Search_TextChanged;
            // 
            // btn_View
            // 
            btn_View.BackColor = SystemColors.ActiveCaptionText;
            btn_View.ForeColor = SystemColors.ButtonHighlight;
            btn_View.Location = new Point(90, 188);
            btn_View.Name = "btn_View";
            btn_View.Size = new Size(94, 37);
            btn_View.TabIndex = 3;
            btn_View.Text = "View";
            btn_View.UseVisualStyleBackColor = false;
            btn_View.Click += btn_View_Click;
            // 
            // btn_Register
            // 
            btn_Register.BackColor = SystemColors.ActiveCaptionText;
            btn_Register.ForeColor = SystemColors.ButtonHighlight;
            btn_Register.Location = new Point(43, 55);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(94, 39);
            btn_Register.TabIndex = 0;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btn_Register_Click;
            // 
            // btn_Borrow
            // 
            btn_Borrow.BackColor = SystemColors.ActiveCaptionText;
            btn_Borrow.ForeColor = SystemColors.ButtonHighlight;
            btn_Borrow.Location = new Point(90, 105);
            btn_Borrow.Name = "btn_Borrow";
            btn_Borrow.Size = new Size(94, 35);
            btn_Borrow.TabIndex = 1;
            btn_Borrow.Text = "Borrow";
            btn_Borrow.UseVisualStyleBackColor = false;
            btn_Borrow.Click += btn_Borrow_Click;
            // 
            // btn_Return
            // 
            btn_Return.BackColor = SystemColors.ActiveCaptionText;
            btn_Return.ForeColor = SystemColors.ButtonHighlight;
            btn_Return.Location = new Point(90, 146);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(94, 36);
            btn_Return.TabIndex = 2;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = false;
            btn_Return.Click += btn_Return_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbx_ReturnDate);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(tbx_BorrowDate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tbx_BorrowID);
            panel1.Controls.Add(lab21);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbx_BookID);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbx_Date);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbx_PhoneNo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbx_Email);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tbx_Name);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(tbx_MemberID);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 304);
            panel1.TabIndex = 2;
            // 
            // tbx_ReturnDate
            // 
            tbx_ReturnDate.AccessibleRole = AccessibleRole.IpAddress;
            tbx_ReturnDate.BackColor = SystemColors.MenuBar;
            tbx_ReturnDate.Location = new Point(522, 226);
            tbx_ReturnDate.Name = "tbx_ReturnDate";
            tbx_ReturnDate.Size = new Size(157, 27);
            tbx_ReturnDate.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(395, 227);
            label10.Name = "label10";
            label10.Size = new Size(117, 26);
            label10.TabIndex = 45;
            label10.Text = "ReturnDate";
            // 
            // tbx_BorrowDate
            // 
            tbx_BorrowDate.AccessibleRole = AccessibleRole.IpAddress;
            tbx_BorrowDate.BackColor = SystemColors.MenuBar;
            tbx_BorrowDate.Location = new Point(522, 184);
            tbx_BorrowDate.Name = "tbx_BorrowDate";
            tbx_BorrowDate.Size = new Size(157, 27);
            tbx_BorrowDate.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(387, 185);
            label7.Name = "label7";
            label7.Size = new Size(125, 26);
            label7.TabIndex = 43;
            label7.Text = "BorrowDate";
            label7.Click += label7_Click;
            // 
            // tbx_BorrowID
            // 
            tbx_BorrowID.AccessibleRole = AccessibleRole.IpAddress;
            tbx_BorrowID.BackColor = SystemColors.MenuBar;
            tbx_BorrowID.Location = new Point(522, 144);
            tbx_BorrowID.Name = "tbx_BorrowID";
            tbx_BorrowID.Size = new Size(157, 27);
            tbx_BorrowID.TabIndex = 42;
            // 
            // lab21
            // 
            lab21.AutoSize = true;
            lab21.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
            lab21.ForeColor = SystemColors.ButtonFace;
            lab21.Location = new Point(405, 145);
            lab21.Name = "lab21";
            lab21.Size = new Size(107, 26);
            lab21.TabIndex = 41;
            lab21.Text = "BorrowID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(58, 62);
            label2.Name = "label2";
            label2.Size = new Size(92, 26);
            label2.TabIndex = 40;
            label2.Text = "BookID ";
            // 
            // tbx_BookID
            // 
            tbx_BookID.AccessibleRole = AccessibleRole.IpAddress;
            tbx_BookID.BackColor = SystemColors.MenuBar;
            tbx_BookID.Location = new Point(155, 61);
            tbx_BookID.Name = "tbx_BookID";
            tbx_BookID.Size = new Size(234, 27);
            tbx_BookID.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(57, 230);
            label5.Name = "label5";
            label5.Size = new Size(93, 26);
            label5.TabIndex = 38;
            label5.Text = "JoinDate";
            // 
            // tbx_Date
            // 
            tbx_Date.BackColor = SystemColors.MenuBar;
            tbx_Date.Location = new Point(152, 228);
            tbx_Date.Name = "tbx_Date";
            tbx_Date.Size = new Size(237, 27);
            tbx_Date.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(3, 185);
            label4.Name = "label4";
            label4.Size = new Size(147, 26);
            label4.TabIndex = 36;
            label4.Text = "PhoneNumber";
            // 
            // tbx_PhoneNo
            // 
            tbx_PhoneNo.BackColor = SystemColors.MenuBar;
            tbx_PhoneNo.Location = new Point(152, 183);
            tbx_PhoneNo.Name = "tbx_PhoneNo";
            tbx_PhoneNo.Size = new Size(237, 27);
            tbx_PhoneNo.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(85, 143);
            label3.Name = "label3";
            label3.Size = new Size(65, 26);
            label3.TabIndex = 34;
            label3.Text = "Email";
            // 
            // tbx_Email
            // 
            tbx_Email.BackColor = SystemColors.MenuBar;
            tbx_Email.Location = new Point(152, 142);
            tbx_Email.Name = "tbx_Email";
            tbx_Email.Size = new Size(240, 27);
            tbx_Email.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(84, 102);
            label8.Name = "label8";
            label8.Size = new Size(66, 26);
            label8.TabIndex = 32;
            label8.Text = "Name";
            // 
            // tbx_Name
            // 
            tbx_Name.BackColor = SystemColors.MenuBar;
            tbx_Name.Location = new Point(152, 100);
            tbx_Name.Name = "tbx_Name";
            tbx_Name.Size = new Size(497, 27);
            tbx_Name.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(31, 23);
            label9.Name = "label9";
            label9.Size = new Size(119, 26);
            label9.TabIndex = 30;
            label9.Text = "MemberID ";
            // 
            // tbx_MemberID
            // 
            tbx_MemberID.AccessibleRole = AccessibleRole.IpAddress;
            tbx_MemberID.BackColor = SystemColors.MenuBar;
            tbx_MemberID.Location = new Point(155, 21);
            tbx_MemberID.Name = "tbx_MemberID";
            tbx_MemberID.Size = new Size(237, 27);
            tbx_MemberID.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridViewMembers);
            panel4.Location = new Point(5, 348);
            panel4.Name = "panel4";
            panel4.Size = new Size(603, 313);
            panel4.TabIndex = 7;
            // 
            // dataGridViewMembers
            // 
            dataGridViewMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMembers.Dock = DockStyle.Fill;
            dataGridViewMembers.Location = new Point(0, 0);
            dataGridViewMembers.Name = "dataGridViewMembers";
            dataGridViewMembers.RowHeadersWidth = 51;
            dataGridViewMembers.Size = new Size(603, 313);
            dataGridViewMembers.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(225, 319);
            label6.Name = "label6";
            label6.Size = new Size(146, 26);
            label6.TabIndex = 31;
            label6.Text = "Members Data";
            label6.Click += label6_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewBorrowBooks);
            panel3.Location = new Point(614, 348);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 313);
            panel3.TabIndex = 32;
            // 
            // dataGridViewBorrowBooks
            // 
            dataGridViewBorrowBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBorrowBooks.Dock = DockStyle.Fill;
            dataGridViewBorrowBooks.Location = new Point(0, 0);
            dataGridViewBorrowBooks.Name = "dataGridViewBorrowBooks";
            dataGridViewBorrowBooks.RowHeadersWidth = 51;
            dataGridViewBorrowBooks.Size = new Size(460, 313);
            dataGridViewBorrowBooks.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(771, 319);
            label12.Name = "label12";
            label12.Size = new Size(148, 26);
            label12.TabIndex = 34;
            label12.Text = "Borrow Books";
            // 
            // Members
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1086, 683);
            Controls.Add(label12);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Members";
            Text = "Members";
            Load += Members_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) dataGridViewMembers).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) dataGridViewBorrowBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private TextBox tbx_Search;
        private Button btn_View;
        private Button btn_Register;
        private Button btn_Borrow;
        private Button btn_Return;
        private Panel panel1;
        private Label label5;
        private TextBox tbx_Date;
        private Label label4;
        private TextBox tbx_PhoneNo;
        private Label label3;
        private TextBox tbx_Email;
        private Label label8;
        private TextBox tbx_Name;
        private Label label9;
        private TextBox tbx_MemberID;
        private Panel panel4;
        private DataGridView dataGridViewMembers;
        private Label label2;
        private TextBox tbx_BookID;
        private Label label6;
        private Button btn_Unregister;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private TextBox tbx_ReturnDate;
        private Label label10;
        private TextBox tbx_BorrowDate;
        private Label label7;
        private TextBox tbx_BorrowID;
        private Label lab21;
        private Panel panel3;
        private DataGridView dataGridViewBorrowBooks;
        private Label label12;
        private Button btn_DeleteReg;
    }
}