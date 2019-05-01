using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTaskQH6
{
    class Teacher : Person
    {
        public string Discipline { get; set; }
        public Teacher(string firstName, string lastName, string discipline)
                : base(firstName, lastName)
        {
            Discipline = discipline;
        }

        public void GradeTest()
        {
            Console.WriteLine($"Teacher {FirstName} {LastName} should give the test\n");
        }
        public new void Display()
        {
            Console.WriteLine($"Teacher {FirstName} {LastName} is teaching {Discipline}\n");
        }
    }
}

