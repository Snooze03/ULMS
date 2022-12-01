using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DatabaseProject;

namespace ULMS_Forms.Forms
{
    public partial class FRM_AddBook : Form
    {
        DBAccess dbAccess = new DBAccess();
        private string genre;

        public FRM_AddBook()
        {
            InitializeComponent();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            string title = TXTBX_Title.Text;
            string authorName = TXTBX_LastName.Text + ", " + TXTBX_LastName.Text;
            decimal price = decimal.Parse(TXTBX_Price.Text);
            DateTime datePublished = DTP_DatePub.Value;

            if (IsValid())
            {
                SqlCommand insertCommand = new SqlCommand("insert into TBL_Books(Title, Author, Genre, Price, DatePublished) values(@title, @authorName, @genre, @price, @datePublished)");

                insertCommand.Parameters.AddWithValue("@title", title);
                insertCommand.Parameters.AddWithValue("@authorName", authorName);
                insertCommand.Parameters.AddWithValue("@genre", genre);
                insertCommand.Parameters.AddWithValue("@price", price);
                insertCommand.Parameters.AddWithValue("@datePublished", datePublished);

                int row = dbAccess.executeQuery(insertCommand);

                if (row == 1) MessageBox.Show("'" + title + "' has been added!");
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

        private void CBX_Genre_SelectionChangeCommitted(object sender, EventArgs e)
        {
           genre = CBX_Genre.GetItemText(CBX_Genre.SelectedItem);  
        }
    }
}
