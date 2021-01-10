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
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

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
        [Route("/orders")]
        public IActionResult orders()
        {
            return View();
        }
        [Route("/Logincourier")]
        [HttpGet]
        public IActionResult Logincourier()
        {
            return View();
        }
        [Route("/Logincourier")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logincourier(courier model)
        {
            if (ModelState.IsValid)
            {
                courier courier = await db.Couriers.FirstOrDefaultAsync(u => u.c_login == model.c_login && u.c_password == model.c_password);
                if (courier != null)
                {
                    await Authenticate(model.c_login); // аутентификация

                    return RedirectToAction("orders", "Home");
                }
                else 
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
        [Route("/Addcourier")]
        [HttpGet]
        public IActionResult Addcourier()
        {
            return View();
        }
        [Route("/Addcourier")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Addcourier(courier model)
        {
            if (ModelState.IsValid)
            {
                courier courier = await db.Couriers.FirstOrDefaultAsync(u => u.c_login == model.c_login);
                if (courier == null)
                {
                    // добавляем пользователя в бд
                    db.Couriers.Add(new courier
                    {
                        c_Sname = model.c_Sname,
                        c_name = model.c_name,
                        c_Pname = model.c_Pname,
                        c_phone = model.c_phone,
                        c_email = model.c_email,
                        c_login = model.c_login,
                        c_password = model.c_password
                    });
                    await db.SaveChangesAsync();

                    await Authenticate(model.c_login); // аутентификация

                    return RedirectToAction("orders", "Home");
                }
                else
                    ModelState.AddModelError("","Ошибка");
            }
            return View(model);
        }

        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        [Route("/orders")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("home", "Home");
        }
    }
}