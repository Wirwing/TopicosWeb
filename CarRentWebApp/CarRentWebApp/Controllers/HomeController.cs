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
            var carWsResponse = client.GetCarWSDLOperation(2, "kutz");


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

    }
}