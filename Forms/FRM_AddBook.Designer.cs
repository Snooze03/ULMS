﻿namespace ULMS_Forms.Forms
{
    partial class FRM_AddBook
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
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_BookInfo = new System.Windows.Forms.Label();
            this.TXTBX_Title = new System.Windows.Forms.TextBox();
            this.TXTBX_FirstName = new System.Windows.Forms.TextBox();
            this.LBL_Author = new System.Windows.Forms.Label();
            this.TXTBX_MiddleName = new System.Windows.Forms.TextBox();
            this.TXTBX_LastName = new System.Windows.Forms.TextBox();
            this.LBL_Genre = new System.Windows.Forms.Label();
            this.CBX_Genre = new System.Windows.Forms.ComboBox();
            this.LBL_DatePub = new System.Windows.Forms.Label();
            this.DTP_DatePub = new System.Windows.Forms.DateTimePicker();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.Color.White;
            this.LBL_Title.Location = new System.Drawing.Point(64, 100);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(66, 31);
            this.LBL_Title.TabIndex = 0;
            this.LBL_Title.Text = "Title";
            this.LBL_Title.Click += new System.EventHandler(this.LBL_Title_Click);
            // 
            // LBL_BookInfo
            // 
            this.LBL_BookInfo.AutoSize = true;
            this.LBL_BookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_BookInfo.ForeColor = System.Drawing.Color.White;
            this.LBL_BookInfo.Location = new System.Drawing.Point(108, 25);
            this.LBL_BookInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_BookInfo.Name = "LBL_BookInfo";
            this.LBL_BookInfo.Size = new System.Drawing.Size(392, 54);
            this.LBL_BookInfo.TabIndex = 1;
            this.LBL_BookInfo.Text = "Book Information";
            // 
            // TXTBX_Title
            // 
            this.TXTBX_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.TXTBX_Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTBX_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_Title.ForeColor = System.Drawing.Color.White;
            this.TXTBX_Title.Location = new System.Drawing.Point(71, 145);
            this.TXTBX_Title.Margin = new System.Windows.Forms.Padding(4);
            this.TXTBX_Title.Name = "TXTBX_Title";
            this.TXTBX_Title.Size = new System.Drawing.Size(597, 30);
            this.TXTBX_Title.TabIndex = 2;
            // 
            // TXTBX_FirstName
            // 
            this.TXTBX_FirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.TXTBX_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTBX_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_FirstName.ForeColor = System.Drawing.Color.White;
            this.TXTBX_FirstName.Location = new System.Drawing.Point(71, 239);
            this.TXTBX_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.TXTBX_FirstName.Name = "TXTBX_FirstName";
            this.TXTBX_FirstName.Size = new System.Drawing.Size(189, 30);
            this.TXTBX_FirstName.TabIndex = 4;
            // 
            // LBL_Author
            // 
            this.LBL_Author.AutoSize = true;
            this.LBL_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Author.ForeColor = System.Drawing.Color.White;
            this.LBL_Author.Location = new System.Drawing.Point(64, 193);
            this.LBL_Author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Author.Name = "LBL_Author";
            this.LBL_Author.Size = new System.Drawing.Size(94, 31);
            this.LBL_Author.TabIndex = 3;
            this.LBL_Author.Text = "Author";
            // 
            // TXTBX_MiddleName
            // 
            this.TXTBX_MiddleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.TXTBX_MiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTBX_MiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_MiddleName.ForeColor = System.Drawing.Color.White;
            this.TXTBX_MiddleName.Location = new System.Drawing.Point(293, 239);
            this.TXTBX_MiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.TXTBX_MiddleName.Name = "TXTBX_MiddleName";
            this.TXTBX_MiddleName.Size = new System.Drawing.Size(151, 30);
            this.TXTBX_MiddleName.TabIndex = 5;
            // 
            // TXTBX_LastName
            // 
            this.TXTBX_LastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.TXTBX_LastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTBX_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_LastName.ForeColor = System.Drawing.Color.White;
            this.TXTBX_LastName.Location = new System.Drawing.Point(479, 239);
            this.TXTBX_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.TXTBX_LastName.Name = "TXTBX_LastName";
            this.TXTBX_LastName.Size = new System.Drawing.Size(189, 30);
            this.TXTBX_LastName.TabIndex = 6;
            // 
            // LBL_Genre
            // 
            this.LBL_Genre.AutoSize = true;
            this.LBL_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Genre.ForeColor = System.Drawing.Color.White;
            this.LBL_Genre.Location = new System.Drawing.Point(64, 306);
            this.LBL_Genre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Genre.Name = "LBL_Genre";
            this.LBL_Genre.Size = new System.Drawing.Size(89, 31);
            this.LBL_Genre.TabIndex = 7;
            this.LBL_Genre.Text = "Genre";
            // 
            // CBX_Genre
            // 
            this.CBX_Genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.CBX_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_Genre.ForeColor = System.Drawing.Color.White;
            this.CBX_Genre.FormattingEnabled = true;
            this.CBX_Genre.Items.AddRange(new object[] {
            "Fiction",
            "Drama",
            "Horror",
            "Math",
            "Philosophy"});
            this.CBX_Genre.Location = new System.Drawing.Point(71, 357);
            this.CBX_Genre.Margin = new System.Windows.Forms.Padding(4);
            this.CBX_Genre.Name = "CBX_Genre";
            this.CBX_Genre.Size = new System.Drawing.Size(596, 38);
            this.CBX_Genre.TabIndex = 8;
            // 
            // LBL_DatePub
            // 
            this.LBL_DatePub.AutoSize = true;
            this.LBL_DatePub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DatePub.ForeColor = System.Drawing.Color.White;
            this.LBL_DatePub.Location = new System.Drawing.Point(64, 428);
            this.LBL_DatePub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_DatePub.Name = "LBL_DatePub";
            this.LBL_DatePub.Size = new System.Drawing.Size(198, 31);
            this.LBL_DatePub.TabIndex = 9;
            this.LBL_DatePub.Text = "Date Published";
            // 
            // DTP_DatePub
            // 
            this.DTP_DatePub.CalendarForeColor = System.Drawing.Color.White;
            this.DTP_DatePub.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.DTP_DatePub.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DTP_DatePub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_DatePub.Location = new System.Drawing.Point(71, 479);
            this.DTP_DatePub.Margin = new System.Windows.Forms.Padding(4);
            this.DTP_DatePub.Name = "DTP_DatePub";
            this.DTP_DatePub.Size = new System.Drawing.Size(596, 37);
            this.DTP_DatePub.TabIndex = 10;
            // 
            // BTN_Close
            // 
            this.BTN_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.BTN_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Close.FlatAppearance.BorderSize = 0;
            this.BTN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close.ForeColor = System.Drawing.Color.White;
            this.BTN_Close.Location = new System.Drawing.Point(511, 553);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(157, 43);
            this.BTN_Close.TabIndex = 11;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = false;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.BTN_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ok.FlatAppearance.BorderSize = 0;
            this.BTN_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ok.ForeColor = System.Drawing.Color.White;
            this.BTN_Ok.Location = new System.Drawing.Point(320, 553);
            this.BTN_Ok.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(157, 43);
            this.BTN_Ok.TabIndex = 12;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = false;
            // 
            // FRM_AddBook
            // 
            this.AcceptButton = this.BTN_Close;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.CancelButton = this.BTN_Close;
            this.ClientSize = new System.Drawing.Size(733, 628);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.DTP_DatePub);
            this.Controls.Add(this.LBL_DatePub);
            this.Controls.Add(this.CBX_Genre);
            this.Controls.Add(this.LBL_Genre);
            this.Controls.Add(this.TXTBX_LastName);
            this.Controls.Add(this.TXTBX_MiddleName);
            this.Controls.Add(this.TXTBX_FirstName);
            this.Controls.Add(this.LBL_Author);
            this.Controls.Add(this.TXTBX_Title);
            this.Controls.Add(this.LBL_BookInfo);
            this.Controls.Add(this.LBL_Title);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_AddBook";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_BookInfo;
        private System.Windows.Forms.TextBox TXTBX_Title;
        private System.Windows.Forms.TextBox TXTBX_FirstName;
        private System.Windows.Forms.Label LBL_Author;
        private System.Windows.Forms.TextBox TXTBX_MiddleName;
        private System.Windows.Forms.TextBox TXTBX_LastName;
        private System.Windows.Forms.Label LBL_Genre;
        private System.Windows.Forms.ComboBox CBX_Genre;
        private System.Windows.Forms.Label LBL_DatePub;
        private System.Windows.Forms.DateTimePicker DTP_DatePub;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.Button BTN_Ok;
    }
}