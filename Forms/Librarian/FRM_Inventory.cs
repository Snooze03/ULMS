using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULMS_Forms.Forms;

namespace ULMS_Forms
{
    public partial class FRM_Books : Form
    {
        private DBAccess dbAccess = new DBAccess();
        private DataTable dtInventory = new DataTable();

        public FRM_Books()
        {
            InitializeComponent();
        }
        private void FRM_Books_Load(object sender, EventArgs e)
        {
            string query = "Select * from TBL_Books";

            dbAccess.readDatathroughAdapter(query, dtInventory);

            DGV_Inventory.DataSource = dtInventory;
            dbAccess.closeConn();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            FRM_AddBook addBook = new FRM_AddBook();
            addBook.ShowDialog();
        }

    }
}
