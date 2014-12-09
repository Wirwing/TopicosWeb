using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRentWebApp.CarServiceReference;
using CarRentWebApp.Models;

namespace CarRentWebApp.Controllers
{
    public class HomeController : Controller
    {

        private static List<Car> Cars = new List<Car>();

        public ActionResult Index()
        {
            if (Cars.Count != 0) return View(Cars);

            var client = new GetCarsWSDLPortTypeClient();
            car1[] bechCars;
            var kutzCars = client.GetCarsWSDLOperation(out bechCars);

            Cars.AddRange(bechCars.Select(bechCar => new Car() { Id = bechCar.id.ToString(), Name = bechCar.brand, Provider = "Bech" }));
            Cars.AddRange(kutzCars.Select(kutzCar => new Car() { Id = kutzCar.id.ToString(), Name = kutzCar.brand, Provider = "Kutz" }));

            return View(Cars);

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


        public ActionResult RentCar(string id, string provider)
        {
            var found = Cars.Find(car => car.Id.Equals(id) && car.Provider.Equals(provider));
            Debug.WriteLine("Car GET: " + found.Name + ","  + found.Provider);
            return RedirectToAction("Index");
        }

    }
}