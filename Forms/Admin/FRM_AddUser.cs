using DatabaseProject;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ULMS_Forms.Forms.Admin
{
    public partial class FRM_AddUser : Form
    {
        private DBAccess dbAccess = new DBAccess();

        public FRM_AddUser()
        {
            InitializeComponent();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            string fullName = TXTBX_LastName.Text + ", " + TXTBX_FirstName.Text;
            string userName = TXTBX_UserName.Text;
            string passWord = TXTBX_PassWord.Text;
            string role;
            string phoneNumber = TXTBX_PhoneNumber.Text;
            string email = TXTBX_Email.Text;

            if (RB_Admin.Checked == true) role = "Admin";
            else role = "Librarian";

            if (IsValid())
            {
                SqlCommand insertCommand = new SqlCommand("insert into TBL_Users(Name, UserName, PassWord, Role, PhoneNumber, Email) values(@fullName, @userName, @passWord, @role, @phoneNumber, @email)");

                insertCommand.Parameters.AddWithValue("@fullName", fullName);
                insertCommand.Parameters.AddWithValue("@userName", userName);
                insertCommand.Parameters.AddWithValue("@passWord", passWord);
                insertCommand.Parameters.AddWithValue("@role", role);
                insertCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                insertCommand.Parameters.AddWithValue("@email", email);

                int row = dbAccess.executeQuery(insertCommand);

                if (row == 1) MessageBox.Show("User has been added!");
            }
            else MessageBox.Show("Empty fields are not allowed");
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
