using System;
using System.Windows.Forms;
using System.Threading;
using ULMS_Forms.Forms;
using ULMS_Forms.src;
using Application = System.Windows.Forms.Application;

namespace ULMS_Forms
{
    public partial class FRM_LibrarianDB : Form
    {
        private FRM_Events frmEvents = new FRM_Events();

        // UI instances
        private FRM_DBPanel db = new FRM_DBPanel();
        private FRM_Books inven = new FRM_Books();
        private FRM_Lending lend = new FRM_Lending();

        public FRM_LibrarianDB()
        {
            InitializeComponent();

            frmEvents.PNL_ShowForm(PNL_DashBoard, new FRM_DBPanel());
        }


        private void IBTN_DashBoard_Click(object sender, EventArgs e)
        {
            frmEvents.PNL_ShowForm(PNL_DashBoard, db);
        }

        private void IBTN_Inventory_Click(object sender, EventArgs e)
        {
            frmEvents.PNL_ShowForm(PNL_DashBoard, inven);
        }

        private void IBTN_Lending_Click(object sender, EventArgs e)
        {
            frmEvents.PNL_ShowForm(PNL_DashBoard, lend);
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
