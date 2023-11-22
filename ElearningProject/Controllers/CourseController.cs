using ElearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElearningProject.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            var values = context.Courses.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateCourse()
        {
            List<SelectListItem> categories = (from x in context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()

                                               }).ToList();
            ViewBag.v = categories;

            List<SelectListItem> instructors = (from y in context.Instructors.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = y.Name + " " + y.Surname,
                                                    Value = y.InstructorID.ToString()
                                                }).ToList();
            ViewBag.v2 = instructors;

            return View();
        }
    }
}