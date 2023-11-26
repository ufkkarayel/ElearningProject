using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElearningProject.DAL.Context;
using ElearningProject.DAL.Entities;

namespace ElearningProject.Controllers
{
    public class ProfileLayoutController : Controller
    {
        // GET: ProfileLayout
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialContent()
        {
            var value = context.Instructors.ToList();
            return PartialView(value);
        }
    }
}