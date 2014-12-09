using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentWebApp.Models
{
    public class Car
    {
        private String id;
        private String name;
        private String provider;

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

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}