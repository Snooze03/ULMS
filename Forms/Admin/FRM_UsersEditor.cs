using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULMS_Forms.Forms.Admin;

namespace ULMS_Forms.Forms
{
    public partial class FRM_AdminUserEditor : Form
    {
        public FRM_AdminUserEditor()
        {
            InitializeComponent();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            FRM_AddUser addUser = new FRM_AddUser();
            addUser.ShowDialog();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            FRM_Delete delete = new FRM_Delete();
            delete.ShowDialog();
        }
    }
}
