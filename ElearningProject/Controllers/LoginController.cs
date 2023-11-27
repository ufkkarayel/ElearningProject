using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ElearningProject.DAL.Context;
using ElearningProject.DAL.Entities;


namespace MyElearningProject.Controllers
{
    public class LoginController : Controller
    {
        ELearningContext context = new ELearningContext();

        
        public ActionResult Index()
        {
            return View();
        }
       
    }
}