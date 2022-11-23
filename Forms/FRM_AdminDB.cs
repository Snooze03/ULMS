using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ULMS_Forms.Forms
{
    public partial class FRM_AdminDB : Form
    {
        Thread th;

        public FRM_AdminDB()
        {
            InitializeComponent();
        }

        private void IBTN_LogOut_Click(object sender, EventArgs e)
        {
            th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void OpenNewForm()
        {
            Application.Run(new FRM_Login());
        }
    }
}
