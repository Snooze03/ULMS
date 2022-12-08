using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using FluentEmail.Smtp;
using FluentEmail.Core;
using DatabaseProject;
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

            foreach(DataRow row in overdues.Rows) EmailClient(row["Email"].ToString());

            overdues.Clear();
            dbAccess.closeConn();
        }

        private async Task EmailClient(string emailAddress)
        {

            DialogResult dialog = MessageBox.Show("Send email to students with overdue's?", "Send", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                var sender = new SmtpSender(() => new SmtpClient("localhost")
                {
                    // disable for testing, enable for production
                    EnableSsl = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Port = 25,
                }) ;

                Email.DefaultSender = sender;
                var email = await Email
                    .From("baayjohnzeus@gmail.com")
                    .To(emailAddress, "ULMS")
                    .Subject("Overdue book")
                    .Body("Please return the the book this day.\nThank you.")
                    .SendAsync();

                MessageBox.Show("Email has been sent successfully!");
            }
        }
    }
}
