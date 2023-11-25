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
    public class InstructorLoginController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: InstructorLogin
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Instructor instructor)
        {
            var values = context.Instructors.FirstOrDefault(x => x.Email == instructor.Email && x.Password == instructor.Password);

            if (values !=null)
            {
                FormsAuthentication.SetAuthCookie(values.Email, false);
                Session["CurrentMail"] = values.Email;
                Session.Timeout = 20;
                return RedirectToAction("Index", "InstructorProfile");
            }
            return View();
        }


    }
}


