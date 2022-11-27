namespace ULMS_Forms.Forms
{
    partial class FRM_Admin_Inventory
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
            this.PNL_Options = new System.Windows.Forms.Panel();
            this.CBX_Sort = new System.Windows.Forms.ComboBox();
            this.TXTBX_Search = new System.Windows.Forms.TextBox();
            this.LSTV_Inventory = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_DatePub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PNL_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Options
            // 
            this.PNL_Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.PNL_Options.Controls.Add(this.CBX_Sort);
            this.PNL_Options.Controls.Add(this.TXTBX_Search);
            this.PNL_Options.Location = new System.Drawing.Point(12, 12);
            this.PNL_Options.Name = "PNL_Options";
            this.PNL_Options.Size = new System.Drawing.Size(941, 39);
            this.PNL_Options.TabIndex = 3;
            // 
            // CBX_Sort
            // 
            this.CBX_Sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.CBX_Sort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBX_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBX_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_Sort.ForeColor = System.Drawing.Color.White;
            this.CBX_Sort.FormattingEnabled = true;
            this.CBX_Sort.Items.AddRange(new object[] {
            "Ascending",
            "Descending",
            "Genre",
            "Price"});
            this.CBX_Sort.Location = new System.Drawing.Point(12, 5);
            this.CBX_Sort.Name = "CBX_Sort";
            this.CBX_Sort.Size = new System.Drawing.Size(115, 28);
            this.CBX_Sort.TabIndex = 2;
            this.CBX_Sort.Text = "  Sort";
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
            // LSTV_Inventory
            // 
            this.LSTV_Inventory.BackColor = System.Drawing.Color.White;
            this.LSTV_Inventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Author,
            this.CH_Genre,
            this.CH_DatePub,
            this.CH_Price});
            this.LSTV_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSTV_Inventory.GridLines = true;
            this.LSTV_Inventory.HideSelection = false;
            this.LSTV_Inventory.Location = new System.Drawing.Point(12, 67);
            this.LSTV_Inventory.Name = "LSTV_Inventory";
            this.LSTV_Inventory.Size = new System.Drawing.Size(941, 482);
            this.LSTV_Inventory.TabIndex = 2;
            this.LSTV_Inventory.UseCompatibleStateImageBehavior = false;
            this.LSTV_Inventory.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Text = "                         Title";
            this.Title.Width = 205;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Author.Width = 200;
            // 
            // CH_Genre
            // 
            this.CH_Genre.Text = "Genre";
            this.CH_Genre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CH_Genre.Width = 250;
            // 
            // CH_DatePub
            // 
            this.CH_DatePub.Text = "Date Published";
            this.CH_DatePub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CH_DatePub.Width = 200;
            // 
            // CH_Price
            // 
            this.CH_Price.Text = "Price";
            this.CH_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CH_Price.Width = 80;
            // 
            // FRM_Admin_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(967, 567);
            this.Controls.Add(this.PNL_Options);
            this.Controls.Add(this.LSTV_Inventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Admin_Inventory";
            this.Text = "FRM_Admin_Inventory";
            this.PNL_Options.ResumeLayout(false);
            this.PNL_Options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Options;
        private System.Windows.Forms.ComboBox CBX_Sort;
        private System.Windows.Forms.TextBox TXTBX_Search;
        private System.Windows.Forms.ListView LSTV_Inventory;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader CH_Genre;
        private System.Windows.Forms.ColumnHeader CH_DatePub;
        private System.Windows.Forms.ColumnHeader CH_Price;
    }
}