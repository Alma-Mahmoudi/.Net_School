using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSchool.Views.Home
{
    public class Course
    {
        public int Id { get; set; }

        public string NameC { get; set; }

        //Association:ManyToMany
        public ICollection<Student> Students { get; set; }
    }
}
