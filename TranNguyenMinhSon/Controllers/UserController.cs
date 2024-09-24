using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TranNguyenMinhSon.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Welcome()
        {
            return View();
        }
        public ActionResult Welcome2()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}