using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;  // This is to avoid regional settings problem!
using System.Globalization;  // This is to avoid regional settings problem!



namespace ConsoleInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {

            //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; // This is to avoid regional settings problem!
            //string a = (Console.ReadLine());
            //a = a.Replace('.', ',');
            //string b = (Console.ReadLine());
            //b = a.Replace('.', ',');
            //double Anum = double.Parse(a);
            //double Bnum = double.Parse(b);
            //Console.WriteLine(Anum / Bnum);

            /* Problem 1. Sum of 3 Numbers
            Write a program that reads 3 real numbers from the console and prints their sum. */

            //Console.WriteLine("Please enter a sequence of 3 numbers.");
            //Console.WriteLine("Your choice for value of number A is:");
            //double numA = double.Parse(Console.ReadLine());
            //Console.WriteLine("Your choice for value of number B is:");
            //double numB = double.Parse(Console.ReadLine());
            //Console.WriteLine("Your choice for value of number C is:");
            //double numC = double.Parse(Console.ReadLine());
            //Console.Write("The sum of the 3 numbers is: ");
            //Console.WriteLine(numA + numB + numC);


            /* Problem 2. Print Company Information
            A company has name, address, phone number, fax number, web site and manager. The manager has first name, 
            last name, age and a phone number. Write a program that reads the information about a company and its manager
            and prints it back on the console. */

            //Console.WriteLine("Please enter the following company details, as prompted.");
            //Console.WriteLine("Please enter the company name:");
            //string comName = Console.ReadLine();
            //Console.WriteLine("Please enter the company address:");
            //string comAddress= Console.ReadLine();
            //Console.WriteLine("Please enter the company phone number:");
            //string comPhone = Console.ReadLine();
            //Console.WriteLine("Please enter the company fax:");
            //string comFax = Console.ReadLine();
            //Console.WriteLine("Please enter the company web site:");
            //string comWeb = Console.ReadLine();
            //Console.WriteLine("Please enter the company manager`s first name:");
            //string comManagerFN = Console.ReadLine();
            //Console.WriteLine("Please enter the company manager`s last name:");
            //string comManagerLN= Console.ReadLine();
            //Console.WriteLine("Please enter the company manager`s age:");
            //string comManagerAge = Console.ReadLine();
            //Console.WriteLine("Please enter the company manager`s phone:");
            //string comManagerPhone = Console.ReadLine();
            //string line = "\n";
            //
            //Console.WriteLine("The company details are: " + line + "Company name:" + comName + line + "Company address:" + comAddress + 
            //    line + "Company phone: " + comPhone + line + "Company fax:" + comFax + line + "Company web site:" + comWeb + 
            //    line + "Company Manager:" + comManagerFN + ", " + comManagerLN + ", " + comManagerAge + ", " + comManagerPhone);



            /* A=πr2
               C=2πr
            Problem 3. Circle Perimeter and Area
            Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits
            after the decimal point.*/

            //double area, perimeter;
            //double p = 3.14159;
            //Console.WriteLine("Please enter the circle radius r:");
            //double radius = double.Parse(Console.ReadLine());
            //area = p * (radius * radius);
            //perimeter = 2 * p * radius;
            //Console.WriteLine("The circle`s area is {0:F2} and the perimeter is {1:F2}.", area, perimeter);



            /* Problem 4. Number Comparer
            Write a program that gets two numbers from the console and prints the greater of them.
            Try to implement this without if statements. */

            //double a, b;
            //a = double.Parse(Console.ReadLine());
            //b = double.Parse(Console.ReadLine());
            //if (a > b)
            //{
            //    Console.WriteLine("The bigger number is: {0}", a);
            //}
            //else
            //{
            //    Console.WriteLine("The bigger number is: {0}", b);
            //}


            /* Problem 5. Formatting Numbers

            Write a program that reads 3 numbers:
            integer a (0 <= a <= 500)
            floating-point b
            floating-point c
            The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
            The number a should be printed in hexadecimal, left aligned
            Then the number a should be printed in binary form, padded with zeroes
            The number b should be printed with 2 digits after the decimal point, right aligned
            The number c should be printed with 3 digits after the decimal point, left aligned. */

