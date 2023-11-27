using ElearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElearningProject.Controllers
{
    public class InstructorProfileController : Controller
    {
        // GET: InstructorProfile
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
           
            return View();
        }
      
    }
}