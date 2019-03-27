using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTaskQH2
{
    class Program
    {
        static void Main(string[] args)
        {

            //---task5 var1 pre defined data---
            //int[] array = new int[] { 10, 20, 30, 40 };
            //int total = 0;

            //for (int i = 0; i < array.GetLength(0); i++)
            //{

            //    total += array[i];
            //}
            //Console.WriteLine("Total sum: " + total);

            //---task5 var2 randomizer--- 
            //int total = 0;
            //int Min = 1;
            //int Max = 20;

            //int[] randomArray = new int[5];
            //Random randNum = new Random();
            //for (int i = 0; i < randomArray.Length; i++)
            //{
            //    randomArray[i] = randNum.Next(Min, Max);
            //    total += randomArray[i];
            //    Console.WriteLine(randomArray[i]);
            //}

            //Console.WriteLine("Total sum: " + total);

            //---task5 var3 randomizer using LINQ---
            //int total = 0;
            //int Min = 0;
            //int Max = 20;
            //Random randNum = new Random();
            //int[] randomArray = Enumerable
            //    .Repeat(0, 5)
            //    .Select(i => randNum.Next(Min, Max))
            //    .ToArray();

            //for (int i = 0; i < randomArray.Length; i++)
            //{
            //      total += randomArray[i];
            //      Console.WriteLine(randomArray[i]);
            //}

            //---task6 Enter digit and count arithmetic progression--- 
            Console.WriteLine("Please, enter max integer value of arithmetic progression: ");
            string amountString = Console.ReadLine();
            int amount = Int32.Parse(amountString);

            Console.WriteLine("Please, enter first number of arithmetic progression: ");
            string firstNumberString = Console.ReadLine();
            int firstNumber = Int32.Parse(firstNumberString);

            Console.WriteLine("Please, enter common ratio of arithmetic progression: ");
            string commonRatioString = Console.ReadLine();
            int commonRatio = Int32.Parse(commonRatioString);

            int[] geomSeries = new int[amount];

            geomSeries[0] = firstNumber;
            for (int i = 1; i < amount; i++)
            {
                geomSeries[i] = geomSeries[i - 1] * commonRatio;
                Console.WriteLine(geomSeries[i]);
            }       

            //---task7 Create array and find and print max value ( using loop) in this array

            //int[] myArray = new int[] { 55, 55, 55, 55, 55, 1024, 19, 0, -5, 74, 5, 362, 1024 };
            //var maxValue = 0;
            //var maxValueCount = 0;

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxValue)
            //    {
            //        maxValue = myArray[i];
            //        maxValueCount = 1;
            //        continue;
            //    }

            //    if (myArray[i] == maxValue)
            //    {
            //        maxValueCount = maxValueCount + 1;
            //    }
            //}

            //Console.WriteLine("The max value is " + maxValue + " which appeared " + maxValueCount + " times."); 
            Console.ReadKey();   
        }
    }
}
