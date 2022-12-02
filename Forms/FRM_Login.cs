using System;
using System.Threading;
using System.Windows.Forms;
using ULMS_Forms.src;
using DatabaseProject;
using System.Data;
using ULMS_Forms.Forms;

namespace ULMS_Forms
{
    public partial class FRM_Login : Form
    {
        private FRM_Events frmEvents = new FRM_Events();
        private DBAccess dbAccess = new DBAccess();
        private string usrNamePLHolder = "User name", pswdPlHolder = "Password";
        private DataTable dtUsers = new DataTable();

        public FRM_Login()
        {
            InitializeComponent();

            TXTBX_UserName.Text = usrNamePLHolder;
            TXTBX_PassWord.Text = pswdPlHolder;
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            string userName = TXTBX_UserName.Text;
            string passWord = TXTBX_PassWord.Text;

            string query = "Select * from TBL_Users Where UserName ='" + userName + "' AND PassWord ='" + passWord + "'";

            dbAccess.readDatathroughAdapter(query, dtUsers);

            if (dtUsers.Rows.Count == 1)
            {
                dbAccess.closeConn();

                Thread th;
                th = new Thread(OpenNewForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

                Close();
            }
            else MessageBox.Show("User '" + userName + "' does not exist");
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

        private void OpenNewForm()
        {
            Form frm;

            if (dtUsers.Rows[0]["Role"].ToString() == "Admin") frm = new FRM_AdminDB();
            else frm = new FRM_LibrarianDB();

            Application.Run(frm);
        }
    }
}
