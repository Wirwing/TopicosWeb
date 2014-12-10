using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarRentWebApp.GetCarServiceReference;
using CarRentWebApp.GetCarsServiceReference;
using CarRentWebApp.Models;
using CarRentWebApp.RentCarServiceReference;

namespace CarRentWebApp.Controllers
{
    public class HomeController : Controller
    {

        private static readonly List<Car> Cars = new List<Car>();

        public ActionResult Index()
        {

            if (Cars.Count != 0) return View(Cars);

            var client = new GetCarsWSDLPortTypeClient();
            car1[] bechCars = new car1[] { };
            var kutzCars = client.GetCarsWSDLOperation("chido", out bechCars);

            Cars.AddRange(bechCars.Select(bechCar => new Car() { Id = bechCar.id, Name = bechCar.brand, Provider = "bech" }));
            Cars.AddRange(kutzCars.Select(kutzCar => new Car() { Id = kutzCar.id, Name = kutzCar.brand, Provider = "kutz" }));

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
        
        public ActionResult RentCar(int? id, string provider)
        {

            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var client = new GetCarWSDLPortTypeClient();
            var carWsResponse = client.GetCarWSDLOperation(id.GetValueOrDefault(1), provider);

            var car = new Car()
            {
                Id = carWsResponse.id,
                Name = carWsResponse.brand,
                PricePerDay = carWsResponse.pricePerDay,
                Provider = provider,
                Transmission = carWsResponse.transmission
            };
            var rent = new Rent { Car = car };
            return View(rent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RentCar([Bind(Include = "StartDate, EndDate, Car")]Rent rent, int Id, String Provider)
        {

            var client = new RentCarWSDLPortTypeClient();

            var rentalDate = rent.StartDate.ToString("dd/mm/yyyy");
            var returnDate = rent.EndDate.ToString("dd/mm/yyyy");
            const string userId = "1";
            var response = client.RentCarWSDLOperation(rentalDate, returnDate
                , Id, userId, Provider);

            return RedirectToAction("Index", "Rent");

        }

    }
}