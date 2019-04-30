using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTaskQH5
{
    class Teacher
    {
        public string FullName { get; set; }
        public string Specialization { get; set; }

        public Teacher(string fullname, string specialization) {
            FullName = fullname;
            Specialization = specialization;
        }

        public void displayData() {
            Console.WriteLine("Teacher full name: {0}\nSpecialization: {1}\n", FullName, Specialization);
        }
    }
}
