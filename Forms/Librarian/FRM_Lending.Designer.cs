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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PNL_Options = new System.Windows.Forms.Panel();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.TXTBX_Search = new System.Windows.Forms.TextBox();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.DGV_Lending = new System.Windows.Forms.DataGridView();
            this.BTN_Email = new System.Windows.Forms.Button();
            this.PNL_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Lending)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_Options
            // 
            this.PNL_Options.BackColor = System.Drawing.Color.White;
            this.PNL_Options.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_Options.Controls.Add(this.BTN_Email);
            this.PNL_Options.Controls.Add(this.BTN_Edit);
            this.PNL_Options.Controls.Add(this.TXTBX_Search);
            this.PNL_Options.Controls.Add(this.BTN_Add);
            this.PNL_Options.Location = new System.Drawing.Point(12, 12);
            this.PNL_Options.Name = "PNL_Options";
            this.PNL_Options.Size = new System.Drawing.Size(941, 39);
            this.PNL_Options.TabIndex = 2;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.BTN_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Edit.FlatAppearance.BorderSize = 0;
            this.BTN_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Edit.ForeColor = System.Drawing.Color.Black;
            this.BTN_Edit.Location = new System.Drawing.Point(104, 6);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(80, 26);
            this.BTN_Edit.TabIndex = 5;
            this.BTN_Edit.Text = "Edit";
            this.BTN_Edit.UseVisualStyleBackColor = false;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // TXTBX_Search
            // 
            this.TXTBX_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.TXTBX_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_Search.ForeColor = System.Drawing.Color.Black;
            this.TXTBX_Search.Location = new System.Drawing.Point(752, 5);
            this.TXTBX_Search.Name = "TXTBX_Search";
            this.TXTBX_Search.Size = new System.Drawing.Size(175, 26);
            this.TXTBX_Search.TabIndex = 1;
            this.TXTBX_Search.Text = " Search";
            // 
            // BTN_Add
            // 
            this.BTN_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.BTN_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Add.FlatAppearance.BorderSize = 0;
            this.BTN_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add.ForeColor = System.Drawing.Color.Black;
            this.BTN_Add.Location = new System.Drawing.Point(9, 6);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(80, 26);
            this.BTN_Add.TabIndex = 0;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = false;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // DGV_Lending
            // 
            this.DGV_Lending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Lending.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Lending.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Lending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Lending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Lending.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Lending.Location = new System.Drawing.Point(12, 64);
            this.DGV_Lending.Margin = new System.Windows.Forms.Padding(0);
            this.DGV_Lending.Name = "DGV_Lending";
            this.DGV_Lending.ReadOnly = true;
            this.DGV_Lending.RowHeadersWidth = 10;
            this.DGV_Lending.Size = new System.Drawing.Size(941, 486);
            this.DGV_Lending.TabIndex = 9;
            // 
            // BTN_Email
            // 
            this.BTN_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.BTN_Email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Email.FlatAppearance.BorderSize = 0;
            this.BTN_Email.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Email.ForeColor = System.Drawing.Color.Black;
            this.BTN_Email.Location = new System.Drawing.Point(200, 6);
            this.BTN_Email.Name = "BTN_Email";
            this.BTN_Email.Size = new System.Drawing.Size(80, 26);
            this.BTN_Email.TabIndex = 6;
            this.BTN_Email.Text = "Email";
            this.BTN_Email.UseVisualStyleBackColor = false;
            this.BTN_Email.Click += new System.EventHandler(this.BTN_Email_Click);
            // 
            // FRM_Lending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 559);
            this.Controls.Add(this.DGV_Lending);
            this.Controls.Add(this.PNL_Options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Lending";
            this.Text = "Lending";
            this.Load += new System.EventHandler(this.FRM_Lending_Load);
            this.PNL_Options.ResumeLayout(false);
            this.PNL_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Lending)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PNL_Options;
        private System.Windows.Forms.TextBox TXTBX_Search;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.DataGridView DGV_Lending;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Email;
    }
}