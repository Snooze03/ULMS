namespace ULMS_Forms
{
    partial class FRM_DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_Students = new System.Windows.Forms.Label();
            this.IPB_Student = new FontAwesome.Sharp.IconPictureBox();
            this.LBL_StudentsNO = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_Books = new System.Windows.Forms.Label();
            this.IPB_Books = new FontAwesome.Sharp.IconPictureBox();
            this.LBL_BooksNO = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LBL_OverDue = new System.Windows.Forms.Label();
            this.IPB_OverDue = new FontAwesome.Sharp.IconPictureBox();
            this.LBL_OverDueNO = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IPB_Student)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IPB_Books)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IPB_OverDue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.LBL_Students);
            this.panel1.Controls.Add(this.IPB_Student);
            this.panel1.Controls.Add(this.LBL_StudentsNO);
            this.panel1.Location = new System.Drawing.Point(57, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 138);
            this.panel1.TabIndex = 0;
            // 
            // LBL_Students
            // 
            this.LBL_Students.AutoSize = true;
            this.LBL_Students.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Students.ForeColor = System.Drawing.Color.White;
            this.LBL_Students.Location = new System.Drawing.Point(30, 87);
            this.LBL_Students.Name = "LBL_Students";
            this.LBL_Students.Size = new System.Drawing.Size(97, 25);
            this.LBL_Students.TabIndex = 2;
            this.LBL_Students.Text = "Students";
            // 
            // IPB_Student
            // 
            this.IPB_Student.BackColor = System.Drawing.Color.Transparent;
            this.IPB_Student.ForeColor = System.Drawing.Color.Black;
            this.IPB_Student.IconChar = FontAwesome.Sharp.IconChar.User;
            this.IPB_Student.IconColor = System.Drawing.Color.Black;
            this.IPB_Student.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IPB_Student.IconSize = 115;
            this.IPB_Student.Location = new System.Drawing.Point(133, 16);
            this.IPB_Student.Name = "IPB_Student";
            this.IPB_Student.Size = new System.Drawing.Size(115, 119);
            this.IPB_Student.TabIndex = 1;
            this.IPB_Student.TabStop = false;
            // 
            // LBL_StudentsNO
            // 
            this.LBL_StudentsNO.AutoSize = true;
            this.LBL_StudentsNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_StudentsNO.ForeColor = System.Drawing.Color.White;
            this.LBL_StudentsNO.Location = new System.Drawing.Point(48, 30);
            this.LBL_StudentsNO.Name = "LBL_StudentsNO";
            this.LBL_StudentsNO.Size = new System.Drawing.Size(57, 39);
            this.LBL_StudentsNO.TabIndex = 0;
            this.LBL_StudentsNO.Text = "20";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.panel2.Controls.Add(this.LBL_Books);
            this.panel2.Controls.Add(this.IPB_Books);
            this.panel2.Controls.Add(this.LBL_BooksNO);
            this.panel2.Location = new System.Drawing.Point(352, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 138);
            this.panel2.TabIndex = 1;
            // 
            // LBL_Books
            // 
            this.LBL_Books.AutoSize = true;
            this.LBL_Books.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Books.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Books.ForeColor = System.Drawing.Color.White;
            this.LBL_Books.Location = new System.Drawing.Point(41, 87);
            this.LBL_Books.Name = "LBL_Books";
            this.LBL_Books.Size = new System.Drawing.Size(72, 25);
            this.LBL_Books.TabIndex = 4;
            this.LBL_Books.Text = "Books";
            // 
            // IPB_Books
            // 
            this.IPB_Books.BackColor = System.Drawing.Color.Transparent;
            this.IPB_Books.ForeColor = System.Drawing.Color.Black;
            this.IPB_Books.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.IPB_Books.IconColor = System.Drawing.Color.Black;
            this.IPB_Books.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IPB_Books.IconSize = 115;
            this.IPB_Books.Location = new System.Drawing.Point(133, 19);
            this.IPB_Books.Name = "IPB_Books";
            this.IPB_Books.Size = new System.Drawing.Size(115, 119);
            this.IPB_Books.TabIndex = 3;
            this.IPB_Books.TabStop = false;
            this.IPB_Books.Click += new System.EventHandler(this.IPB_Books_Click);
            // 
            // LBL_BooksNO
            // 
            this.LBL_BooksNO.AutoSize = true;
            this.LBL_BooksNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_BooksNO.ForeColor = System.Drawing.Color.White;
            this.LBL_BooksNO.Location = new System.Drawing.Point(36, 30);
            this.LBL_BooksNO.Name = "LBL_BooksNO";
            this.LBL_BooksNO.Size = new System.Drawing.Size(77, 39);
            this.LBL_BooksNO.TabIndex = 3;
            this.LBL_BooksNO.Text = "100";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.panel3.Controls.Add(this.LBL_OverDue);
            this.panel3.Controls.Add(this.IPB_OverDue);
            this.panel3.Controls.Add(this.LBL_OverDueNO);
            this.panel3.Location = new System.Drawing.Point(649, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 138);
            this.panel3.TabIndex = 2;
            // 
            // LBL_OverDue
            // 
            this.LBL_OverDue.AutoSize = true;
            this.LBL_OverDue.BackColor = System.Drawing.Color.Transparent;
            this.LBL_OverDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_OverDue.ForeColor = System.Drawing.Color.White;
            this.LBL_OverDue.Location = new System.Drawing.Point(32, 87);
            this.LBL_OverDue.Name = "LBL_OverDue";
            this.LBL_OverDue.Size = new System.Drawing.Size(94, 25);
            this.LBL_OverDue.TabIndex = 6;
            this.LBL_OverDue.Text = "Overdue";
            // 
            // IPB_OverDue
            // 
            this.IPB_OverDue.BackColor = System.Drawing.Color.Transparent;
            this.IPB_OverDue.ForeColor = System.Drawing.Color.Black;
            this.IPB_OverDue.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.IPB_OverDue.IconColor = System.Drawing.Color.Black;
            this.IPB_OverDue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IPB_OverDue.IconSize = 112;
            this.IPB_OverDue.Location = new System.Drawing.Point(136, 16);
            this.IPB_OverDue.Name = "IPB_OverDue";
            this.IPB_OverDue.Size = new System.Drawing.Size(112, 119);
            this.IPB_OverDue.TabIndex = 4;
            this.IPB_OverDue.TabStop = false;
            // 
            // LBL_OverDueNO
            // 
            this.LBL_OverDueNO.AutoSize = true;
            this.LBL_OverDueNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_OverDueNO.ForeColor = System.Drawing.Color.White;
            this.LBL_OverDueNO.Location = new System.Drawing.Point(50, 30);
            this.LBL_OverDueNO.Name = "LBL_OverDueNO";
            this.LBL_OverDueNO.Size = new System.Drawing.Size(57, 39);
            this.LBL_OverDueNO.TabIndex = 5;
            this.LBL_OverDueNO.Text = "12";
            // 
            // FRM_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(972, 229);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_DashBoard";
            this.Text = "FRM_DashBoard";
            this.Load += new System.EventHandler(this.FRM_DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IPB_Student)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IPB_Books)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IPB_OverDue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox IPB_Student;
        private System.Windows.Forms.Label LBL_StudentsNO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LBL_Students;
        private FontAwesome.Sharp.IconPictureBox IPB_Books;
        private FontAwesome.Sharp.IconPictureBox IPB_OverDue;
        private System.Windows.Forms.Label LBL_Books;
        private System.Windows.Forms.Label LBL_BooksNO;
        private System.Windows.Forms.Label LBL_OverDue;
        private System.Windows.Forms.Label LBL_OverDueNO;
    }
}