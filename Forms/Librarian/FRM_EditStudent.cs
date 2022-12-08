using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULMS_Forms.Forms.Librarian
{
    public partial class FRM_EditStudent : Form
    {
        private DBAccess dbAccess = new DBAccess();
        private DataTable dtStudents = new DataTable();

        private int id;

        public FRM_EditStudent()
        {
            InitializeComponent();
        }

        private void TXTBX_Id_KeyUp(object sender, KeyEventArgs e)
        {
            if (!int.TryParse(TXTBX_Id.Text, out id) && !string.IsNullOrEmpty(TXTBX_Id.Text)) MessageBox.Show("Please enter an ID");
            else fillTXTBX(id);
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            string newName = TXTBX_LastName.Text + ", " + TXTBX_FirstName.Text; 
            string newEmail = TXTBX_Email.Text;
            string newPhoneNumber = TXTBX_PhoneNumber.Text;
            string newBook = TXTBX_Book.Text;
            DateTime newReturnDate = DTP_ReturnDate.Value.Date + DTP_ReturnTime.Value.TimeOfDay;

            if (IsValid())
            {
                string query = "Update TBL_Students SET Name ='" + newName + "', Email ='" + newEmail + "', PhoneNumber ='" + newPhoneNumber + "', Book ='" + newBook + "', ReturnDate ='" + newReturnDate + "' WHERE ID ='" + id + "'";

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@newName", newName);
                updateCommand.Parameters.AddWithValue("@newEmail", newEmail);
                updateCommand.Parameters.AddWithValue("@newPhoneNumber", newPhoneNumber);
                updateCommand.Parameters.AddWithValue("@newBook", newBook);
                updateCommand.Parameters.AddWithValue("@newReturnDate", newReturnDate);

                int row = dbAccess.executeQuery(updateCommand);

                if (row == 1) MessageBox.Show("Student has been updated!");
            }
            else MessageBox.Show("Empty fields are not allowed");
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TXTBX_Id.Text))
            {
                DialogResult dialog = MessageBox.Show($"{id} will be permanently deleted", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    string query = "DELETE from TBL_Students Where ID ='" + id + "'";

                    SqlCommand delete = new SqlCommand(query);

                    int row = dbAccess.executeQuery(delete);

                    if (row == 1)
                    {
                        clearTXTBX();
                        MessageBox.Show("Student has been deleted");
                    }

                }
            }
            else MessageBox.Show("Please enter an ID");
        }

        private void fillTXTBX(int id)
        {
            string query = "Select * from TBL_Students Where ID ='" + id + "'";
            dbAccess.readDatathroughAdapter(query, dtStudents);

            try
            {
                TXTBX_FirstName.Text = dtStudents.Rows[0]["Name"].ToString();
                TXTBX_Email.Text = dtStudents.Rows[0]["Email"].ToString();
                TXTBX_PhoneNumber.Text = dtStudents.Rows[0]["PhoneNumber"].ToString();
                TXTBX_Book.Text = dtStudents.Rows[0]["Book"].ToString();
                DTP_ReturnDate.Text = dtStudents.Rows[0]["ReturnDate"].ToString();

            }
            catch (IndexOutOfRangeException ex)
            {
                if (!string.IsNullOrEmpty(TXTBX_Id.Text)) MessageBox.Show("ID '" + id + "' does not exist");    
            }

            dtStudents.Clear();
        }

        private void clearTXTBX()
        {
            TXTBX_Id.Text = string.Empty;
            TXTBX_FirstName.Text = string.Empty;
            TXTBX_LastName.Text = string.Empty;
            TXTBX_Email.Text = string.Empty;
            TXTBX_PhoneNumber.Text = string.Empty;
            TXTBX_Book.Text = string.Empty;
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
