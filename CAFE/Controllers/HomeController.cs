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
using System.Text;
using Newtonsoft.Json;
using System.Threading;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace CAFE.Controllers
{
    public class HomeController : Controller
    {
        cafecontext db;
        IWebHostEnvironment _appEnvironment;

        public HomeController(cafecontext context, IWebHostEnvironment appEnvironment)
        {
            db = context;
            _appEnvironment = appEnvironment;
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
            IEnumerable<ingredient> Ingredients = db.Ingredients;
            ViewBag.menu_items = Menu_items;
            ViewBag.ingredients = Ingredients;
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
        public async Task<IActionResult> Addcustomer(string cus_Sname, string cus_Name, string cus_Pname, string cus_number, string cus_email, string cus_street, string cus_house, string cus_entrance, string cus_apartment, IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                string path = "/images/" + uploadedFile.FileName;
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
                db.Files.Add(file);
                db.SaveChanges();
            }
            db.Customers.Add(new customer { cus_Sname = cus_Sname, cus_Name = cus_Name, cus_Pname = cus_Pname, cus_number = cus_number, cus_email = cus_email, cus_street = cus_street, cus_house = cus_house, cus_entrance = cus_entrance, cus_apartment = cus_apartment });
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
        public IActionResult Reservation(string cus_Sname, string cus_Name, string cus_Pname, string cus_number, string cus_email, string cus_street, string cus_house, string cus_entrance, string cus_apartment, int table_number, DateTime table_order_time)
        {
            db.Customers.Add(new customer { cus_Sname = cus_Sname, cus_Name = cus_Name, cus_Pname = cus_Pname, cus_number = cus_number, cus_email = cus_email, cus_street = cus_street, cus_house = cus_house, cus_entrance = cus_entrance, cus_apartment = cus_apartment });
            db.SaveChanges();
            int lastCustomerId = db.Customers.Max(item => item.customerId);
            db.Tables.Add(new table { table_number = table_number, table_order_time = table_order_time, customerId = lastCustomerId });
            db.SaveChanges();
            return RedirectPermanent("/endreservation");
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
        [HttpGet]
        public IActionResult orders()
        {
            IEnumerable<courier> Couriers = db.Couriers;
            ViewBag.couriers = Couriers;
            IEnumerable<menu_item> Menu_items = db.Menu_Items;
            IEnumerable<order> Orders = db.Orders;
            IEnumerable<mo> Mos = db.Mos;
            IEnumerable<customer> customers = db.Customers;
            ViewBag.menu_items = Menu_items;
            ViewBag.Customers = customers;
            ViewBag.Mos = Mos;
            ViewBag.Orders = Orders;
            return View();
        }
        [Route("/orders")]
        [HttpPost]
        public async Task<IActionResult> orders(order model)
        {
            IEnumerable<courier> Couriers = db.Couriers;
            ViewBag.couriers = Couriers;
            IEnumerable<menu_item> Menu_items = db.Menu_Items;
            IEnumerable<order> Orders = db.Orders;
            IEnumerable<mo> Mos = db.Mos;
            IEnumerable<customer> customers = db.Customers;
            ViewBag.menu_items = Menu_items;
            ViewBag.Customers = customers;
            ViewBag.Mos = Mos;
            ViewBag.Orders = Orders;
            foreach (var value in ViewBag.couriers)
            {
                if (value.c_login == User.Identity.Name)
                {
                    order order = await db.Orders.FirstOrDefaultAsync(value => value.orderId == model.orderId);
                    order.courierId = value.courierId;
                    db.Orders.Update(order);
                }
            }
            await db.SaveChangesAsync();
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
                    ModelState.AddModelError("", "Ошибка");
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("home", "Home");
        }
        [Route("/Alogin")]
        [HttpGet]
        public IActionResult Alogin()
        {
            return View();
        }
        [Route("/Alogin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Alogin(admin model)
        {
            if (ModelState.IsValid)
            {
                admin admin = await db.Admins.FirstOrDefaultAsync(u => u.login == model.login && u.password == model.password);
                if (admin != null)
                {
                    await Authenticate(model.login); // аутентификация

                    return RedirectToAction("Admin", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
        [Route("/Admin")]
        [HttpGet]
        public IActionResult Admin()
        {
            return View();
        }
        [Route("/Admin")]
        [HttpPost]
        public IActionResult Admin(int menu_item_price, string desc, string weight, string menu_item_name, int mealtimeId)
        {
            db.Menu_Items.Add(new menu_item { menu_item_price = menu_item_price, desc = desc, weight = weight, menu_item_name = menu_item_name, mealtimeId = mealtimeId});
            db.SaveChanges();
            return View();
        }
        [Route("/cart")]
        [HttpPost]
        public ActionResult Cart()
        {
            var bodyStr = "";
            var req = Request;
            using (StreamReader reader
                  = new StreamReader(req.Body, Encoding.UTF8, true, 1024, true))
            {
                bodyStr = reader.ReadToEndAsync().Result;
            }
            var json = JsonConvert.DeserializeObject<Root>(bodyStr);
            Thread.Sleep(500);
            var totalPrice = 0;
            int lastCustomerId = db.Customers.Max(item => item.customerId);
            foreach (var value in json.Dat)
            {
                totalPrice += value.Price * value.Quantity;
            }
            db.Orders.Add(new order { order_time = DateTime.Now, price = totalPrice, customerId = lastCustomerId });
            db.SaveChanges();
            int lastOrderId = db.Orders.Max(item => item.orderId);
            foreach (var value in json.Dat)
            {
                db.Mos.Add(new mo { orderId = lastOrderId, menu_itemId = value.Id, order_items_quantity = value.Quantity });
            }
            db.SaveChanges();
            return RedirectToAction("/");
        }
    }
}