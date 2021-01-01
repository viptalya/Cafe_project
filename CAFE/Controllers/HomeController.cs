using CAFE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CAFE.Controllers
{
    public class HomeController : Controller
    {
        cafecontext db;
        public HomeController(cafecontext context)
        {
            db = context;
        }
        [Route("/")]
        public IActionResult Home()
        {
            return View();
        }
        [Route("/menu")]
        public IActionResult Menu()
        {
            IEnumerable<mealtime> Mealtimes = db.Mealtimes;
            ViewBag.mealtimes = Mealtimes;
            return View();
        }
        [Route("/menu/Завтраки")]
        public IActionResult Breakfast()
        {
            return View();
        }
        [Route("/addcustomer")]
        [HttpGet]
        public IActionResult Addcustomer()
        {
            return View();
        }
        [Route("/addcustomer")]
        [HttpPost]
        public IActionResult Addcustomer(string cus_Sname, string cus_Name, string cus_Pname, string cus_number, string cus_email)
        {
            db.Customers.Add(new customer { cus_Sname = cus_Sname, cus_Name = cus_Name, cus_Pname = cus_Pname, cus_number = cus_number, cus_email = cus_email });
            db.SaveChanges();
            return RedirectPermanent("/");
        }
        [Route("/Reservation")]
        [HttpGet]
        public IActionResult Reservation()
        {
            return View();
        }
        [Route("/Reservation")]
        [HttpPost]
        public IActionResult Reservation(int table_number, DateTime table_order_time)
        {
            db.Tables.Add(new table { table_number = table_number, table_order_time = table_order_time });
            db.SaveChanges();
            return RedirectPermanent("/");
        }
        [Route("/Endreservation")]
        public IActionResult Endreservation()
        {
            return View();
        }
    }
}