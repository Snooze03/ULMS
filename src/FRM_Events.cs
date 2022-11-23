using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace ULMS_Forms.src
{
    class FRM_Events
    {
        // ################# TEXT BOX EVENTS #################

        public void TXTBX_InsertPlaceHolder(TextBox txtBX, string plHolder, bool isPSWD = false)
        {
            if (string.IsNullOrEmpty(txtBX.Text))
            {
                txtBX.Text = plHolder;
                txtBX.ForeColor = Color.LightGray;
                if (isPSWD) txtBX.PasswordChar = '\0';
            }
        }

        public void TXTBX_DelPlaceHolder(TextBox txtBX, string plHolder, bool isPSWD = false)
        {
            char pswdChar = '*';

            if (txtBX.Text == plHolder)
            {
                txtBX.Text = "";
                txtBX.ForeColor = Color.White;
                if (isPSWD) txtBX.PasswordChar = pswdChar;
            }
        }

        // ##################################################


        // ################# PANEL EVENTS ###################

        public void PNL_ShowForm(Panel pnl, object childFRM)
        {
            if (pnl.Controls.Count > 0) pnl.Controls.RemoveAt(0);

            Form form = childFRM as Form;

            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnl.Controls.Add(form);
            form.Show();
        }

        // ##################################################

        // ################# BUTTON EVENTS ##################
        public void BTN_LogOut(Form currentForm)
        {
            Thread th;

            th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            currentForm.Close();
        }

        private void OpenNewForm()
        {
            Application.Run(new FRM_Login());
        }
    }

}
