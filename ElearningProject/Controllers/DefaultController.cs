using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElearningProject.Controllers
{
    public class DefaultController : Controller
    {
        ElearningContext context = new ElearningContext();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialSpinner()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialCarousel()
        {
            return PartialView();
        }
        public PartialViewResult PartialServices()
        {
            return PartialView();
        }
    }
}