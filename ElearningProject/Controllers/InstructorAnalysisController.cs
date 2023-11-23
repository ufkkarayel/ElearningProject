using System;
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
            var values = context.Instructors.Where(x => x.InstructorID == id).ToList(); ;
            return PartialView(values);
        }
        public PartialViewResult CommentPartial()
        {
            var values = context.Comments.ToList();
            return PartialView(values);
        }
    }
}