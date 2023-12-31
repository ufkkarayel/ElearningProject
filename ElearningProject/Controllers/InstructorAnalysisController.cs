﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElearningProject.DAL.Context;

namespace ElearningProject.Controllers
{
    public class InstructorAnalysisController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: InstructorAnalysis
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult InstructorPanelPartial()
        {
            int id = 1;
            var values = context.Instructors.Where(x => x.InstructorID == id).ToList(); 
            var v1 = context.Instructors.Where(x => x.Name == "Fatih" && x.Surname == "Çakıroğlu").Select(y => y.InstructorID).FirstOrDefault();
            var v2 = context.Courses.Where(x => x.InstructorID == v1).Select(y => y.CourseID).ToList();
            ViewBag.courseCount = context.Courses.Where(x => x.InstructorID == 1).Count();
            ViewBag.commentCount = context.Comments.Where(x => v2.Contains(x.CourseID)).Count();
            
            return PartialView(values);
        }
        public PartialViewResult CommentPartial()
        {
            //eğitmen ID getirmek için
            var v1 = context.Instructors.Where(x => x.Name == "Fatih" && x.Surname == "Çakıroğlu").Select(y => y.InstructorID).FirstOrDefault();
            var v2 = context.Courses.Where(x => x.InstructorID == v1).Select(y => y.CourseID).ToList();
            var v3 = context.Comments.Where(x => v2.Contains(x.CourseID)).ToList();
                      
            return PartialView(v3);
        }
        public PartialViewResult CourseListByInstructor()
        {
            var values = context.Courses.Where(x => x.InstructorID == 1).ToList();
            return PartialView(values);
        }
    }
}