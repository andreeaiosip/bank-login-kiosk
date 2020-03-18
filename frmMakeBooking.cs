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
    public partial class frmMakeBooking : Form
    {
        static customerClass customer = new customerClass();
        bookingClass myBooking = new bookingClass(customer);

        static string mydataSource = "Data Source=C:\\database\\cyannew.db";
        public SQLiteConnection conn = new SQLiteConnection(mydataSource);


        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public frmMakeBooking()
        {
            InitializeComponent();
            pnlSecondFlight.Visible = false;

        }

        // When page loads the airports will be inserted in the comboboxes
        private void frmMakeBooking_Load(object sender, EventArgs e)
        {
            try
            {

                dateLeg1.MinDate = DateTime.Today;
                dateLeg2.MinDate = dateLeg1.Value;
                conn = new SQLiteConnection(mydataSource);
                cmd = new SQLiteCommand();
                cmd.CommandText = @"SELECT city FROM airport ORDER BY city ASC";
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cboDepartureLeg2.Items.Add(dr["city"]);
                    cboDestinationLeg2.Items.Add(dr["city"]);
                }

                dr.Close();
                conn.Close();

                DataTable dtDepart1 = new DataTable();
                DataTable dtDestin1 = new DataTable();
                DataTable dtDepart2 = new DataTable();
                DataTable dtDestin2 = new DataTable();

                string mySQL2 = $@"SELECT city,airportID  FROM airport ORDER BY city ASC;";
                SQLiteDataAdapter Da = new SQLiteDataAdapter(mySQL2, conn);
                SQLiteDataAdapter Da2 = new SQLiteDataAdapter(mySQL2, conn);
                SQLiteDataAdapter Da3 = new SQLiteDataAdapter(mySQL2, conn);
                SQLiteDataAdapter Da4 = new SQLiteDataAdapter(mySQL2, conn);

                dtDepart1 = new DataTable();
                Da.Fill(dtDepart1);


                cboDepartureLeg1.DataSource = dtDepart1;
                cboDepartureLeg1.DisplayMember = "city";
                cboDepartureLeg1.ValueMember = "city";


                dtDepart2 = new DataTable();
                Da2.Fill(dtDepart2);

                cboDepartureLeg2.DataSource = dtDepart2;
                cboDepartureLeg2.DisplayMember = "city";
                cboDepartureLeg2.ValueMember = "city";

                dtDestin2 = new DataTable();
                Da3.Fill(dtDestin1);

                cboDestinationLeg1.DataSource = dtDestin1;
                cboDestinationLeg1.DisplayMember = "city";
                cboDestinationLeg1.ValueMember = "city";

                dtDestin2 = new DataTable();
                Da4.Fill(dtDestin2);

                cboDestinationLeg2.DataSource = dtDestin2;
                cboDestinationLeg2.DisplayMember = "city";
                cboDestinationLeg2.ValueMember = "city";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void boxReturn_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == checkboxLeg2)
            {
                checkboxLeg1.Checked = !checkboxLeg2.Checked;
            }
            else
            {
                checkboxLeg2.Checked = !checkboxLeg1.Checked;
                pnlSecondFlight.Visible = checkboxLeg2.Checked;

                if (cboDepartureLeg2.Text == cboDestinationLeg2.Text)
                {
                    MessageBox.Show("Destination and Departure airport cannot be the same.");
                }
            }
        }



        // Open admin login form
        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmAdminLog myForm = new frmAdminLog();
            this.Hide();
            myForm.conn = conn;
            myForm.ShowDialog();
            this.Close();

        }



        private void dateTimeDept_ValueChanged(object sender, EventArgs e)
        {
            dateLeg2.MinDate = dateLeg1.Value;
        }

        // PASSENGER'S NAME
        private void txtBoxFName_Leave(object sender, EventArgs e)
        {
            myBooking.getCustomer().setfName(txtBoxFName.Text);
        }

        private void txtBoxLName_Leave(object sender, EventArgs e)
        {

        }

        // FLIGHT 1
        private void cboDepartureLeg1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDepartureLeg1_Leave(object sender, EventArgs e)
        {


        }
        private void cboDestinationLeg1_Leave(object sender, EventArgs e)
        {
            // myBooking.setDest_airport(cboDestinationLeg1.Text);
        }

        private void dateLeg1_ValueChanged(object sender, EventArgs e)
        {

        }



        // FLIGHT 2

        private void cboDestinationLeg2_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void cboDepartureLeg2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // myBooking.setdepart_airport_flight2(cboDepartureLeg2.SelectedValue.ToString());
        }

        private void cboDestinationLeg2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void dateLeg2_ValueChanged(object sender, EventArgs e)
        {



        }



        // BOOK BUTTON

        private void btnBook_Click(object sender, EventArgs e)
        {

            bool allinfo_ok = true;

            // Error trapping...
            if (myBooking.getCustomer().getfName() == "" || myBooking.getCustomer().getfName() == null)
            {
                MessageBox.Show("Please enter the passenger's name.");
                allinfo_ok = false;
            }

            if (cboDepartureLeg1.Text == cboDestinationLeg1.Text)
            {
                MessageBox.Show("Destination airport and departure airport cannot be the same.");
                allinfo_ok = false;
            }


            if (allinfo_ok)

            {
                myBooking.getCustomer().setlName(txtBoxLName.Text);


                if (cboDepartureLeg1.SelectedItem != null)
                {
                    myBooking.setDepart_airport(cboDepartureLeg1.SelectedValue.ToString());
                }


                myBooking.setDepart_airport(cboDepartureLeg1.Text);

                myBooking.setDest_airport(cboDestinationLeg1.Text);

                myBooking.DepartureDate = Convert.ToDateTime(dateLeg1.Text);



                if (checkboxLeg2.Checked == true)
                {

                    myBooking.returning = true;
                    if (cboDestinationLeg2.SelectedItem != null)
                    {
                        myBooking.setdest_airport_flight2(cboDestinationLeg2.SelectedValue.ToString());
                    }

                    myBooking.setdepart_airport_flight2(cboDepartureLeg2.SelectedValue.ToString());

                    myBooking.setdest_airport_flight2(cboDestinationLeg2.SelectedValue.ToString());

                    myBooking.setDepartureDate_f2(dateLeg2.Value);
                }

                   // Generating booking reference
                Random r = new Random();
                myBooking.bookingRef = r.Next();


                string myNewFlight;
                string myNEWinsert;
                string CustomerID_From_DB;
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }


                // Insert customer details into database
                myNEWinsert = "INSERT INTO customer (customerFirstName,customerLastName) VALUES ('" + myBooking.getCustomer().getfName() + "','" + myBooking.getCustomer().getlName() + "');";
                SQLiteCommand sQLCmd = new SQLiteCommand(myNEWinsert, conn);
                sQLCmd.ExecuteNonQuery();


                // Insert flight details into database
                myNewFlight = "INSERT INTO booking (bookingRef, deptFlight1,destFlight1,deptFlight2,destFlight2,dateFlight1,dateFlight2  ) VALUES ('" + myBooking.bookingRef + "','" + myBooking.getDepart_airport() + "','" + myBooking.getDest_airport() + "','" + myBooking.getdepart_airport_flight2() + "','" + myBooking.getdest_airport_flight2() + "','" + myBooking.getDepartureDate() + "','" + myBooking.getDepartureDate_flight2() + "'); ";
                SQLiteCommand sQLCmdFlight = new SQLiteCommand(myNewFlight, conn);
                sQLCmdFlight.ExecuteNonQuery();

                cmd.CommandText = @"SELECT customerID FROM customer WHERE customerFirstName='" + myBooking.getCustomer().getfName() + "' AND customerLastName='" + myBooking.getCustomer().getlName() + "' ";
                cmd.Connection = conn;

                dr = cmd.ExecuteReader();
                CustomerID_From_DB = "";
                while (dr.Read())
                {
                    CustomerID_From_DB = dr["customerID"].ToString();
                }


                dr.Close();


                txtBoxFName.Text = "";
                txtBoxLName.Text = "";
                cboDepartureLeg1.Text = "";
                cboDepartureLeg2.Text = "";
                cboDestinationLeg1.Text = "";
                cboDestinationLeg2.Text = "";



                // Open confirmation form
                frmConfirmation myNewform = new frmConfirmation(myBooking);

                myNewform.Show();



            }


        }


    }
}