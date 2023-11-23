﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElearningProject.DAL.Entities
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentTime { get; set; }
        public bool CommentStatus { get; set; }
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
    }
}