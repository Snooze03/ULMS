namespace ULMS_Forms.Forms
{
    partial class FRM_Lending
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
            this.LSTV_Lending = new System.Windows.Forms.ListView();
            this.CH_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_BookBorrowed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_DateBorrowed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_ReturnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PNL_Options = new System.Windows.Forms.Panel();
            this.BTN_Sort = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.TXTBX_Search = new System.Windows.Forms.TextBox();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.CH_Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PNL_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // LSTV_Lending
            // 
            this.LSTV_Lending.BackColor = System.Drawing.Color.White;
            this.LSTV_Lending.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_Name,
            this.CH_BookBorrowed,
            this.CH_DateBorrowed,
            this.CH_ReturnDate,
            this.CH_Phone,
            this.CH_Email});
            this.LSTV_Lending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSTV_Lending.GridLines = true;
            this.LSTV_Lending.HideSelection = false;
            this.LSTV_Lending.Location = new System.Drawing.Point(12, 67);
            this.LSTV_Lending.Name = "LSTV_Lending";
            this.LSTV_Lending.Size = new System.Drawing.Size(941, 482);
            this.LSTV_Lending.TabIndex = 1;
            this.LSTV_Lending.UseCompatibleStateImageBehavior = false;
            this.LSTV_Lending.View = System.Windows.Forms.View.Details;
            // 
            // CH_Name
            // 
            this.CH_Name.Text = "                   Name";
            this.CH_Name.Width = 200;
            // 
            // CH_BookBorrowed
            // 
            this.CH_BookBorrowed.Text = "Book Borrowed";
            this.CH_BookBorrowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CH_BookBorrowed.Width = 177;
            // 
            // CH_DateBorrowed
            // 
            this.CH_DateBorrowed.Text = "Date Borrowed";
            this.CH_DateBorrowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CH_DateBorrowed.Width = 150;
            // 
            // CH_ReturnDate
            // 
            this.CH_ReturnDate.Text = "Return Date";
            this.CH_ReturnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CH_ReturnDate.Width = 150;
            // 
            // CH_Email
            // 
            this.CH_Email.Text = "Email";
            this.CH_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CH_Email.Width = 130;
            // 
            // PNL_Options
            // 
            this.PNL_Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.PNL_Options.Controls.Add(this.BTN_Sort);
            this.PNL_Options.Controls.Add(this.BTN_Delete);
            this.PNL_Options.Controls.Add(this.TXTBX_Search);
            this.PNL_Options.Controls.Add(this.BTN_Add);
            this.PNL_Options.Location = new System.Drawing.Point(12, 12);
            this.PNL_Options.Name = "PNL_Options";
            this.PNL_Options.Size = new System.Drawing.Size(941, 39);
            this.PNL_Options.TabIndex = 2;
            // 
            // BTN_Sort
            // 
            this.BTN_Sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.BTN_Sort.FlatAppearance.BorderSize = 0;
            this.BTN_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Sort.ForeColor = System.Drawing.Color.White;
            this.BTN_Sort.Location = new System.Drawing.Point(202, 5);
            this.BTN_Sort.Name = "BTN_Sort";
            this.BTN_Sort.Size = new System.Drawing.Size(80, 26);
            this.BTN_Sort.TabIndex = 3;
            this.BTN_Sort.Text = "Sort";
            this.BTN_Sort.UseVisualStyleBackColor = false;
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.BTN_Delete.FlatAppearance.BorderSize = 0;
            this.BTN_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Delete.ForeColor = System.Drawing.Color.White;
            this.BTN_Delete.Location = new System.Drawing.Point(105, 5);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(80, 26);
            this.BTN_Delete.TabIndex = 2;
            this.BTN_Delete.Text = "Delete";
            this.BTN_Delete.UseVisualStyleBackColor = false;
            // 
            // TXTBX_Search
            // 
            this.TXTBX_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TXTBX_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_Search.ForeColor = System.Drawing.Color.White;
            this.TXTBX_Search.Location = new System.Drawing.Point(759, 6);
            this.TXTBX_Search.Name = "TXTBX_Search";
            this.TXTBX_Search.Size = new System.Drawing.Size(175, 26);
            this.TXTBX_Search.TabIndex = 1;
            this.TXTBX_Search.Text = " Search";
            // 
            // BTN_Add
            // 
            this.BTN_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.BTN_Add.FlatAppearance.BorderSize = 0;
            this.BTN_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add.ForeColor = System.Drawing.Color.White;
            this.BTN_Add.Location = new System.Drawing.Point(9, 6);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(80, 26);
            this.BTN_Add.TabIndex = 0;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = false;
            // 
            // CH_Phone
            // 
            this.CH_Phone.Text = "Phone #";
            this.CH_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CH_Phone.Width = 130;
            // 
            // FRM_Lending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(968, 561);
            this.Controls.Add(this.PNL_Options);
            this.Controls.Add(this.LSTV_Lending);
            this.Name = "FRM_Lending";
            this.Text = "Lending";
            this.PNL_Options.ResumeLayout(false);
            this.PNL_Options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LSTV_Lending;
        private System.Windows.Forms.Panel PNL_Options;
        private System.Windows.Forms.TextBox TXTBX_Search;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.ColumnHeader CH_Name;
        private System.Windows.Forms.ColumnHeader CH_BookBorrowed;
        private System.Windows.Forms.ColumnHeader CH_DateBorrowed;
        private System.Windows.Forms.ColumnHeader CH_ReturnDate;
        private System.Windows.Forms.ColumnHeader CH_Email;
        private System.Windows.Forms.Button BTN_Sort;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.ColumnHeader CH_Phone;
    }
}