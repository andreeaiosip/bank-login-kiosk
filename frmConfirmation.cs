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
    public partial class frmConfirmation : Form
    {
        public bookingClass myBooking;

        public frmConfirmation(bookingClass b)
        {
            InitializeComponent();
            this.myBooking = b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
            lblPassengerFName.Text = myBooking.getCustomer().getfName();
            lblPassengerLName.Text = myBooking.getCustomer().getlName();

            lblDepartConf1.Text = myBooking.getDepart_airport();
            lblArrivalConf1.Text = myBooking.getDest_airport();

            lblDepartConf2.Text = myBooking.getdepart_airport_flight2();
            lblArrivalConf2.Text = myBooking.getdest_airport_flight2();


            lblDateFlight1.Text = myBooking.getDepartureDate().ToShortDateString();

            lblRefNo.Text = myBooking.bookingRef.ToString();
            
            if (myBooking.returning == true)
            {
                lblDateFlight2.Visible = true;  
                lblDateFlight2.Text = myBooking.getDepartureDate_flight2().ToShortDateString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPassengerName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
