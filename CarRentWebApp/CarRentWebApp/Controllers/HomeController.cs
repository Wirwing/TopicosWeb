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
        public ActionResult Index()
        {

            //var client = new GetCarsWSDLPortTypeClient();
            
            //car1[] bechCars;
            //var kutzCars = client.GetCarsWSDLOperation(out bechCars);

            List<Car> cars = new List<Car>();

            cars.Add(new Car(){ Id = "1", Name = "Dodge", Provider = "Bech"});
            cars.Add(new Car() { Id = "2", Name = "Ferrari", Provider = "Bech" });
            cars.Add(new Car() { Id = "3", Name = "Jaguar", Provider = "Bech" });

            return View(cars);
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


        public ActionResult Delete(int? id)
        {
            Debug.WriteLine("Car GET: " + id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            
            Debug.WriteLine("Car: " + id);

            return RedirectToAction("Index");
        }

    }
}