using ElearningProject.DAL.Context;
using ElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ElearningProject.Controllers
{
    public class AdminLoginController : Controller
    {
        ELearningContext context = new ELearningContext();
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var values = context.Instructors.FirstOrDefault(x => x.Email == admin.Email && x.Password == admin.Password);

            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Email, false);
                Session["CurrentMail"] = values.Email;
                Session.Timeout = 20;
                return RedirectToAction("Index", "AdminProfile");
            }
            return View();
        }
    }
}