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
using DatabaseProject;

namespace ULMS_Forms.Forms.Admin
{
    public partial class FRM_EditBook : Form
    {
        private DBAccess dbAccess = new DBAccess();
        private DataTable dtBooks = new DataTable();

        private string newGenre;
        private int id;

        public FRM_EditBook()
        {
            InitializeComponent();
        }


        private void BTN_Update_Click(object sender, EventArgs e)
        {
            string newTitle = TXTBX_Title.Text;
            string newAuthor = TXTBX_LastName.Text + ", " + TXTBX_FirstName.Text;
            decimal newPrice = decimal.Parse(TXTBX_Price.Text);
            DateTime newPubDate = DTP_DatePub.Value;

            if (IsValid())
            {
                string query = "Update TBL_Books SET Title ='" + newTitle + "', Author ='" + newAuthor + "', Genre ='" + newGenre + "', Price ='" + newPrice + "', DatePublished ='" + newPubDate + "' WHERE ID ='" + id + "'";

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@newTitle", newTitle);
                updateCommand.Parameters.AddWithValue("@newAuthor", newAuthor);
                updateCommand.Parameters.AddWithValue("@newGenre", newGenre);
                updateCommand.Parameters.AddWithValue("@newPrice", newPrice);
                updateCommand.Parameters.AddWithValue("@newPubDate", newPubDate);

                int row = dbAccess.executeQuery(updateCommand);

                if (row == 1) MessageBox.Show("Book has been updated!");
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
            string query = "Select * from TBL_Books Where ID ='" + id + "'";
            dbAccess.readDatathroughAdapter(query, dtBooks);

            try
            {
                TXTBX_Title.Text = dtBooks.Rows[0]["Title"].ToString();
                TXTBX_FirstName.Text = dtBooks.Rows[0]["Author"].ToString();
                CBX_Genre.Text = dtBooks.Rows[0]["Genre"].ToString();
                TXTBX_Price.Text = dtBooks.Rows[0]["Price"].ToString();
                DTP_DatePub.Text = dtBooks.Rows[0]["DatePublished"].ToString();

            }
            catch (IndexOutOfRangeException ex)
            {
                if (!string.IsNullOrEmpty(TXTBX_Id.Text)) MessageBox.Show("ID '" + id + "' does not exist");    
            }

            dtBooks.Clear();
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
           newGenre = CBX_Genre.GetItemText(CBX_Genre.SelectedItem);  
        }
    }
}
