using System;
using System.Data;
using System.Windows.Forms;
using DatabaseProject;
using ULMS_Forms.Forms.Admin;

namespace ULMS_Forms.Forms
{
    public partial class FRM_AdminUserEditor : Form
    {
        private DBAccess dbAccess = new DBAccess();
        private DataTable dtUsers = new DataTable();

        public FRM_AdminUserEditor()
        {
            InitializeComponent();
        }

        private void FRM_AdminUserEditor_Load(object sender, EventArgs e)
        {
            string query = "Select * from TBL_Users";

            dbAccess.readDatathroughAdapter(query, dtUsers);

            DGV_Users.DataSource = dtUsers;
            dbAccess.closeConn();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            FRM_AddUser addUser = new FRM_AddUser();
            addUser.ShowDialog();
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            FRM_EditUser editUser = new FRM_EditUser();
            editUser.ShowDialog();  
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            FRM_Delete delete = new FRM_Delete();
            delete.ShowDialog();
        }
    }
}
