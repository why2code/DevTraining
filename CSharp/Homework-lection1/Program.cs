using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lection1
{
    class PrintNumbers
    {
        static void Main()
        {

            //Writing numbers and my name on separate lines (function \n)
            Console.WriteLine("1\n100\n1001");
            Console.WriteLine("Haralampi\nStoyanov");

            //Calculating Square of a number provided by user input
            int x;
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(x));

            /*Problem 9. Print a Sequence
            Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ... */

            //  NE RESHENO USLOVIE 9!

            /* Problem 10. Reformat C# Code

            Reformat the following C# code to make it readable according to the C# best practices for code formatting. 
            Change the casing of the identifiers in the code (e.g. use PascalCase for the class name): HorribleCode.cs */

             Console.WriteLine("Hi, I am horribly formatted program");
             Console.WriteLine("Numbers and squares:");
             for (int i = 0; i < 10; i++)
             {
                  Console.WriteLine(i + " --> " + i * i);
              }


            //Problem 14*. Printing current date and time

            Console.WriteLine(DateTime.Now);

            /*roblem 15.* Age after 10 Years
            Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.*/

            Console.Write("Enter your birth date: ");
            DateTime BirthDay = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int age = (int)((now - BirthDay).TotalDays / 365.242199);
            Console.WriteLine("You are " + age + " year(s) old.");
            Console.WriteLine("After ten years, you will be at the age of " + (age + 10));

            


        }
}
}
