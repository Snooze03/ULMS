namespace ULMS_Forms.Forms
{
    partial class FRM_StudenInfo
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
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.DTP_ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.LBL_ReturnDate = new System.Windows.Forms.Label();
            this.TXTBX_LastName = new System.Windows.Forms.TextBox();
            this.TXTBX_FirstName = new System.Windows.Forms.TextBox();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.TXTBX_Email = new System.Windows.Forms.TextBox();
            this.LBL_BookInfo = new System.Windows.Forms.Label();
            this.LBL_Email = new System.Windows.Forms.Label();
            this.TXTBX_PhoneNumber = new System.Windows.Forms.TextBox();
            this.LBL_Number = new System.Windows.Forms.Label();
            this.TXTBX_Book = new System.Windows.Forms.TextBox();
            this.LBL_Book = new System.Windows.Forms.Label();
            this.DTP_ReturnTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.BTN_Ok.FlatAppearance.BorderSize = 0;
            this.BTN_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ok.ForeColor = System.Drawing.Color.White;
            this.BTN_Ok.Location = new System.Drawing.Point(284, 527);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(118, 35);
            this.BTN_Ok.TabIndex = 25;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = false;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.BTN_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Close.FlatAppearance.BorderSize = 0;
            this.BTN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close.ForeColor = System.Drawing.Color.White;
            this.BTN_Close.Location = new System.Drawing.Point(427, 527);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(118, 35);
            this.BTN_Close.TabIndex = 24;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = false;
            // 
            // DTP_ReturnDate
            // 
            this.DTP_ReturnDate.CalendarForeColor = System.Drawing.Color.White;
            this.DTP_ReturnDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.DTP_ReturnDate.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DTP_ReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_ReturnDate.Location = new System.Drawing.Point(47, 464);
            this.DTP_ReturnDate.Name = "DTP_ReturnDate";
            this.DTP_ReturnDate.Size = new System.Drawing.Size(353, 31);
            this.DTP_ReturnDate.TabIndex = 23;
            // 
            // LBL_ReturnDate
            // 
            this.LBL_ReturnDate.AutoSize = true;
            this.LBL_ReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ReturnDate.ForeColor = System.Drawing.Color.Black;
            this.LBL_ReturnDate.Location = new System.Drawing.Point(42, 423);
            this.LBL_ReturnDate.Name = "LBL_ReturnDate";
            this.LBL_ReturnDate.Size = new System.Drawing.Size(127, 25);
            this.LBL_ReturnDate.TabIndex = 22;
            this.LBL_ReturnDate.Text = "Return Date";
            // 
            // TXTBX_LastName
            // 
            this.TXTBX_LastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(146)))));
            this.TXTBX_LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_LastName.ForeColor = System.Drawing.Color.Black;
            this.TXTBX_LastName.Location = new System.Drawing.Point(303, 127);
            this.TXTBX_LastName.Name = "TXTBX_LastName";
            this.TXTBX_LastName.Size = new System.Drawing.Size(242, 31);
            this.TXTBX_LastName.TabIndex = 19;
            // 
            // TXTBX_FirstName
            // 
            this.TXTBX_FirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(146)))));
            this.TXTBX_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_FirstName.ForeColor = System.Drawing.Color.Black;
            this.TXTBX_FirstName.Location = new System.Drawing.Point(47, 127);
            this.TXTBX_FirstName.Name = "TXTBX_FirstName";
            this.TXTBX_FirstName.Size = new System.Drawing.Size(231, 31);
            this.TXTBX_FirstName.TabIndex = 17;
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Name.ForeColor = System.Drawing.Color.Black;
            this.LBL_Name.Location = new System.Drawing.Point(42, 90);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(68, 25);
            this.LBL_Name.TabIndex = 16;
            this.LBL_Name.Text = "Name";
            // 
            // TXTBX_Email
            // 
            this.TXTBX_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(146)))));
            this.TXTBX_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_Email.ForeColor = System.Drawing.Color.Black;
            this.TXTBX_Email.Location = new System.Drawing.Point(47, 202);
            this.TXTBX_Email.Name = "TXTBX_Email";
            this.TXTBX_Email.Size = new System.Drawing.Size(498, 31);
            this.TXTBX_Email.TabIndex = 15;
            // 
            // LBL_BookInfo
            // 
            this.LBL_BookInfo.AutoSize = true;
            this.LBL_BookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_BookInfo.ForeColor = System.Drawing.Color.Black;
            this.LBL_BookInfo.Location = new System.Drawing.Point(100, 28);
            this.LBL_BookInfo.Name = "LBL_BookInfo";
            this.LBL_BookInfo.Size = new System.Drawing.Size(360, 42);
            this.LBL_BookInfo.TabIndex = 14;
            this.LBL_BookInfo.Text = "Student Information";
            // 
            // LBL_Email
            // 
            this.LBL_Email.AutoSize = true;
            this.LBL_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Email.ForeColor = System.Drawing.Color.Black;
            this.LBL_Email.Location = new System.Drawing.Point(42, 165);
            this.LBL_Email.Name = "LBL_Email";
            this.LBL_Email.Size = new System.Drawing.Size(65, 25);
            this.LBL_Email.TabIndex = 13;
            this.LBL_Email.Text = "Email";
            // 
            // TXTBX_PhoneNumber
            // 
            this.TXTBX_PhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(146)))));
            this.TXTBX_PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_PhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.TXTBX_PhoneNumber.Location = new System.Drawing.Point(47, 286);
            this.TXTBX_PhoneNumber.Name = "TXTBX_PhoneNumber";
            this.TXTBX_PhoneNumber.Size = new System.Drawing.Size(498, 31);
            this.TXTBX_PhoneNumber.TabIndex = 27;
            // 
            // LBL_Number
            // 
            this.LBL_Number.AutoSize = true;
            this.LBL_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Number.ForeColor = System.Drawing.Color.Black;
            this.LBL_Number.Location = new System.Drawing.Point(42, 249);
            this.LBL_Number.Name = "LBL_Number";
            this.LBL_Number.Size = new System.Drawing.Size(155, 25);
            this.LBL_Number.TabIndex = 26;
            this.LBL_Number.Text = "Phone Number";
            // 
            // TXTBX_Book
            // 
            this.TXTBX_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(146)))));
            this.TXTBX_Book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_Book.ForeColor = System.Drawing.Color.Black;
            this.TXTBX_Book.Location = new System.Drawing.Point(47, 371);
            this.TXTBX_Book.Name = "TXTBX_Book";
            this.TXTBX_Book.Size = new System.Drawing.Size(498, 31);
            this.TXTBX_Book.TabIndex = 29;
            // 
            // LBL_Book
            // 
            this.LBL_Book.AutoSize = true;
            this.LBL_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Book.ForeColor = System.Drawing.Color.Black;
            this.LBL_Book.Location = new System.Drawing.Point(42, 334);
            this.LBL_Book.Name = "LBL_Book";
            this.LBL_Book.Size = new System.Drawing.Size(61, 25);
            this.LBL_Book.TabIndex = 28;
            this.LBL_Book.Text = "Book";
            // 
            // DTP_ReturnTime
            // 
            this.DTP_ReturnTime.CalendarForeColor = System.Drawing.Color.White;
            this.DTP_ReturnTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.DTP_ReturnTime.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DTP_ReturnTime.CustomFormat = "hh:mm tt";
            this.DTP_ReturnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_ReturnTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_ReturnTime.Location = new System.Drawing.Point(420, 464);
            this.DTP_ReturnTime.Name = "DTP_ReturnTime";
            this.DTP_ReturnTime.ShowUpDown = true;
            this.DTP_ReturnTime.Size = new System.Drawing.Size(125, 31);
            this.DTP_ReturnTime.TabIndex = 30;
            // 
            // FRM_StudenInfo
            // 
            this.AcceptButton = this.BTN_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BTN_Close;
            this.ClientSize = new System.Drawing.Size(586, 587);
            this.Controls.Add(this.DTP_ReturnTime);
            this.Controls.Add(this.TXTBX_Book);
            this.Controls.Add(this.LBL_Book);
            this.Controls.Add(this.TXTBX_PhoneNumber);
            this.Controls.Add(this.LBL_Number);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.DTP_ReturnDate);
            this.Controls.Add(this.LBL_ReturnDate);
            this.Controls.Add(this.TXTBX_LastName);
            this.Controls.Add(this.TXTBX_FirstName);
            this.Controls.Add(this.LBL_Name);
            this.Controls.Add(this.TXTBX_Email);
            this.Controls.Add(this.LBL_BookInfo);
            this.Controls.Add(this.LBL_Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_StudenInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Librarian - Add Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.DateTimePicker DTP_ReturnDate;
        private System.Windows.Forms.Label LBL_ReturnDate;
        private System.Windows.Forms.TextBox TXTBX_LastName;
        private System.Windows.Forms.TextBox TXTBX_FirstName;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.TextBox TXTBX_Email;
        private System.Windows.Forms.Label LBL_BookInfo;
        private System.Windows.Forms.Label LBL_Email;
        private System.Windows.Forms.TextBox TXTBX_PhoneNumber;
        private System.Windows.Forms.Label LBL_Number;
        private System.Windows.Forms.TextBox TXTBX_Book;
        private System.Windows.Forms.Label LBL_Book;
        private System.Windows.Forms.DateTimePicker DTP_ReturnTime;
    }
}