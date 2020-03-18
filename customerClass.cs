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
    public class customerClass
    {
        string fName;
        string lName;
        string customerID;
        public customerClass()
        {

        }
        public void setfName(string Name)
        {
            this.fName = Name;
        }
        public void setlName(string Name)
        {
            this.lName = Name;
        }
        public string getfName()
        {
            return this.fName;
        }
        public string getlName()
        {
            return this.lName;
        }
    }
}