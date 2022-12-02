using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULMS_Forms.Forms.Admin
{
    public partial class FRM_EditUser : Form
    {
        private DBAccess dbAccess = new DBAccess();
        private DataTable dtUsers = new DataTable();

        public FRM_EditUser()
        {
            InitializeComponent();
        }

        private void FRM_EditUser_Load(object sender, EventArgs e)
        {
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {

        }

        private void TXTBX_Id_KeyUp(object sender, KeyEventArgs e)
        {
            int id;
            if (!int.TryParse(TXTBX_Id.Text, out id) && !string.IsNullOrEmpty(TXTBX_Id.Text)) MessageBox.Show("Please enter an ID");
            else fillTXTBX(id);
        }

        private void fillTXTBX(int id)
        {
            string query = "Select * from TBL_Users Where ID ='" + id + "'";
            dbAccess.readDatathroughAdapter(query, dtUsers);

            try
            {
                TXTBX_FirstName.Text = dtUsers.Rows[0]["Name"].ToString();
                TXTBX_UserName.Text = dtUsers.Rows[0]["UserName"].ToString();
                TXTBX_Email.Text = dtUsers.Rows[0]["Email"].ToString();
                TXTBX_PhoneNumber.Text = dtUsers.Rows[0]["PhoneNumber"].ToString();
                TXTBX_PassWord.Text = dtUsers.Rows[0]["PassWord"].ToString();

                if (dtUsers.Rows[0]["Role"].ToString() == "Admin") RB_Admin.Checked = true;
                else RB_Librarian.Checked = true;
            }
            catch (IndexOutOfRangeException ex)
            {
                if (!string.IsNullOrEmpty(TXTBX_Id.Text)) MessageBox.Show("ID '" + id + "' does not exist");    
            }

            dtUsers.Clear();
        }
    }
}
