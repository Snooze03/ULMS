﻿using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULMS_Forms.Forms.Librarian;

namespace ULMS_Forms.Forms
{
    public partial class FRM_Lending : Form
    {
        private DBAccess dbAccess = new DBAccess();
        private DataTable dtLending = new DataTable();

        public FRM_Lending()
        {
            InitializeComponent();
        }

        private void FRM_Lending_Load(object sender, EventArgs e)
        {
            string query = "Select * from TBL_Students";

            dbAccess.readDatathroughAdapter(query, dtLending);

            DGV_Lending.DataSource = dtLending;
            dbAccess.closeConn();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            FRM_StudenInfo studentLend = new FRM_StudenInfo();
            studentLend.ShowDialog();
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            FRM_EditStudent editStudent = new FRM_EditStudent();
            editStudent.ShowDialog();
        }

    }
}
