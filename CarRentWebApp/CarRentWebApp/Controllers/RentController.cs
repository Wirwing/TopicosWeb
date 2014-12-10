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

            var client = new GetBookedRentsPortTypeClient();

            var bookedRents = client.GetBookedRentsOperation();

            var rents = bookedRents.Select(bookedRent => new BookedRent()
            {
                Uuid = bookedRent.id, BookedDate = bookedRent.bookedDate, Status = bookedRent.status
            }).ToList();

            return View(rents);
        }
    }
}