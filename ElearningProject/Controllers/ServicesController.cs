using ElearningProject.DAL.Context;
using ElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElearningProject.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            var values = context.Services.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddServices()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddServices(Services services )
        {
            context.Services.Add(services);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteServices(int id)
        {
           var values= context.Services.Find(id);
            context.Services.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateServices(int id)
        {
            var values = context.Services.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateServices(Services services)
        {
            var values = context.Services.Find(services.ServicesID);
            values.Title = services.Title;
            values.Description = services.Description;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}