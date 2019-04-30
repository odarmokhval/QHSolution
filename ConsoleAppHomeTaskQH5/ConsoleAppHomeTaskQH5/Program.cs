using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTaskQH5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Sara", "USA");
            student1.displayData();

            Student student2 = new Student("Miho", "Mexico");
            student2.displayData();

            Student student3 = new Student("Alise", "France");
            student3.displayData();

            Course course1 = new Course("Programming with C#");
            course1.Students = new List<Student>();
            course1.Students.Add(student1);
            course1.Students.Add(student2);
            course1.Students.Add(student3);

            int count = Student.count;

            Teacher teacher1 = new Teacher("Oleg Zarevych", "C#");
            teacher1.displayData();

            Degree degree1 = new Degree("Bachelor");
            degree1.Courses = new List<Course>();
            degree1.Courses.Add(course1);

            UProgramm informationTechnology = new UProgramm("Information Technology");
            informationTechnology.Degrees = new List<Degree>();
            informationTechnology.Degrees.Add(degree1);

            //Using Console.WriteLine statements, output the following information to the console window:
            //The name of the program and the degree it contains ++
            //The name of the course in the degree ++
            //The count of the number of students in the course.   

            Console.WriteLine("Name of the program: {0}\nit contains degree: {1}\nname of the course in the degree: {2}\ncount of students in the course: {3}", informationTechnology.Name, degree1.Name, course1.Name, count);


            Console.ReadKey();
        }
    }
}
