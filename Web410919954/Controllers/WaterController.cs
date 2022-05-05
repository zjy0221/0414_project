using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410919954.Controllers
{
    public class WaterController : Controller
    {
        // GET: Water
        public ActionResult Index(String name, float? 體重)
        {
            string sum = "";

            if (體重.HasValue)
            {
                sum = (體重 * 30) + "cc";

            }

            ViewBag.Name = name;
            ViewBag.Sum = sum;

            return View();
        }
    }
}