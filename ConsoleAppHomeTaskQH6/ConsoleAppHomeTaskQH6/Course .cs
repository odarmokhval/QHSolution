using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTaskQH6
{
    class Course
    {
        public List<Student> students = new List<Student>();
        public Teacher Teacher { get; set; }
        public string CourseName { get; set; }

        public Course(string courseName)
        {
            this.CourseName = courseName;
        }

        public void Display() {
            Console.WriteLine($"Course name is { CourseName } and teacher of course is {Teacher}");
        }
    }
}

