using System;
using System.Drawing;
using System.Windows.Forms;

namespace ULMS_Forms.src
{
    class FRM_Events
    {
        public void TXTBX_InsertPlaceHolder(TextBox txtBX, string plHolder, Boolean isPSWD = false)
        {
            if (String.IsNullOrEmpty(txtBX.Text))
            {
                txtBX.Text = plHolder;
                txtBX.ForeColor = Color.LightGray;
                if (isPSWD) txtBX.PasswordChar = '\0';
            }
        }

        public void TXTBX_DelPlaceHolder(TextBox txtBX, string plHolder, Boolean isPSWD = false)
        {
            char pswdChar = '*';

            if (txtBX.Text == plHolder)
            {
                txtBX.Text = "";
                txtBX.ForeColor = Color.White;
                if (isPSWD) txtBX.PasswordChar = pswdChar;
            }
        }
    }
}
