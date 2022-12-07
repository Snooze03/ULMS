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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PNL_Options = new System.Windows.Forms.Panel();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.CBX_Sort = new System.Windows.Forms.ComboBox();
            this.TXTBX_Search = new System.Windows.Forms.TextBox();
            this.DGV_Inventory = new System.Windows.Forms.DataGridView();
            this.PNL_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_Options
            // 
            this.PNL_Options.BackColor = System.Drawing.Color.White;
            this.PNL_Options.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_Options.Controls.Add(this.BTN_Edit);
            this.PNL_Options.Controls.Add(this.BTN_Add);
            this.PNL_Options.Controls.Add(this.CBX_Sort);
            this.PNL_Options.Controls.Add(this.TXTBX_Search);
            this.PNL_Options.Location = new System.Drawing.Point(12, 12);
            this.PNL_Options.Name = "PNL_Options";
            this.PNL_Options.Size = new System.Drawing.Size(941, 39);
            this.PNL_Options.TabIndex = 3;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.BTN_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Edit.FlatAppearance.BorderSize = 0;
            this.BTN_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Edit.ForeColor = System.Drawing.Color.Black;
            this.BTN_Edit.Location = new System.Drawing.Point(108, 7);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(80, 26);
            this.BTN_Edit.TabIndex = 5;
            this.BTN_Edit.Text = "Edit";
            this.BTN_Edit.UseVisualStyleBackColor = false;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.BTN_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Add.FlatAppearance.BorderSize = 0;
            this.BTN_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add.ForeColor = System.Drawing.Color.Black;
            this.BTN_Add.Location = new System.Drawing.Point(12, 7);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(80, 26);
            this.BTN_Add.TabIndex = 3;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = false;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // CBX_Sort
            // 
            this.CBX_Sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.CBX_Sort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBX_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBX_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_Sort.ForeColor = System.Drawing.Color.Black;
            this.CBX_Sort.FormattingEnabled = true;
            this.CBX_Sort.Items.AddRange(new object[] {
            "Ascending",
            "Descending",
            "Genre",
            "Price"});
            this.CBX_Sort.Location = new System.Drawing.Point(203, 6);
            this.CBX_Sort.Name = "CBX_Sort";
            this.CBX_Sort.Size = new System.Drawing.Size(115, 28);
            this.CBX_Sort.TabIndex = 2;
            this.CBX_Sort.Text = "  Sort";
            // 
            // TXTBX_Search
            // 
            this.TXTBX_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.TXTBX_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_Search.ForeColor = System.Drawing.Color.Black;
            this.TXTBX_Search.Location = new System.Drawing.Point(752, 6);
            this.TXTBX_Search.Name = "TXTBX_Search";
            this.TXTBX_Search.Size = new System.Drawing.Size(175, 26);
            this.TXTBX_Search.TabIndex = 1;
            this.TXTBX_Search.Text = " Search";
            // 
            // DGV_Inventory
            // 
            this.DGV_Inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Inventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Inventory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Inventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Inventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Inventory.Location = new System.Drawing.Point(12, 66);
            this.DGV_Inventory.Margin = new System.Windows.Forms.Padding(0);
            this.DGV_Inventory.Name = "DGV_Inventory";
            this.DGV_Inventory.ReadOnly = true;
            this.DGV_Inventory.RowHeadersWidth = 10;
            this.DGV_Inventory.Size = new System.Drawing.Size(941, 484);
            this.DGV_Inventory.TabIndex = 7;
            // 
            // FRM_Admin_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 559);
            this.Controls.Add(this.DGV_Inventory);
            this.Controls.Add(this.PNL_Options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Admin_Inventory";
            this.Text = "FRM_Admin_Inventory";
            this.Load += new System.EventHandler(this.FRM_Admin_Inventory_Load);
            this.PNL_Options.ResumeLayout(false);
            this.PNL_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Options;
        private System.Windows.Forms.ComboBox CBX_Sort;
        private System.Windows.Forms.TextBox TXTBX_Search;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.DataGridView DGV_Inventory;
    }
}