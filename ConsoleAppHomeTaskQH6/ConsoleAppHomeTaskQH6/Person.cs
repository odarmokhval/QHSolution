using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTaskQH6
{
    abstract class Person {
        //Create a Person base class with common attributes for a person.Remember to use encapsulation for these attributes.+
        //Applying proper OOP principles, make Person an abstract class+

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
