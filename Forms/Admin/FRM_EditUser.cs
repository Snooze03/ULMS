using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private int id;

        public FRM_EditUser()
        {
            InitializeComponent();
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            string newName = TXTBX_LastName.Text + ", " + TXTBX_FirstName.Text;
            string newUserName = TXTBX_UserName.Text;
            string newPassWord = TXTBX_PassWord.Text;
            string newRole;
            string newPhoneNumber = TXTBX_PhoneNumber.Text;
            string newEmail = TXTBX_Email.Text;

            if (RB_Admin.Checked) newRole = "Admin";
            else newRole = "Librarian";

            if (IsValid())
            {
                string query = "Update TBL_Users SET Name ='" + newName + "', UserName ='" + newUserName + "', PassWord ='" + newPassWord + "', Role ='" + newRole + "', PhoneNumber ='" + newPhoneNumber + "', Email ='" + newEmail + "' WHERE ID ='" + id + "'";

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@newName", newName);
                updateCommand.Parameters.AddWithValue("@newUserName", newUserName);
                updateCommand.Parameters.AddWithValue("@newPassWord", newPassWord);
                updateCommand.Parameters.AddWithValue("@newRole", newRole);
                updateCommand.Parameters.AddWithValue("@newPhoneNumber", newPhoneNumber);
                updateCommand.Parameters.AddWithValue("@newEmail", newEmail);

                int row = dbAccess.executeQuery(updateCommand);

                if (row == 1) MessageBox.Show("User has been updated!");
            }
            else MessageBox.Show("Empty fields are not allowed");
        }

        private void TXTBX_Id_KeyUp(object sender, KeyEventArgs e)
        {
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

        // Checks if textboxes are filled
        private bool IsValid()  
        {
            bool validData = true;
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox textbox = control as TextBox;
                    validData &= !string.IsNullOrWhiteSpace(textbox.Text);
                }
            }

            if (validData) return true;
            return false;
        }
    }
}
