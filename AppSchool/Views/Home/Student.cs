using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSchool.Views.Home
{
    public class Student
    {
        public int Id { get; set; }
        
        public string NameS { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