            //int a;
            //float b, c;
            //Console.WriteLine("Please enter a rounded number A vuth values between 0 and 500.");
            //bool checkA = int.TryParse(Console.ReadLine(), out a);
            //Console.WriteLine("Please enter number B");
            //bool checkB = float.TryParse(Console.ReadLine(), out b);
            //Console.WriteLine("Please enter number C");
            //bool checkC = float.TryParse(Console.ReadLine(), out c);
            //
            //if ((checkA && checkB && checkC) & (a <= 500 & a >= 0)) //Check if we have 3 numbers entered and a (0 <= a <= 500)
            //{
            //    string AtoHex = a.ToString("X");
            //    string AtoBin = Convert.ToString(a, 2).PadLeft(10, '0');
            //    
            //    Console.WriteLine("{0,-10} | {1} | {2,10:F2} | {3,-10:F3} |", AtoHex, AtoBin, b, c);
            //    Console.WriteLine("{0,-10} | {1} | {2,10:F2} | {3,-10:F3} |", AtoHex, AtoBin, b, c);
            //    
            //}
            //else
            //{
            //    Console.WriteLine("Invalid entry, please re-enter your number according to instructions.");
            //    Console.WriteLine("Number A should be a whole number (0 <= a <= 500).");
            //}




            /* Problem 6. Quadratic Equation
            Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and 
            solves it (prints its real roots). */

            //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //double a, b, c, discriminant, x1, x2;
            //Console.Write("Enter the first coefficient a:");
            //bool isaDouble = double.TryParse(Console.ReadLine(), out a);
            //Console.Write("Enter the second coefficients b:");
            //bool isbDouble = double.TryParse(Console.ReadLine(), out b);
            //Console.Write("Enter the third coefficients c:");
            //bool iscDouble = double.TryParse(Console.ReadLine(), out c);
            //if (isaDouble & isbDouble & iscDouble)
            //{
            //    discriminant = (b * b) - (4 * a * c);
            //    if (discriminant > 0)
            //    {
            //        x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            //        x2 = (b + Math.Sqrt(discriminant)) / 2 * a;
            //        Console.WriteLine("The real roots are:");
            //        Console.WriteLine("x1={0}", x1);
            //        Console.WriteLine("x2={0}", x2);
            //    }
            //    else if (discriminant == 0)
            //    {
            //        x1 = x2 = -b / 2 * a;
            //        Console.WriteLine("The real roots are:");
            //        Console.WriteLine("x1={0}", x1);
            //        Console.WriteLine("x2={0}", x2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("There are no real roots!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Not a valid entry! Some of the numbers are not double!");
            //}


            /* Problem 7. Sum of 5 Numbers
            Write a program that enters 5 numbers (given in a single line, separated by a space), calculates
            and prints their sum. */

            //Console.WriteLine("Please enter a sequence of 5 numbers separated by space.");
            //string[] userINput = Console.ReadLine().Split();
            //int a = Convert.ToInt32(userINput[0]);
            //int b = Convert.ToInt32(userINput[1]);
            //int c = Convert.ToInt32(userINput[2]);
            //int d = Convert.ToInt32(userINput[3]);
            //int e = Convert.ToInt32(userINput[4]);
            //int sumOfAll = a + b + c + d + e;
            //Console.WriteLine(sumOfAll);

            /* Problem 8. Numbers from 1 to n
            Write a program that reads an integer number n from the console and prints all the numbers in the 
            interval [1..n], each on a single line. Note: You may need to use a for-loop. */

            //Console.WriteLine("Please enter a number.");
            //int num;
            //bool checkNum = int.TryParse(Console.ReadLine(), out num);
            //
            //if (checkNum)
            //{
            //    for (int i = 1; i <= num; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            /* Problem 10. Fibonacci Numbers
            Write a program that reads a number n and prints on the console the first n members of the Fibonacci
            sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
            Note: You may need to learn how to use loops.. */

            //Console.Write("Number: ");
            //int n = int.Parse(Console.ReadLine());
            //int a = 0;
            //int b = 1;
            //int c;
            //
            //if (n >= 3)
            //{
            //    Console.Write(a + ", " + b + ", ");
            //    for (int i = 2; i < n; i++)
            //    {
            //        c = a;
            //        a = b;
            //        b = c + a;
            //        Console.Write(b + ", ");
            //    }
            //    
            //}
            //else if (n == 2)
            //{
            //    Console.WriteLine(a + ", " + b);
            //}
            //else if (n == 1)
            //{
            //    Console.WriteLine(a);
            //}


            /* Problem 11.* Numbers in Interval Dividable by Given Number
            Write a program that reads two positive integer numbers and prints how many numbers p exist between 
            them such that the reminder of the division by 5 is 0. 
            Examples:
            start	end	    p	    comments
            17	    25	    2	    20, 25
            5	    30	    6	    5, 10, 15, 20, 25, 30 */

           





        }
    }
}
