namespace ULMS_Forms.Forms.Admin
{
    partial class FRM_AddUser
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
            this.TXTBX_PassWord = new System.Windows.Forms.TextBox();
            this.LBL_Book = new System.Windows.Forms.Label();
            this.TXTBX_PhoneNumber = new System.Windows.Forms.TextBox();
            this.LBL_Number = new System.Windows.Forms.Label();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.TXTBX_LastName = new System.Windows.Forms.TextBox();
            this.TXTBX_FirstName = new System.Windows.Forms.TextBox();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.TXTBX_Email = new System.Windows.Forms.TextBox();
            this.LBL_BookInfo = new System.Windows.Forms.Label();
            this.LBL_Email = new System.Windows.Forms.Label();
            this.LBL_Role = new System.Windows.Forms.Label();
            this.RB_Admin = new System.Windows.Forms.RadioButton();
            this.RB_Librarian = new System.Windows.Forms.RadioButton();
            this.TXTBX_UserName = new System.Windows.Forms.TextBox();
            this.LBL_UserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTBX_PassWord
            // 
            this.TXTBX_PassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.TXTBX_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTBX_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_PassWord.ForeColor = System.Drawing.Color.White;
            this.TXTBX_PassWord.Location = new System.Drawing.Point(28, 539);
            this.TXTBX_PassWord.Name = "TXTBX_PassWord";
            this.TXTBX_PassWord.Size = new System.Drawing.Size(448, 24);
            this.TXTBX_PassWord.TabIndex = 41;
            // 
            // LBL_Book
            // 
            this.LBL_Book.AutoSize = true;
            this.LBL_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Book.ForeColor = System.Drawing.Color.White;
            this.LBL_Book.Location = new System.Drawing.Point(23, 502);
            this.LBL_Book.Name = "LBL_Book";
            this.LBL_Book.Size = new System.Drawing.Size(106, 25);
            this.LBL_Book.TabIndex = 40;
            this.LBL_Book.Text = "Password";
            // 
            // TXTBX_PhoneNumber
            // 
            this.TXTBX_PhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.TXTBX_PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTBX_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_PhoneNumber.ForeColor = System.Drawing.Color.White;
            this.TXTBX_PhoneNumber.Location = new System.Drawing.Point(28, 365);
            this.TXTBX_PhoneNumber.Name = "TXTBX_PhoneNumber";
            this.TXTBX_PhoneNumber.Size = new System.Drawing.Size(448, 24);
            this.TXTBX_PhoneNumber.TabIndex = 39;
            // 
            // LBL_Number
            // 
            this.LBL_Number.AutoSize = true;
            this.LBL_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Number.ForeColor = System.Drawing.Color.White;
            this.LBL_Number.Location = new System.Drawing.Point(23, 328);
            this.LBL_Number.Name = "LBL_Number";
            this.LBL_Number.Size = new System.Drawing.Size(155, 25);
            this.LBL_Number.TabIndex = 38;
            this.LBL_Number.Text = "Phone Number";
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.BTN_Ok.FlatAppearance.BorderSize = 0;
            this.BTN_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ok.ForeColor = System.Drawing.Color.White;
            this.BTN_Ok.Location = new System.Drawing.Point(215, 590);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(118, 35);
            this.BTN_Ok.TabIndex = 37;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = false;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.BTN_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Close.FlatAppearance.BorderSize = 0;
            this.BTN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close.ForeColor = System.Drawing.Color.White;
            this.BTN_Close.Location = new System.Drawing.Point(358, 590);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(118, 35);
            this.BTN_Close.TabIndex = 36;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = false;
            // 
            // TXTBX_LastName
            // 
            this.TXTBX_LastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.TXTBX_LastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTBX_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_LastName.ForeColor = System.Drawing.Color.White;
            this.TXTBX_LastName.Location = new System.Drawing.Point(252, 118);
            this.TXTBX_LastName.Name = "TXTBX_LastName";
            this.TXTBX_LastName.Size = new System.Drawing.Size(224, 24);
            this.TXTBX_LastName.TabIndex = 35;
            // 
            // TXTBX_FirstName
            // 
            this.TXTBX_FirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.TXTBX_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTBX_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_FirstName.ForeColor = System.Drawing.Color.White;
            this.TXTBX_FirstName.Location = new System.Drawing.Point(28, 118);
            this.TXTBX_FirstName.Name = "TXTBX_FirstName";
            this.TXTBX_FirstName.Size = new System.Drawing.Size(207, 24);
            this.TXTBX_FirstName.TabIndex = 34;
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Name.ForeColor = System.Drawing.Color.White;
            this.LBL_Name.Location = new System.Drawing.Point(23, 81);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(68, 25);
            this.LBL_Name.TabIndex = 33;
            this.LBL_Name.Text = "Name";
            // 
            // TXTBX_Email
            // 
            this.TXTBX_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.TXTBX_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTBX_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_Email.ForeColor = System.Drawing.Color.White;
            this.TXTBX_Email.Location = new System.Drawing.Point(28, 281);
            this.TXTBX_Email.Name = "TXTBX_Email";
            this.TXTBX_Email.Size = new System.Drawing.Size(448, 24);
            this.TXTBX_Email.TabIndex = 32;
            // 
            // LBL_BookInfo
            // 
            this.LBL_BookInfo.AutoSize = true;
            this.LBL_BookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_BookInfo.ForeColor = System.Drawing.Color.White;
            this.LBL_BookInfo.Location = new System.Drawing.Point(99, 18);
            this.LBL_BookInfo.Name = "LBL_BookInfo";
            this.LBL_BookInfo.Size = new System.Drawing.Size(307, 42);
            this.LBL_BookInfo.TabIndex = 31;
            this.LBL_BookInfo.Text = "User Information";
            // 
            // LBL_Email
            // 
            this.LBL_Email.AutoSize = true;
            this.LBL_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Email.ForeColor = System.Drawing.Color.White;
            this.LBL_Email.Location = new System.Drawing.Point(23, 244);
            this.LBL_Email.Name = "LBL_Email";
            this.LBL_Email.Size = new System.Drawing.Size(65, 25);
            this.LBL_Email.TabIndex = 30;
            this.LBL_Email.Text = "Email";
            // 
            // LBL_Role
            // 
            this.LBL_Role.AutoSize = true;
            this.LBL_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Role.ForeColor = System.Drawing.Color.White;
            this.LBL_Role.Location = new System.Drawing.Point(23, 412);
            this.LBL_Role.Name = "LBL_Role";
            this.LBL_Role.Size = new System.Drawing.Size(56, 25);
            this.LBL_Role.TabIndex = 43;
            this.LBL_Role.Text = "Role";
            // 
            // RB_Admin
            // 
            this.RB_Admin.AutoSize = true;
            this.RB_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Admin.ForeColor = System.Drawing.Color.White;
            this.RB_Admin.Location = new System.Drawing.Point(28, 462);
            this.RB_Admin.Name = "RB_Admin";
            this.RB_Admin.Size = new System.Drawing.Size(72, 24);
            this.RB_Admin.TabIndex = 44;
            this.RB_Admin.TabStop = true;
            this.RB_Admin.Text = "Admin";
            this.RB_Admin.UseVisualStyleBackColor = true;
            // 
            // RB_Librarian
            // 
            this.RB_Librarian.AutoSize = true;
            this.RB_Librarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Librarian.ForeColor = System.Drawing.Color.White;
            this.RB_Librarian.Location = new System.Drawing.Point(128, 462);
            this.RB_Librarian.Name = "RB_Librarian";
            this.RB_Librarian.Size = new System.Drawing.Size(88, 24);
            this.RB_Librarian.TabIndex = 45;
            this.RB_Librarian.TabStop = true;
            this.RB_Librarian.Text = "Librarian";
            this.RB_Librarian.UseVisualStyleBackColor = true;
            // 
            // TXTBX_UserName
            // 
            this.TXTBX_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.TXTBX_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTBX_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_UserName.ForeColor = System.Drawing.Color.White;
            this.TXTBX_UserName.Location = new System.Drawing.Point(28, 199);
            this.TXTBX_UserName.Name = "TXTBX_UserName";
            this.TXTBX_UserName.Size = new System.Drawing.Size(448, 24);
            this.TXTBX_UserName.TabIndex = 47;
            // 
            // LBL_UserName
            // 
            this.LBL_UserName.AutoSize = true;
            this.LBL_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UserName.ForeColor = System.Drawing.Color.White;
            this.LBL_UserName.Location = new System.Drawing.Point(23, 162);
            this.LBL_UserName.Name = "LBL_UserName";
            this.LBL_UserName.Size = new System.Drawing.Size(119, 25);
            this.LBL_UserName.TabIndex = 46;
            this.LBL_UserName.Text = "User Name";
            // 
            // FRM_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(501, 659);
            this.Controls.Add(this.TXTBX_UserName);
            this.Controls.Add(this.LBL_UserName);
            this.Controls.Add(this.RB_Librarian);
            this.Controls.Add(this.RB_Admin);
            this.Controls.Add(this.LBL_Role);
            this.Controls.Add(this.TXTBX_PassWord);
            this.Controls.Add(this.LBL_Book);
            this.Controls.Add(this.TXTBX_PhoneNumber);
            this.Controls.Add(this.LBL_Number);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.TXTBX_LastName);
            this.Controls.Add(this.TXTBX_FirstName);
            this.Controls.Add(this.LBL_Name);
            this.Controls.Add(this.TXTBX_Email);
            this.Controls.Add(this.LBL_BookInfo);
            this.Controls.Add(this.LBL_Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_AddUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_StudentAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTBX_PassWord;
        private System.Windows.Forms.Label LBL_Book;
        private System.Windows.Forms.TextBox TXTBX_PhoneNumber;
        private System.Windows.Forms.Label LBL_Number;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.TextBox TXTBX_LastName;
        private System.Windows.Forms.TextBox TXTBX_FirstName;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.TextBox TXTBX_Email;
        private System.Windows.Forms.Label LBL_BookInfo;
        private System.Windows.Forms.Label LBL_Email;
        private System.Windows.Forms.Label LBL_Role;
        private System.Windows.Forms.RadioButton RB_Admin;
        private System.Windows.Forms.RadioButton RB_Librarian;
        private System.Windows.Forms.TextBox TXTBX_UserName;
        private System.Windows.Forms.Label LBL_UserName;
    }
}