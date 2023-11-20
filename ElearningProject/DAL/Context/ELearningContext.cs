using ElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ElearningProject.DAL.Context
{
    public class ELearningContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}