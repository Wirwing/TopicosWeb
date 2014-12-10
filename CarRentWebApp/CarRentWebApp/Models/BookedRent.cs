using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentWebApp.Models
{
    public class BookedRent
    {
        private String uuid;
        private String bookedDate;
        private String status;

        public string Uuid
        {
            get { return uuid; }
            set { uuid = value; }
        }

        public string BookedDate
        {
            get { return bookedDate; }
            set { bookedDate = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}