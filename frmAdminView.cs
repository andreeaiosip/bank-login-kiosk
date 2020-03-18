using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Cyanair_Booking_App
{
    public partial class frmAdminView : Form
    {
        public bookingClass myBooking;
        public SQLiteConnection conn;
        public string UserID;

        public DataTable dt = new DataTable();


        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public frmAdminView()
        {
            InitializeComponent();
        }

        // Close form
        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ADD AIRPORTS
        private void btnAddAirport_Click(object sender, EventArgs e)
        {
  
      string  mySQL = @"INSERT INTO airport ('city') VALUES (' " + boxNewAirport.Text + " ') ";

            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            SQLiteCommand sQLCmd = new SQLiteCommand(mySQL, conn); sQLCmd.ExecuteNonQuery(); conn.Close();
        }



        private void frmAdminView_Load(object sender, EventArgs e)
        {

            // VIEW AIRPORTS
            string mySQL = $@"SELECT * FROM airport";

            SQLiteDataAdapter Da = new SQLiteDataAdapter(mySQL, conn);
            DataTable ds = new DataTable();
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }

            Da.Fill(ds);
            Da.Dispose();

            dgvAirports.DataSource = ds;

            dgvAirports.Columns["airportID"].Visible = true;
            dgvAirports.Columns["departAirportID"].Visible = false;
            dgvAirports.Columns["destAirportID"].Visible = false;
            dgvAirports.RowHeadersVisible = false;
            dgvAirports.ColumnHeadersVisible = true;
            dgvAirports.Columns["country"].Width = (dgvAirports.Width / 2);
            dgvAirports.Columns["city"].Width = (dgvAirports.Width / 2);
            dgvAirports.ReadOnly = true;

            conn.Close();



            // VIEW BOOKINGS    

            string mySQL2 = $@"SELECT * FROM booking";

            SQLiteDataAdapter Da2 = new SQLiteDataAdapter(mySQL2, conn);
            DataTable ds2 = new DataTable();
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }

            Da2.Fill(ds2);
            Da2.Dispose();

            dataGridViewBookings.DataSource = ds2;

            dataGridViewBookings.Columns["bookingID"].Visible = false;
            dataGridViewBookings.Columns["bookingRef"].Visible = true;
            dataGridViewBookings.Columns["customerID"].Visible = false;
            dataGridViewBookings.Columns["bookingDate"].Visible = false;
            dataGridViewBookings.Columns["dateFlight1"].Visible = true;
            dataGridViewBookings.Columns["deptFlight1"].Visible = true;
            dataGridViewBookings.Columns["destFlight1"].Visible = true;
            dataGridViewBookings.Columns["dateFlight2"].Visible = true;
            dataGridViewBookings.Columns["deptFlight2"].Visible = true;
            dataGridViewBookings.Columns["destFlight2"].Visible = true;
            dataGridViewBookings.Columns["seatAllocationID"].Visible = false;
            dataGridViewBookings.RowHeadersVisible = false;
            dataGridViewBookings.ColumnHeadersVisible = true;
            dataGridViewBookings.ReadOnly = true;

            conn.Close();

        }


        // DELETE AIRPORTS                
        public string myDelSQL;
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvAirports.SelectedRows.Count < 0)
            {
                MessageBox.Show("Select a Airport to Delete!");

            }

            if (dgvAirports.SelectedCells.Count > 0)
            {

                string Airportid = dgvAirports.SelectedCells[0].Value.ToString();

                myDelSQL = $@"DELETE FROM airport
             WHERE airportID = '" + Airportid + "';";

     conn.Open();
                SQLiteCommand sQLCmd = new SQLiteCommand(myDelSQL, conn);
                sQLCmd.ExecuteNonQuery();

                conn.Close();
            }
        }

       
    }
}