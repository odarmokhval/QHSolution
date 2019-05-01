using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTaskQH6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Bob", "Thornton", "School #35, Lviv");
            student1.Display();
            student1.TakeTest();

            Student student2 = new Student("Olga", "Darmokhval", "School #35, Lviv");
            student1.Display();
            student1.TakeTest();

            Teacher teacher1 = new Teacher("Oleg", "Zarevych", "C#");
            
            teacher1.Display();
            Course course1 = new Course("C#");
            course1.students = new List<Student>();
            course1.students.Add(student1);
            course1.students.Add(student2);


            Console.WriteLine($"Course name is {course1.CourseName} and teacher of course is {teacher1.FirstName} {teacher1.LastName} and students are: {student1.FirstName} {student1.LastName} and { student2.FirstName} {student2.LastName}");
            Console.ReadKey();
        }
    }
}
