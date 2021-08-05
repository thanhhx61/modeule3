using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DBContexts
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Classs> Classses { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Classs>().HasData(
                  new
                  {
                      ClasssId = 1,
                      ClasssName = "A1",
                      IsDeleted = false
                  },
                  new
                  {
                      ClasssId = 2,
                      ClasssName = "A2",
                      IsDeleted = false
                  },
                  new
                  {
                      ClasssId = 3,
                      ClasssName = "A3",
                      IsDeleted = false
                  },
                  new
                  {
                      ClasssId = 4,
                      ClasssName = "A4",
                      IsDeleted = false
                  },
                   new
                   {
                       ClasssId = 5,
                       ClasssName = "A5",
                       IsDeleted = false
                   }
              );
            modelBuilder.Entity<Student>().HasData(
                 new
                 {
                     ClasssId = 1,
                     ClasssName = "A1",
                     IsDeleted = false
                 },
                 new
                 {
                     ClasssId = 2,
                     ClasssName = "A2",
                     IsDeleted = false
                 },
                 new
                 {
                     ClasssId = 3,
                     ClasssName = "A3",
                     IsDeleted = false
                 },
                 new
                 {
                     ClasssId = 4,
                     ClasssName = "A4",
                     IsDeleted = false
                 },
                  new
                  {
                      ClasssId = 5,
                      ClasssName = "A5",
                      IsDeleted = false
                  }
             );

        }
    }
}
