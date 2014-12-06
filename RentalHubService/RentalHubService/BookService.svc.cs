using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RentalHubService
{
    
    public class CarBookService : ICarBookService
    {

        private static List<CarBooking> Bookings = new List<CarBooking>()
        {
            new CarBooking() { RentId = "123", Provider = "Proveedor1"},
            new CarBooking() { RentId = "324", Provider = "Proveedor1"},
            new CarBooking() { RentId = "456", Provider = "Proveedor1" },
            new CarBooking() { RentId = "678", Provider = "Proveedor1" }
        };
        
        public List<CarBooking> AddLoggedCarBookings(CarBooking booking)
        {
            Bookings.Add(booking);
            return Bookings;
        }

        public List<CarBooking> GetLoggedBookings()
        {
            return Bookings;
        }

    }
}
