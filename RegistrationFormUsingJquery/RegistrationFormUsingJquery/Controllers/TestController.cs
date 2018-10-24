using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationFormUsingJquery.Models;

namespace RegistrationFormUsingJquery.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser(RegistrationViewModel model)
        {
            MvcTutorialEntities db = new Models.MvcTutorialEntities();
            UserSite us = new Models.UserSite();
            us.Address = model.Address;
            us.EmailId = model.EmailId;
            us.Password = model.Password;
            us.RoleId = 3;
            us.UserName = model.UserName;

            db.UserSites.Add(us);
            db.SaveChanges();

            return View();
        }
    }
}