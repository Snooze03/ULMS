using System;
using System.Windows.Forms;

namespace ULMS_Forms.Forms
{
    public partial class FRM_AddBook : Form
    {
        public FRM_AddBook()
        {
            InitializeComponent();
        }

        private void LBL_Title_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            string title = TXTBX_Title.Text;
            string authorName = TXTBX_LastName.Text + ", " + TXTBX_LastName.Text;
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
