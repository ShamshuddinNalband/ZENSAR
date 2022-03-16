using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace codefirstapproach.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=Students")
        {

        }

        public DbSet<Student> students { get; set; }
    }
}