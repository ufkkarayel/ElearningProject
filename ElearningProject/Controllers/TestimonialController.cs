using ElearningProject.DAL.Context;
using ElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElearningProject.Controllers
{
    public class TestimonialController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: Testimonial
        public ActionResult Index()
        {
            var value = context.Testimonials.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = context.Testimonials.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var values = context.Testimonials.Find(testimonial.TestimonialID);
            values.NameSurname = testimonial.NameSurname;
            values.Title = testimonial.Title;
            values.ImageUrl = testimonial.ImageUrl;
            values.Status = testimonial.Status;
            values.Comment = testimonial.Comment;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
     
    }
}