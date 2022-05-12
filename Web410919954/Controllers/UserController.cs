using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410919954.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View();
        }

        [ HttpPost ]
        public ActionResult SignUp(string name, string account , string pd)
        {
            if (name.IsNullOrWhiteSpace()) 
            {
                ViewBag.NameMessage = "請輸入名字";
            }

            if (account.IsNullOrWhiteSpace())
            {
                ViewBag.AcMessage = "請輸入帳號";
            }

            if (pd.IsNullOrWhiteSpace())
            {
                ViewBag.PdMessage = "請輸入密碼";
            }

            if ( ! name.IsNullOrWhiteSpace()  && ! account.IsNullOrWhiteSpace()  &&  ! pd.IsNullOrWhiteSpace())
            {
                ViewBag.Message = "註冊成功！";
            }

            return View();

        }
    }
}