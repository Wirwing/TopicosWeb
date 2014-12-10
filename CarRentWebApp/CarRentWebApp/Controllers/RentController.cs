using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRentWebApp.GetBookedServiceReference;
using CarRentWebApp.Models;

namespace CarRentWebApp.Controllers
{
    public class RentController : Controller
    {
        // GET: Rent
        public ActionResult Index()
        {

            var client = new GetBookedRentsWSDLPortTypeClient();

            var bookedRents = client.GetBookedRentsWSDLOperation("");

            var rents = new List<Rent>();

            foreach (var bookedRent in bookedRents)
            {
                rents.Add(new Rent()
                {
                    EndDate = bookedRent.
                });
            }

            return View();
        }
    }
}