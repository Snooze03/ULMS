namespace ULMS_Forms
{
    partial class FRM_Login
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
            this.BTN_Login = new System.Windows.Forms.Button();
            this.TXTBX_PassWord = new System.Windows.Forms.TextBox();
            this.TXTBX_UserName = new System.Windows.Forms.TextBox();
            this.LBL_UserLogin = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // BTN_Login
            // 
            this.BTN_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(208)))), ((int)(((byte)(245)))));
            this.BTN_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Login.Font = new System.Drawing.Font("Inter", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.BTN_Login.Location = new System.Drawing.Point(214, 300);
            this.BTN_Login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(182, 52);
            this.BTN_Login.TabIndex = 0;
            this.BTN_Login.Text = "LOGIN";
            this.BTN_Login.UseVisualStyleBackColor = false;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // TXTBX_PassWord
            // 
            this.TXTBX_PassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.TXTBX_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTBX_PassWord.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_PassWord.ForeColor = System.Drawing.Color.LightGray;
            this.TXTBX_PassWord.Location = new System.Drawing.Point(169, 232);
            this.TXTBX_PassWord.Name = "TXTBX_PassWord";
            this.TXTBX_PassWord.Size = new System.Drawing.Size(269, 39);
            this.TXTBX_PassWord.TabIndex = 1;
            this.TXTBX_PassWord.Enter += new System.EventHandler(this.TXTBX_PassWord_Enter);
            this.TXTBX_PassWord.Leave += new System.EventHandler(this.TXTBX_PassWord_Leave);
            // 
            // TXTBX_UserName
            // 
            this.TXTBX_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(109)))));
            this.TXTBX_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTBX_UserName.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBX_UserName.ForeColor = System.Drawing.Color.LightGray;
            this.TXTBX_UserName.Location = new System.Drawing.Point(169, 163);
            this.TXTBX_UserName.Name = "TXTBX_UserName";
            this.TXTBX_UserName.Size = new System.Drawing.Size(269, 39);
            this.TXTBX_UserName.TabIndex = 2;
            this.TXTBX_UserName.Enter += new System.EventHandler(this.TXTBX_UserName_Enter);
            this.TXTBX_UserName.Leave += new System.EventHandler(this.TXTBX_UserName_Leave);
            // 
            // LBL_UserLogin
            // 
            this.LBL_UserLogin.AutoSize = true;
            this.LBL_UserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_UserLogin.Font = new System.Drawing.Font("Inter", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UserLogin.Location = new System.Drawing.Point(125, 65);
            this.LBL_UserLogin.Name = "LBL_UserLogin";
            this.LBL_UserLogin.Size = new System.Drawing.Size(368, 154);
            this.LBL_UserLogin.TabIndex = 3;
            this.LBL_UserLogin.Text = "User Login\r\n\r\n";
            this.LBL_UserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(622, 439);
            this.Controls.Add(this.TXTBX_UserName);
            this.Controls.Add(this.TXTBX_PassWord);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.LBL_UserLogin);
            this.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FRM_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ULMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.TextBox TXTBX_PassWord;
        private System.Windows.Forms.TextBox TXTBX_UserName;
        private System.Windows.Forms.Label LBL_UserLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

