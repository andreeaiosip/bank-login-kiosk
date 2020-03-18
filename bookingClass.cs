using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyanair_Booking_App
{
    public class bookingClass

    {
        customerClass custClass;
        public bool returning;
        string bookingID;
        public int bookingRef;

        //leg1
        string depart_airport;
        string dest_airport;
        public DateTime DepartureDate;

        //leg2
        string depart_airport_flight2;
        string dest_airport_flight2;
        DateTime DepartureDate_flight2;

        public bookingClass(customerClass ccc)
        {
            custClass = ccc;
        }

        public customerClass getCustomer()
        {
            return this.custClass;
        }



        public void setDepartureDate(DateTime date_)
        {
            this.DepartureDate = date_;
        }

        public DateTime getDepartureDate()
        {

            return this.DepartureDate;
        }
        public void setDepartureDate_f2(DateTime date2_)
        {
            this.DepartureDate_flight2 = date2_;
        }

        public DateTime getDepartureDate_flight2()
        {
            return this.DepartureDate_flight2;
        }




        public void setDepart_airport(string airport)
        {
            this.depart_airport = airport;
        }
        public string getDepart_airport()
        {
            return this.depart_airport;
        }

        public string getDest_airport()
        {
            return this.dest_airport;
        }
        public void setDest_airport(string airport)
        {
            this.dest_airport = airport;
        }



        public string getdest_airport_flight2()
        {
            return this.dest_airport_flight2;
        }
        public void setdest_airport_flight2(string airportLeg2)
        {
            this.dest_airport_flight2 = airportLeg2;
        }

        public string getdepart_airport_flight2()
        {
            return this.depart_airport_flight2;
        }
        public void setdepart_airport_flight2(string airportdeptLeg2)
        {
            this.depart_airport_flight2 = airportdeptLeg2;
        }
    }
}