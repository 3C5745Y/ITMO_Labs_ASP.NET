using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyWebApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MyWebApp.DAL
{
    public class InternshipsContext: DbContext
    {
        public InternshipsContext() : base("InternshipsContext")
        {
        }

        public DbSet<Intern> Interns { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}