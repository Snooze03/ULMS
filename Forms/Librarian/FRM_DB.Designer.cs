namespace ULMS_Forms
{
    partial class FRM_LibrarianDB
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
            this.PNL_NavBar = new System.Windows.Forms.Panel();
            this.IBTN_LogOut = new FontAwesome.Sharp.IconButton();
            this.IBTN_Lending = new FontAwesome.Sharp.IconButton();
            this.IBTN_Inventory = new FontAwesome.Sharp.IconButton();
            this.IBTN_DashBoard = new FontAwesome.Sharp.IconButton();
            this.PNL_ULMS = new System.Windows.Forms.Panel();
            this.LBL_ULMS = new System.Windows.Forms.Label();
            this.PNL_DashBoard = new System.Windows.Forms.Panel();
            this.PNL_NavBar.SuspendLayout();
            this.PNL_ULMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_NavBar
            // 
            this.PNL_NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.PNL_NavBar.Controls.Add(this.IBTN_LogOut);
            this.PNL_NavBar.Controls.Add(this.IBTN_Lending);
            this.PNL_NavBar.Controls.Add(this.IBTN_Inventory);
            this.PNL_NavBar.Controls.Add(this.IBTN_DashBoard);
            this.PNL_NavBar.Controls.Add(this.PNL_ULMS);
            this.PNL_NavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PNL_NavBar.Location = new System.Drawing.Point(0, 0);
            this.PNL_NavBar.Name = "PNL_NavBar";
            this.PNL_NavBar.Size = new System.Drawing.Size(200, 561);
            this.PNL_NavBar.TabIndex = 0;
            // 
            // IBTN_LogOut
            // 
            this.IBTN_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBTN_LogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.IBTN_LogOut.FlatAppearance.BorderSize = 0;
            this.IBTN_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTN_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTN_LogOut.ForeColor = System.Drawing.Color.White;
            this.IBTN_LogOut.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.IBTN_LogOut.IconColor = System.Drawing.Color.White;
            this.IBTN_LogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTN_LogOut.IconSize = 30;
            this.IBTN_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBTN_LogOut.Location = new System.Drawing.Point(0, 513);
            this.IBTN_LogOut.Name = "IBTN_LogOut";
            this.IBTN_LogOut.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.IBTN_LogOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IBTN_LogOut.Size = new System.Drawing.Size(200, 48);
            this.IBTN_LogOut.TabIndex = 5;
            this.IBTN_LogOut.Text = "         Logout";
            this.IBTN_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBTN_LogOut.UseVisualStyleBackColor = true;
            this.IBTN_LogOut.Click += new System.EventHandler(this.IBTN_LogOut_Click);
            // 
            // IBTN_Lending
            // 
            this.IBTN_Lending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBTN_Lending.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBTN_Lending.FlatAppearance.BorderSize = 0;
            this.IBTN_Lending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTN_Lending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTN_Lending.ForeColor = System.Drawing.Color.White;
            this.IBTN_Lending.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHand;
            this.IBTN_Lending.IconColor = System.Drawing.Color.White;
            this.IBTN_Lending.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTN_Lending.IconSize = 30;
            this.IBTN_Lending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBTN_Lending.Location = new System.Drawing.Point(0, 196);
            this.IBTN_Lending.Name = "IBTN_Lending";
            this.IBTN_Lending.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.IBTN_Lending.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IBTN_Lending.Size = new System.Drawing.Size(200, 48);
            this.IBTN_Lending.TabIndex = 4;
            this.IBTN_Lending.Text = "Lending‎ ‎ ‎ ‎ ‎ ";
            this.IBTN_Lending.UseVisualStyleBackColor = true;
            this.IBTN_Lending.Click += new System.EventHandler(this.IBTN_Lending_Click);
            // 
            // IBTN_Inventory
            // 
            this.IBTN_Inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBTN_Inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBTN_Inventory.FlatAppearance.BorderSize = 0;
            this.IBTN_Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTN_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTN_Inventory.ForeColor = System.Drawing.Color.White;
            this.IBTN_Inventory.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.IBTN_Inventory.IconColor = System.Drawing.Color.White;
            this.IBTN_Inventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTN_Inventory.IconSize = 30;
            this.IBTN_Inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBTN_Inventory.Location = new System.Drawing.Point(0, 148);
            this.IBTN_Inventory.Name = "IBTN_Inventory";
            this.IBTN_Inventory.Padding = new System.Windows.Forms.Padding(15, 0, 35, 0);
            this.IBTN_Inventory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IBTN_Inventory.Size = new System.Drawing.Size(200, 48);
            this.IBTN_Inventory.TabIndex = 3;
            this.IBTN_Inventory.Text = "Books";
            this.IBTN_Inventory.UseVisualStyleBackColor = true;
            this.IBTN_Inventory.Click += new System.EventHandler(this.IBTN_Inventory_Click);
            // 
            // IBTN_DashBoard
            // 
            this.IBTN_DashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBTN_DashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBTN_DashBoard.FlatAppearance.BorderSize = 0;
            this.IBTN_DashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTN_DashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTN_DashBoard.ForeColor = System.Drawing.Color.White;
            this.IBTN_DashBoard.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.IBTN_DashBoard.IconColor = System.Drawing.Color.White;
            this.IBTN_DashBoard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTN_DashBoard.IconSize = 30;
            this.IBTN_DashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBTN_DashBoard.Location = new System.Drawing.Point(0, 100);
            this.IBTN_DashBoard.Name = "IBTN_DashBoard";
            this.IBTN_DashBoard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.IBTN_DashBoard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IBTN_DashBoard.Size = new System.Drawing.Size(200, 48);
            this.IBTN_DashBoard.TabIndex = 2;
            this.IBTN_DashBoard.Text = "Dashboard";
            this.IBTN_DashBoard.UseVisualStyleBackColor = true;
            this.IBTN_DashBoard.Click += new System.EventHandler(this.IBTN_DashBoard_Click);
            // 
            // PNL_ULMS
            // 
            this.PNL_ULMS.Controls.Add(this.LBL_ULMS);
            this.PNL_ULMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_ULMS.Location = new System.Drawing.Point(0, 0);
            this.PNL_ULMS.Name = "PNL_ULMS";
            this.PNL_ULMS.Size = new System.Drawing.Size(200, 100);
            this.PNL_ULMS.TabIndex = 0;
            // 
            // LBL_ULMS
            // 
            this.LBL_ULMS.AutoSize = true;
            this.LBL_ULMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_ULMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ULMS.ForeColor = System.Drawing.Color.White;
            this.LBL_ULMS.Location = new System.Drawing.Point(39, 29);
            this.LBL_ULMS.Name = "LBL_ULMS";
            this.LBL_ULMS.Size = new System.Drawing.Size(126, 42);
            this.LBL_ULMS.TabIndex = 0;
            this.LBL_ULMS.Text = "ULMS";
            // 
            // PNL_DashBoard
            // 
            this.PNL_DashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_DashBoard.Location = new System.Drawing.Point(200, 0);
            this.PNL_DashBoard.Name = "PNL_DashBoard";
            this.PNL_DashBoard.Size = new System.Drawing.Size(964, 561);
            this.PNL_DashBoard.TabIndex = 1;
            // 
            // FRM_LibrarianDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1164, 561);
            this.Controls.Add(this.PNL_DashBoard);
            this.Controls.Add(this.PNL_NavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1180, 600);
            this.Name = "FRM_LibrarianDB";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.PNL_NavBar.ResumeLayout(false);
            this.PNL_ULMS.ResumeLayout(false);
            this.PNL_ULMS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_NavBar;
        private System.Windows.Forms.Panel PNL_ULMS;
        private FontAwesome.Sharp.IconButton IBTN_Inventory;
        private FontAwesome.Sharp.IconButton IBTN_Lending;
        private FontAwesome.Sharp.IconButton IBTN_DashBoard;
        private FontAwesome.Sharp.IconButton IBTN_LogOut;
        private System.Windows.Forms.Label LBL_ULMS;
        private System.Windows.Forms.Panel PNL_DashBoard;
    }
}