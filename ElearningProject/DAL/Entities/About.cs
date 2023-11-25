using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElearningProject.DAL.Entities
{
    public class About
    {
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Contect2 { get; set; }
        public bool Status { get; set; }
    }
}