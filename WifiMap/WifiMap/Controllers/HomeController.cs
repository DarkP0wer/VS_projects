using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WifiMap.Models;

namespace WifiMap.Controllers
{
    public class HomeController : Controller
    {
        DataBaseContext db;


        public HomeController(DataBaseContext context)
        {
            db = context;
        }


        public IActionResult Index()
        {
            return View(db.Wifies.ToList());
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public JsonResult GetData()
        {
            return Json(db.Wifies.ToList());
        }
    }
}
