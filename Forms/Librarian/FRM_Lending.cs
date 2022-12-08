using DatabaseProject;
using System;
using System.Data;
using System.Windows.Forms;
using ULMS_Forms.Forms.Librarian;

namespace ULMS_Forms.Forms
{
    public partial class FRM_Lending : Form
    {
        private DBAccess dbAccess = new DBAccess();
        private DataTable dtLending = new DataTable();
        private DataTable overdues = new DataTable();

        public FRM_Lending()
        {
            InitializeComponent();
        }

        private void FRM_Lending_Load(object sender, EventArgs e)
        {
            string query = "Select * from TBL_Students";
            dbAccess.readDatathroughAdapter(query, dtLending);
            DGV_Lending.DataSource = dtLending;

            // cheks for overdue's
            foreach(DataRow row in dtLending.Rows)
            {
                DateTime currentTime = DateTime.Now;
                DateTime returnDate = (DateTime)row["ReturnDate"];

                // Compares if current time is greater than return date 
                int result = DateTime.Compare(currentTime, returnDate); 

                if (result > 0)
                {
                    Console.WriteLine($"{row["Name"]} Overdue!");

                    // Updates the datatable 
                    string updateQuery = "Update TBL_Students SET Overdue ='" + true + "'Where ID ='" + int.Parse(row["ID"].ToString()) + "'";
                    dbAccess.readDatathroughAdapter(updateQuery, dtLending);
                    DGV_Lending.DataSource = dtLending;
                }
            }

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

        private void BTN_Email_Click(object sender, EventArgs e)
        {
            string query = "Select * from TBL_Students Where Overdue ='" + true + "'";

            dbAccess.readDatathroughAdapter(query, overdues);

            foreach(DataRow row in overdues.Rows)
            {
                Console.WriteLine(row["Email"].ToString());

                // Insert logic to email student
            }

            dbAccess.closeConn();
        }
    }
}
