﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Final_Challenge_3
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
