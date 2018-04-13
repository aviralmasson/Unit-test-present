using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_application.Controllers
{
    public class Car : Controller
    {
        public int ID { get; private set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }

        [NonAction]
        public List<Car>GetCarList()
        {
            return new List<Car>{
            new Car{
               ID = 0001,
               Model = "BMW 530 xdrive",
               Year = 2017,
               Price = 60000
            },

            new Car{
              ID = 0051,
               Model = "Dodge Challenger",
               Year = 2016,
               Price = 45600
            },

            new Car{
              ID = 0060,
               Model = "Ford Mustang GT",
               Year = 2017,
               Price = 72000
            },

            new Car{
              ID = 0100,
               Model = "GMC Denali HQ",
               Year = 2017,
               Price = 56000
            },
         };
        }

        // GET: Car
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cars()
        {
            var Car = from e in GetCarList()
                            orderby e.ID
                            select e;
            return View(Car);
        }
    }
}