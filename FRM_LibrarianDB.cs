using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ULMS_Forms
{
    public partial class FRM_LibrarianDB : Form
    {
        public FRM_LibrarianDB()
        {
            InitializeComponent();
            showChildFRM(new FRM_DashBoard());
        }

        private void showChildFRM(object childFRM)
        {
            if (this.PNL_DashBoard.Controls.Count > 0) this.PNL_DashBoard.Controls.RemoveAt(0);

            Form form = childFRM as Form;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.PNL_DashBoard.Controls.Add(form);
            form.Show();

            FRM_DashBoard db = new FRM_DashBoard();
        }

        private void IBTN_DashBoard_Click(object sender, EventArgs e)
        {
            IBTN_DashBoard.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showChildFRM(new FRM_DashBoard());
        }

        private void IBTN_Inventory_Click(object sender, EventArgs e)
        {
            showChildFRM(new FRM_Inventory());
        }

        private void IBTN_LogOut_Click(object sender, EventArgs e)
        {
            FRM_Login login = new FRM_Login();
            login.Show();
            this.Close();
        }

        private void IBTN_Lending_Click(object sender, EventArgs e)
        {

        }
    }
}
