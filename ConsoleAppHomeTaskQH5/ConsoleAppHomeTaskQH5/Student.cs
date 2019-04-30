using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTaskQH5
{
    class Student
    {

        public static int count = 0; 

        public string Name { get; set; }

        public string Address { get; set; }

        
       public Student(string name, string address)
        {
            count++;
            Name = name;
            Address = address; 
        }
                
        public void displayData()
        {
            Console.WriteLine("StudentId: {0}\nName: {1}\nAddress: {2}\n", count, Name, Address);
        }         
    }
}

