﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElearningProject.DAL.Entities
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}