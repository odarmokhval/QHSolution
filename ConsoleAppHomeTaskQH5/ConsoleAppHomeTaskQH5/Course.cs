using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTaskQH5
{
    class Course
    {
        public string Name { get; set; }

        public Teacher Teacher { get; set; }

        public List<Student> Students { get; set; }

        public Course(string name) {
            Name = name;
        }
    }
}
