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

namespace ULMS_Forms
{
    public partial class FRM_DBPanel : Form
    {
        private DBAccess dbAccess = new DBAccess();
        private DataTable dtStudents = new DataTable(), dtBooks = new DataTable();

        private int students, books, overdues;

        public FRM_DBPanel()
        {
            InitializeComponent();
        }

        private void FRM_DashBoard_Load(object sender, EventArgs e)
        {
            // Update student Label
            string studentQuery = "Select * From TBL_Students";
            dbAccess.readDatathroughAdapter(studentQuery, dtStudents);

            foreach(DataRow dr in dtStudents.Rows) students++;

            LBL_StudentsNO.Text = students.ToString();


            // Update books Label
            string booksQuery = "Select * From TBL_Books";
            dbAccess.readDatathroughAdapter(booksQuery, dtBooks);

            foreach(DataRow dr in dtBooks.Rows) books++;

            LBL_BooksNO.Text = books.ToString();


            // Update overdue Label
            dtStudents.Clear();
            string query = "Select * From TBL_Students Where Overdue ='" + true + "'";
            dbAccess.readDatathroughAdapter(query, dtStudents);

            foreach(DataRow dr in dtStudents.Rows) overdues++;

            LBL_OverDueNO.Text = overdues.ToString();

        }
    }
}
