using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULMS_Forms.Forms.Admin
{
    public partial class FRM_AddUser : Form
    {
        public FRM_AddUser()
        {
            InitializeComponent();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            string name = TXTBX_LastName.Text + ", " + TXTBX_FirstName.Text;
            string email = TXTBX_Email.Text;
            string phoneNumber = TXTBX_PhoneNumber.Text;
            string role = CBX_Role.Text;
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
