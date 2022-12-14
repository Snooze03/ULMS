namespace ULMS_Forms
{
    partial class FRM_Books
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
            this.TXTBX_Search = new System.Windows.Forms.TextBox();
            this.PNL_Options = new System.Windows.Forms.Panel();
            this.DGV_Inventory = new System.Windows.Forms.DataGridView();
            this.PNL_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTBX_Search
            // 
            this.TXTBX_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.TXTBX_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_Search.ForeColor = System.Drawing.Color.Black;
            this.TXTBX_Search.Location = new System.Drawing.Point(750, 6);
            this.TXTBX_Search.Name = "TXTBX_Search";
            this.TXTBX_Search.Size = new System.Drawing.Size(175, 26);
            this.TXTBX_Search.TabIndex = 1;
            this.TXTBX_Search.Text = " Search";
            // 
            // PNL_Options
            // 
            this.PNL_Options.BackColor = System.Drawing.Color.White;
            this.PNL_Options.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_Options.Controls.Add(this.TXTBX_Search);
            this.PNL_Options.Location = new System.Drawing.Point(12, 12);
            this.PNL_Options.Name = "PNL_Options";
            this.PNL_Options.Size = new System.Drawing.Size(940, 39);
            this.PNL_Options.TabIndex = 1;
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
            this.DGV_Inventory.Location = new System.Drawing.Point(12, 64);
            this.DGV_Inventory.Margin = new System.Windows.Forms.Padding(0);
            this.DGV_Inventory.Name = "DGV_Inventory";
            this.DGV_Inventory.ReadOnly = true;
            this.DGV_Inventory.RowHeadersWidth = 10;
            this.DGV_Inventory.Size = new System.Drawing.Size(940, 482);
            this.DGV_Inventory.TabIndex = 8;
            // 
            // FRM_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 555);
            this.Controls.Add(this.DGV_Inventory);
            this.Controls.Add(this.PNL_Options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Books";
            this.Text = "FRM_Inventory";
            this.Load += new System.EventHandler(this.FRM_Books_Load);
            this.PNL_Options.ResumeLayout(false);
            this.PNL_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TXTBX_Search;
        private System.Windows.Forms.Panel PNL_Options;
        private System.Windows.Forms.DataGridView DGV_Inventory;
    }
}