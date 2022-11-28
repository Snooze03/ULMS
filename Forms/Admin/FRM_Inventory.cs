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
    public partial class FRM_Admin_Inventory : Form
    {
        public FRM_Admin_Inventory()
        {
            InitializeComponent();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            FRM_AddBook addBook = new FRM_AddBook();
            addBook.ShowDialog();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            FRM_Delete delete = new FRM_Delete();
            delete.ShowDialog();
        }
    }
}
