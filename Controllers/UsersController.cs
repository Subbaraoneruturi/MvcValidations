using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcValidations.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Register()
        {
            return View();
        }
    }
}