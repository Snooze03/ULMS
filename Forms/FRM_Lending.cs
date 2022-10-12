using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULMS_Forms.Forms
{
    public partial class FRM_Lending : Form
    {
        public FRM_Lending()
        {
            InitializeComponent();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            FRM_StudentLend studentLend = new FRM_StudentLend();
            studentLend.ShowDialog();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            FRM_DeleteStudent delStudent = new FRM_DeleteStudent();
            delStudent.ShowDialog();
        }
    }
}
