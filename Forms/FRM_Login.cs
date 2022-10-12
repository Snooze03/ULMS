using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULMS_Forms
{
    public partial class FRM_Login : Form
    {
        private string usrNamePLHolder = "User name", pswdPlHolder = "Password";
        private char pswdChar = '*';

        public FRM_Login()
        {
            InitializeComponent();

            TXTBX_UserName.Text = usrNamePLHolder;
            TXTBX_PassWord.Text = pswdPlHolder;
        }

        private void TXTBX_PlaceHolder(TextBox txtBX, string plHolder, Boolean isPSWD)
        {
            if (txtBX.Text == "")
            {
                txtBX.Text = plHolder;
                txtBX.ForeColor = Color.LightGray;
                if (isPSWD) txtBX.PasswordChar = '\0';
            }
        }

        private void TXTBX_DelPlaceHolder(TextBox txtBX, string plHolder, Boolean isPSWD)
        {
            if (txtBX.Text == plHolder)
            {
                txtBX.Text = "";
                txtBX.ForeColor = Color.White;
                if (isPSWD) txtBX.PasswordChar = pswdChar;
            }
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            FRM_LibrarianDB libDB = new FRM_LibrarianDB();
            if (TXTBX_UserName.Text == "librarian" && TXTBX_PassWord.Text == "12345678")
            {
                libDB.Show();
                this.Hide();
            }
        }

        private void TXTBX_UserName_Enter(object sender, EventArgs e)
        {
            TXTBX_DelPlaceHolder(this.TXTBX_UserName, usrNamePLHolder, false);
        }

        private void TXTBX_UserName_Leave(object sender, EventArgs e)
        {
            TXTBX_PlaceHolder(this.TXTBX_UserName, usrNamePLHolder, false);
        }

        private void TXTBX_PassWord_Enter(object sender, EventArgs e)
        {
            TXTBX_DelPlaceHolder(TXTBX_PassWord, pswdPlHolder, true);
        }

        private void TXTBX_PassWord_Leave(object sender, EventArgs e)
        {
            TXTBX_PlaceHolder(TXTBX_PassWord, pswdPlHolder, true);
        }
    }
}
