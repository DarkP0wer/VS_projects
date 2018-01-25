using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP_core_tut_1.Models;

namespace ASP_core_tut_1.Controllers
{
    public class HomeController : Controller
    {
        MobileContext db;


        public HomeController(MobileContext context)
        {
            db = context;
        }


        public IActionResult Index()
        {
            return View(db.Phones.ToList());
        }


        [HttpGet]
        public IActionResult Buy(int id)
        {
            ViewBag.PhoneId = id;
            return View();
        }


        [HttpPost]
        public string Buy(Order order)
        {
            db.Oreders.Add(order);
            db.SaveChanges();
            return $"Спасибо {order.User}, за покупку!";
        }
    }
}
