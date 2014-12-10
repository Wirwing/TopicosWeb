using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRentWebApp.GetBookedServiceReference;

namespace CarRentWebApp.Controllers
{
    public class RentController : Controller
    {
        // GET: Rent
        public ActionResult Index()
        {

            var client = new GetBookedRentsWSDLPortTypeClient();

            var bookedRents = client.GetBookedRentsWSDLOperation("");

            return View();
        }
    }
}