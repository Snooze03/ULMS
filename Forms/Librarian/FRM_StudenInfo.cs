using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using DatabaseProject;

namespace ULMS_Forms.Forms
{
    public partial class FRM_StudenInfo : Form
    {
        private DBAccess dbAccess = new DBAccess();

        public FRM_StudenInfo()
        {
            InitializeComponent();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            // Store input in vars
            string fullName = TXTBX_LastName.Text + ", " + TXTBX_FirstName.Text;
            string phoneNumber = TXTBX_PhoneNumber.Text;
            string email = TXTBX_Email.Text;
            string book = TXTBX_PhoneNumber.Text;
            DateTime returnDate = DTP_ReturnDate.Value+ DTP_ReturnTime.Value.TimeOfDay;
            bool isOverdue = false;

            if (IsValid())
            {
                SqlCommand insertCommand = new SqlCommand("insert into TBL_Students(Name, Email, PhoneNumber, Book, ReturnDate, Overdue) values(@fullName, @email, @phoneNumber, @book, @returnDate, @isOverdue)");

                insertCommand.Parameters.AddWithValue("@fullName", fullName);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                insertCommand.Parameters.AddWithValue("@book", book);
                insertCommand.Parameters.AddWithValue("@returnDate", returnDate);
                insertCommand.Parameters.AddWithValue("@isOverdue", isOverdue);

                int row = dbAccess.executeQuery(insertCommand);

                if (row == 1) MessageBox.Show("Student has been added!");
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
