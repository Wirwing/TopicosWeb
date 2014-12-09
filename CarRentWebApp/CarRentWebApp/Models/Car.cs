using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentWebApp.Models
{
    public class Car
    {
        private int id;
        private String name;
        private String provider;

        private string transmission;
        private double pricePerDay;

        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Transmission
        {
            get { return transmission; }
            set { transmission = value; }
        }

        public double PricePerDay
        {
            get { return pricePerDay; }
            set { pricePerDay = value; }
        }
    }
}