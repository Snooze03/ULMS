using System;
using System.Windows.Forms;
using ULMS_Forms.Forms;
using ULMS_Forms.src;

namespace ULMS_Forms
{
    public partial class FRM_Login : Form
    {
        private FRM_Events frmEvents = new FRM_Events();
        private string usrNamePLHolder = "User name", pswdPlHolder = "Password";

        public FRM_Login()
        {
            InitializeComponent();

            TXTBX_UserName.Text = usrNamePLHolder;
            TXTBX_PassWord.Text = pswdPlHolder;
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            // Fake logic fix later by connecting to a proper DataBase
            FRM_LibrarianDB libDB = new FRM_LibrarianDB();
            FRM_AdminDB adminDB = new FRM_AdminDB();

            if (TXTBX_UserName.Text == "librarian" && TXTBX_PassWord.Text == "1234")
            {
                Hide();
                libDB.ShowDialog();
                Close();
            }
            else if (TXTBX_UserName.Text == "admin" && TXTBX_PassWord.Text == "1234")
            {
                Hide();
                adminDB.ShowDialog();
                Close();
            }

            // #######################################
            //          Add code to handle:
            // 1. If no input, tell user to input
            // 2. Incorrect pswd or usrname
            // #######################################
        }

        // Text Box place holder
        private void TXTBX_UserName_Enter(object sender, EventArgs e)
        {
            frmEvents.TXTBX_DelPlaceHolder(TXTBX_UserName, usrNamePLHolder);
        }

        private void TXTBX_UserName_Leave(object sender, EventArgs e)
        {
            frmEvents.TXTBX_InsertPlaceHolder(TXTBX_UserName, usrNamePLHolder);
        }

        private void TXTBX_PassWord_Enter(object sender, EventArgs e)
        {
            frmEvents.TXTBX_DelPlaceHolder(TXTBX_PassWord, pswdPlHolder, true);
        }

        private void TXTBX_PassWord_Leave(object sender, EventArgs e)
        {
            frmEvents.TXTBX_InsertPlaceHolder(TXTBX_PassWord, pswdPlHolder, true);
        }
    }
}
