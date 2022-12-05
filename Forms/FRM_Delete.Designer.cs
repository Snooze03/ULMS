namespace ULMS_Forms.Forms
{
    partial class FRM_Delete
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
            this.IPB_Trash = new FontAwesome.Sharp.IconPictureBox();
            this.LBL_Msg1 = new System.Windows.Forms.Label();
            this.LBL_Msg2 = new System.Windows.Forms.Label();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IPB_Trash)).BeginInit();
            this.SuspendLayout();
            // 
            // IPB_Trash
            // 
            this.IPB_Trash.BackColor = System.Drawing.Color.White;
            this.IPB_Trash.ForeColor = System.Drawing.Color.Black;
            this.IPB_Trash.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.IPB_Trash.IconColor = System.Drawing.Color.Black;
            this.IPB_Trash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IPB_Trash.IconSize = 125;
            this.IPB_Trash.Location = new System.Drawing.Point(33, 25);
            this.IPB_Trash.Name = "IPB_Trash";
            this.IPB_Trash.Size = new System.Drawing.Size(127, 125);
            this.IPB_Trash.TabIndex = 0;
            this.IPB_Trash.TabStop = false;
            this.IPB_Trash.Click += new System.EventHandler(this.IPB_Trash_Click);
            // 
            // LBL_Msg1
            // 
            this.LBL_Msg1.AutoSize = true;
            this.LBL_Msg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Msg1.ForeColor = System.Drawing.Color.Black;
            this.LBL_Msg1.Location = new System.Drawing.Point(199, 25);
            this.LBL_Msg1.Name = "LBL_Msg1";
            this.LBL_Msg1.Size = new System.Drawing.Size(421, 24);
            this.LBL_Msg1.TabIndex = 1;
            this.LBL_Msg1.Text = "Are you sure you want to delete [item name]";
            // 
            // LBL_Msg2
            // 
            this.LBL_Msg2.AutoSize = true;
            this.LBL_Msg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Msg2.ForeColor = System.Drawing.Color.Black;
            this.LBL_Msg2.Location = new System.Drawing.Point(199, 60);
            this.LBL_Msg2.Name = "LBL_Msg2";
            this.LBL_Msg2.Size = new System.Drawing.Size(385, 40);
            this.LBL_Msg2.TabIndex = 2;
            this.LBL_Msg2.Text = "This item will be permanently deleted. You can\'t undo \r\nthis action";
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.BTN_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Delete.FlatAppearance.BorderSize = 0;
            this.BTN_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Delete.ForeColor = System.Drawing.Color.Black;
            this.BTN_Delete.Location = new System.Drawing.Point(428, 115);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(108, 36);
            this.BTN_Delete.TabIndex = 3;
            this.BTN_Delete.Text = "Delete";
            this.BTN_Delete.UseVisualStyleBackColor = false;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.BTN_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.FlatAppearance.BorderSize = 0;
            this.BTN_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cancel.ForeColor = System.Drawing.Color.Black;
            this.BTN_Cancel.Location = new System.Drawing.Point(560, 115);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(108, 36);
            this.BTN_Cancel.TabIndex = 4;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = false;
            // 
            // FRM_Delete
            // 
            this.AcceptButton = this.BTN_Delete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(699, 184);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.LBL_Msg2);
            this.Controls.Add(this.LBL_Msg1);
            this.Controls.Add(this.IPB_Trash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Delete";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_DeleteStudent";
            ((System.ComponentModel.ISupportInitialize)(this.IPB_Trash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox IPB_Trash;
        private System.Windows.Forms.Label LBL_Msg1;
        private System.Windows.Forms.Label LBL_Msg2;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Cancel;
    }
}