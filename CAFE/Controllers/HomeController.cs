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
            IEnumerable<menu_item> Menu_items = db.Menu_Items;
            ViewBag.menu_items = Menu_items;
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
        public IActionResult Addcustomer(string cus_Sname, string cus_Name, string cus_Pname, string cus_number, string cus_email, string cus_street, string cus_house, string cus_entrance, string cus_apartment)
        {
            db.Customers.Add(new customer { cus_Sname = cus_Sname, cus_Name = cus_Name, cus_Pname = cus_Pname, cus_number = cus_number, cus_email = cus_email, cus_street = cus_street, cus_house = cus_house, cus_entrance = cus_entrance, cus_apartment = cus_apartment});
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
            return RedirectPermanent("/Endreservation");
        }
        [Route("/Endreservation")]
        public IActionResult Endreservation()
        {
            return View();
        }
        [Route("/menu/Мясные блюда")]
        public IActionResult Meat()
        {
            IEnumerable<menu_item> Menu_items = db.Menu_Items;
            ViewBag.menu_items = Menu_items;
            return View();
        }
        [Route("/menu/Блюда из рыбы")]
        public IActionResult Fish()
        {
            IEnumerable<menu_item> Menu_items = db.Menu_Items;
            ViewBag.menu_items = Menu_items;
            return View();
        }
        [Route("/menu/Десерты")]
        public IActionResult Deserts()
        {
            IEnumerable<menu_item> Menu_items = db.Menu_Items;
            ViewBag.menu_items = Menu_items;
            return View();
        }
        [Route("/menu/Салаты")]
        public IActionResult Salads()
        {
            IEnumerable<menu_item> Menu_items = db.Menu_Items;
            ViewBag.menu_items = Menu_items;
            return View();
        }
        [Route("/menu/Напитки")]
        public IActionResult Drinks()
        {
            IEnumerable<menu_item> Menu_items = db.Menu_Items;
            ViewBag.menu_items = Menu_items;
            return View();
        }
        [Route("/Addcourier")]
        [HttpGet]
        public IActionResult Addcourier()
        {
            return View();
        }
        [Route("/Addcourier")]
        [HttpPost]
        public IActionResult Addcourier(string c_Sname, string c_name, string c_Pname, string c_phone, string c_email, string c_login, string c_password)
        {
            db.Couriers.Add(new courier { c_Sname = c_Sname, c_name = c_name, c_Pname = c_Pname, c_phone = c_phone, c_email = c_email, c_login = c_login, c_password = c_password });
            db.SaveChanges();
            return RedirectPermanent("/");
        }

    }
}