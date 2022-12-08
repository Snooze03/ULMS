namespace ULMS_Forms.Forms.Admin
{
    partial class FRM_EditBook
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
            this.TXTBX_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.DTP_DatePub = new System.Windows.Forms.DateTimePicker();
            this.LBL_DatePub = new System.Windows.Forms.Label();
            this.CBX_Genre = new System.Windows.Forms.ComboBox();
            this.LBL_Genre = new System.Windows.Forms.Label();
            this.TXTBX_LastName = new System.Windows.Forms.TextBox();
            this.TXTBX_FirstName = new System.Windows.Forms.TextBox();
            this.LBL_Author = new System.Windows.Forms.Label();
            this.TXTBX_Title = new System.Windows.Forms.TextBox();
            this.LBL_BookInfo = new System.Windows.Forms.Label();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.TXTBX_Id = new System.Windows.Forms.TextBox();
            this.LBL_Id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTBX_Price
            // 
            this.TXTBX_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(146)))));
            this.TXTBX_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_Price.ForeColor = System.Drawing.Color.Black;
            this.TXTBX_Price.Location = new System.Drawing.Point(51, 451);
            this.TXTBX_Price.Name = "TXTBX_Price";
            this.TXTBX_Price.Size = new System.Drawing.Size(201, 31);
            this.TXTBX_Price.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Price";
            // 
            // BTN_Update
            // 
            this.BTN_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.BTN_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Update.FlatAppearance.BorderSize = 0;
            this.BTN_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Update.ForeColor = System.Drawing.Color.Black;
            this.BTN_Update.Location = new System.Drawing.Point(238, 594);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(118, 35);
            this.BTN_Update.TabIndex = 26;
            this.BTN_Update.Text = "Update";
            this.BTN_Update.UseVisualStyleBackColor = false;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.BTN_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Delete.FlatAppearance.BorderSize = 0;
            this.BTN_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Delete.ForeColor = System.Drawing.Color.Black;
            this.BTN_Delete.Location = new System.Drawing.Point(381, 594);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(118, 35);
            this.BTN_Delete.TabIndex = 25;
            this.BTN_Delete.Text = "Delete";
            this.BTN_Delete.UseVisualStyleBackColor = false;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // DTP_DatePub
            // 
            this.DTP_DatePub.CalendarForeColor = System.Drawing.Color.White;
            this.DTP_DatePub.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.DTP_DatePub.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DTP_DatePub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_DatePub.Location = new System.Drawing.Point(51, 534);
            this.DTP_DatePub.Name = "DTP_DatePub";
            this.DTP_DatePub.Size = new System.Drawing.Size(448, 31);
            this.DTP_DatePub.TabIndex = 24;
            // 
            // LBL_DatePub
            // 
            this.LBL_DatePub.AutoSize = true;
            this.LBL_DatePub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DatePub.ForeColor = System.Drawing.Color.Black;
            this.LBL_DatePub.Location = new System.Drawing.Point(46, 493);
            this.LBL_DatePub.Name = "LBL_DatePub";
            this.LBL_DatePub.Size = new System.Drawing.Size(158, 25);
            this.LBL_DatePub.TabIndex = 23;
            this.LBL_DatePub.Text = "Date Published";
            // 
            // CBX_Genre
            // 
            this.CBX_Genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(146)))));
            this.CBX_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_Genre.ForeColor = System.Drawing.Color.Black;
            this.CBX_Genre.FormattingEnabled = true;
            this.CBX_Genre.Items.AddRange(new object[] {
            "Adventure",
            "Romance",
            "Contemporary",
            "Dystopian",
            "Mystery",
            "Horror",
            "Art",
            "Self-help",
            "Development",
            "Motivational",
            "Health",
            "History",
            "Travel",
            "Academic",
            "Programming",
            "Other"});
            this.CBX_Genre.Location = new System.Drawing.Point(51, 360);
            this.CBX_Genre.Name = "CBX_Genre";
            this.CBX_Genre.Size = new System.Drawing.Size(448, 33);
            this.CBX_Genre.TabIndex = 22;
            this.CBX_Genre.SelectionChangeCommitted += new System.EventHandler(this.CBX_Genre_SelectionChangeCommitted);
            // 
            // LBL_Genre
            // 
            this.LBL_Genre.AutoSize = true;
            this.LBL_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Genre.ForeColor = System.Drawing.Color.Black;
            this.LBL_Genre.Location = new System.Drawing.Point(46, 317);
            this.LBL_Genre.Name = "LBL_Genre";
            this.LBL_Genre.Size = new System.Drawing.Size(71, 25);
            this.LBL_Genre.TabIndex = 21;
            this.LBL_Genre.Text = "Genre";
            // 
            // TXTBX_LastName
            // 
            this.TXTBX_LastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(146)))));
            this.TXTBX_LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_LastName.ForeColor = System.Drawing.Color.Black;
            this.TXTBX_LastName.Location = new System.Drawing.Point(276, 273);
            this.TXTBX_LastName.Name = "TXTBX_LastName";
            this.TXTBX_LastName.Size = new System.Drawing.Size(223, 31);
            this.TXTBX_LastName.TabIndex = 20;
            // 
            // TXTBX_FirstName
            // 
            this.TXTBX_FirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(146)))));
            this.TXTBX_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_FirstName.ForeColor = System.Drawing.Color.Black;
            this.TXTBX_FirstName.Location = new System.Drawing.Point(51, 273);
            this.TXTBX_FirstName.Name = "TXTBX_FirstName";
            this.TXTBX_FirstName.Size = new System.Drawing.Size(201, 31);
            this.TXTBX_FirstName.TabIndex = 19;
            // 
            // LBL_Author
            // 
            this.LBL_Author.AutoSize = true;
            this.LBL_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Author.ForeColor = System.Drawing.Color.Black;
            this.LBL_Author.Location = new System.Drawing.Point(46, 236);
            this.LBL_Author.Name = "LBL_Author";
            this.LBL_Author.Size = new System.Drawing.Size(75, 25);
            this.LBL_Author.TabIndex = 18;
            this.LBL_Author.Text = "Author";
            // 
            // TXTBX_Title
            // 
            this.TXTBX_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(146)))));
            this.TXTBX_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_Title.ForeColor = System.Drawing.Color.Black;
            this.TXTBX_Title.Location = new System.Drawing.Point(51, 192);
            this.TXTBX_Title.Name = "TXTBX_Title";
            this.TXTBX_Title.Size = new System.Drawing.Size(448, 31);
            this.TXTBX_Title.TabIndex = 17;
            // 
            // LBL_BookInfo
            // 
            this.LBL_BookInfo.AutoSize = true;
            this.LBL_BookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_BookInfo.ForeColor = System.Drawing.Color.Black;
            this.LBL_BookInfo.Location = new System.Drawing.Point(184, 27);
            this.LBL_BookInfo.Name = "LBL_BookInfo";
            this.LBL_BookInfo.Size = new System.Drawing.Size(187, 42);
            this.LBL_BookInfo.TabIndex = 16;
            this.LBL_BookInfo.Text = "Edit Book";
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.Color.Black;
            this.LBL_Title.Location = new System.Drawing.Point(46, 155);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(53, 25);
            this.LBL_Title.TabIndex = 15;
            this.LBL_Title.Text = "Title";
            // 
            // TXTBX_Id
            // 
            this.TXTBX_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(146)))));
            this.TXTBX_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_Id.ForeColor = System.Drawing.Color.Black;
            this.TXTBX_Id.Location = new System.Drawing.Point(51, 111);
            this.TXTBX_Id.Name = "TXTBX_Id";
            this.TXTBX_Id.Size = new System.Drawing.Size(114, 31);
            this.TXTBX_Id.TabIndex = 68;
            this.TXTBX_Id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTBX_Id_KeyUp);
            // 
            // LBL_Id
            // 
            this.LBL_Id.AutoSize = true;
            this.LBL_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Id.ForeColor = System.Drawing.Color.Black;
            this.LBL_Id.Location = new System.Drawing.Point(46, 74);
            this.LBL_Id.Name = "LBL_Id";
            this.LBL_Id.Size = new System.Drawing.Size(32, 25);
            this.LBL_Id.TabIndex = 67;
            this.LBL_Id.Text = "ID";
            // 
            // FRM_EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 668);
            this.Controls.Add(this.TXTBX_Id);
            this.Controls.Add(this.LBL_Id);
            this.Controls.Add(this.TXTBX_Price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.DTP_DatePub);
            this.Controls.Add(this.LBL_DatePub);
            this.Controls.Add(this.CBX_Genre);
            this.Controls.Add(this.LBL_Genre);
            this.Controls.Add(this.TXTBX_LastName);
            this.Controls.Add(this.TXTBX_FirstName);
            this.Controls.Add(this.LBL_Author);
            this.Controls.Add(this.TXTBX_Title);
            this.Controls.Add(this.LBL_BookInfo);
            this.Controls.Add(this.LBL_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_EditBook";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Edit Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTBX_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.DateTimePicker DTP_DatePub;
        private System.Windows.Forms.Label LBL_DatePub;
        private System.Windows.Forms.ComboBox CBX_Genre;
        private System.Windows.Forms.Label LBL_Genre;
        private System.Windows.Forms.TextBox TXTBX_LastName;
        private System.Windows.Forms.TextBox TXTBX_FirstName;
        private System.Windows.Forms.Label LBL_Author;
        private System.Windows.Forms.TextBox TXTBX_Title;
        private System.Windows.Forms.Label LBL_BookInfo;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.TextBox TXTBX_Id;
        private System.Windows.Forms.Label LBL_Id;
    }
}