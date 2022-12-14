using System;
using System.Threading;
using ULMS_Forms.src;
using System.Windows.Forms;

namespace ULMS_Forms.Forms
{
    public partial class FRM_AdminDB : Form
    {
        private FRM_Events frmEvents = new FRM_Events();

        public FRM_AdminDB()
        {
            InitializeComponent();
        }

        private void IBTN_Inventory_Click(object sender, EventArgs e)
        {
            frmEvents.PNL_ShowForm(PNL_DashBoard, new FRM_Admin_Inventory());
        }

        private void IBTN_Users_Click(object sender, EventArgs e)
        {
            frmEvents.PNL_ShowForm(PNL_DashBoard, new FRM_AdminUserEditor());
        }

        private void IBTN_LogOut_Click(object sender, EventArgs e)
        {
            Thread th;

            th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();
        }

        private void OpenNewForm()
        {
            Application.Run(new FRM_Login());
        }

    }
}
