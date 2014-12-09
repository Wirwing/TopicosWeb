using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRentWebApp.CarServiceReference;

namespace CarRentWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var client = new GetCarsWSDLPortTypeClient();
            
            car1[] bechCars;
            var kutzCars = client.GetCarsWSDLOperation(out bechCars);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}