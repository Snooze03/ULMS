using FontAwesome.Sharp;
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
using ULMS_Forms.Forms;

namespace ULMS_Forms
{
    public partial class FRM_LibrarianDB : Form
    {
        Boolean activeBTN;

        public FRM_LibrarianDB()
        {
            InitializeComponent();

            showChildFRM(new FRM_DashBoard());
            highLight(IBTN_DashBoard, IBTN_Inventory, IBTN_Lending);
        }

        private void highLight(IconButton focused, IconButton btn1, IconButton btn2)
        {
            focused.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn1.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn2.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            highLight(IBTN_DashBoard, IBTN_Inventory, IBTN_Lending);
            showChildFRM(new FRM_DashBoard());
        }

        private void IBTN_Inventory_Click(object sender, EventArgs e)
        {
            highLight(IBTN_Inventory, IBTN_DashBoard, IBTN_Lending);
            showChildFRM(new FRM_Inventory());
        }

        private void IBTN_Lending_Click(object sender, EventArgs e)
        {
            highLight(IBTN_Lending, IBTN_DashBoard, IBTN_Inventory);
            showChildFRM(new FRM_Lending());
        }
        private void IBTN_LogOut_Click(object sender, EventArgs e)
        {
            FRM_Login login = new FRM_Login();
            login.Show();
            this.Close();
        }
    }
}
