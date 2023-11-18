using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElearningProject.DAL.Entities
{
    public class Carousel
    {
        public int CarouselID { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
}