using ElearningProject.DAL.Context;
using ElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElearningProject.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            var values = context.Students.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }
        public ActionResult AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}