using EF_Core.Entities;
using Microsoft.EntityFrameworkCore;
using EF_Core.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Contexts
{
    internal class ItiContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = ItiDb ; Trusted_Connection = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfigurations());
            modelBuilder.ApplyConfiguration(new InstructorConfigurations());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            









            modelBuilder.Entity<CourseInst>().HasKey(CI => new { CI.CourseId, CI.InstId });

            modelBuilder.Entity<StudCourse>().HasKey(SC => new { SC.CourseId, SC.studId });


          

           











            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Student> student { get; set; }
        public DbSet<Topic> topic { get; set; }
        public DbSet<StudCourse> studCourse { get; set; }
        public DbSet<Instructor> instructor { get; set; }
        public DbSet<Department> department { get; set; }
        public DbSet<CourseInst> courseInst { get; set; }
        public DbSet<Course> course { get; set; }




    }
}
