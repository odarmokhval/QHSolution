using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTasksQH
{
    class HomeTasksFirst
    {
        static void Main(string[] args)
        {
            //------------task1-----------------//
            Console.WriteLine("plese, enter a number: ");
            string numberString = Console.ReadLine();
            int number = Int32.Parse(numberString);

            if (number % 2 == 0)
            {
                Console.WriteLine("this number is even");
            }

            else
            {
                Console.WriteLine("this number is not even");
            }

            //------------task2-----------------//
            //var1 without loop
            //Console.WriteLine("Please enter a text: ");
            //string text = Console.ReadLine();
            //Console.WriteLine("Text lenght is: " + text.Length);   

            //var2 with loop        
            //int letters = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    letters++;
            //}
            //Console.WriteLine("Text lenght is: " + letters);

            //------------task3-----------------//
            //Console.WriteLine("Enter a coffee type you want to order: ");
            //string cofeeType = Console.ReadLine();

            //switch (cofeeType)
            //{
            //    case "small":
            //        Console.WriteLine("You've ordered small coffee. It's costs 1 usd");
            //        Console.ReadKey();
            //        break;
            //    case "medium":
            //        Console.WriteLine("You've ordered medium coffee. It's costs 2 usd");
            //        Console.ReadKey();
            //        break;
            //    case "big":
            //        Console.WriteLine("You've ordered big coffee. It's costs 3 usd");
            //        Console.ReadKey();
            //        break;
            //    case "extra big":
            //        Console.WriteLine("You've ordered extra big coffee. It's costs 5 usd");
            //        Console.ReadKey();
            //        break;
            //    default:
            //        Console.WriteLine("no coffee you've ordered");
            //        break;
            //}    

            //------------task4-----------------//
            //Console.WriteLine("Please enter a year: ");
            //string yearText = Console.ReadLine();
            //int year = Int32.Parse(yearText);   

            //if (DateTime.IsLeapYear(year) == true)
            //{
            //    Console.WriteLine("This is a leap year");
            //}

            //else
            //{
            //    Console.WriteLine("This is not a leap year");
            //}

            Console.ReadKey();
        }
    }
}
