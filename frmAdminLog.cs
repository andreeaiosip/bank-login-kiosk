using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;


namespace Cyanair_Booking_App
{
    public partial class frmAdminLog : Form
    {
        public SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public frmAdminLog()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            string mySQL = @"SELECT * FROM user WHERE username='admin' LIMIT 1";
            SQLiteDataAdapter Da = new SQLiteDataAdapter(mySQL, conn);
            DataTable dt = new DataTable();
            Da.Fill(dt);
            Da.Dispose();

            string password = "";
            string UserID = "";


            foreach (DataRow row in dt.Rows)
            {

                password = row["password"].ToString();
                UserID = row["UserID"].ToString();
            }


            if (textBoxPassword.Text == password)
            {

                frmAdminView myAdminViewForm = new frmAdminView();
                this.Hide();
                myAdminViewForm.conn = conn;
                myAdminViewForm.UserID = UserID;
                myAdminViewForm.ShowDialog();
                this.Close();
            }
            else
            {
                if (textBoxPassword.Text != password)
                {

                    DialogResult myResult;
                    myResult = MessageBox.Show("Wrong password. Please try again.", "Password alert", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
                else
                {

                    DialogResult myResult;
                    myResult = MessageBox.Show("Please insert password.", "Password alert", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}