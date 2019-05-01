using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTaskQH6
{
    class Student : Person   
    {
        public string School { get; set; }
        public Student(string firstName, string lastName, string school)
                : base(firstName, lastName)
        {
            School = school;
        }

        public void TakeTest()
        {
            Console.WriteLine($"Student {FirstName} {LastName} should pass the test\n");
        }
        public new void Display()
        {
            Console.WriteLine($"Student: {FirstName} {LastName} belongs to {School}\n");
        }
    }
 }

//Make your Student classe inherit from the Person base class+
//Modify your Student classe so that they inherit the common attributes from Person+
//Modify your Student classe so it includes characteristics specific to it's type.+
//For example, a student might have a TakeTest() method.+
