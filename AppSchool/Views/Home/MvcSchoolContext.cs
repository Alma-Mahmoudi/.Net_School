using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSchool.Views.Home
{
    public class MvcSchoolContext : DbContext
    {
        public MvcSchoolContext(DbContextOptions<MvcSchoolContext> options)
            :base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        
        public DbSet<Course> Courses { get; set; }
    }
}
