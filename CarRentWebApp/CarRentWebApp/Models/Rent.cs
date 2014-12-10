using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentWebApp.Models
{
    public class Rent
    {

        private DateTime startDate;
        private DateTime endDate;

        private Car car;

        public Car Car
        {
            get { return car; }
            set { car = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

    }
}