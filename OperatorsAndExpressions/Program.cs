using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            /*   Problem 1.Odd or Even Integers
            Write an expression that checks if given integer is odd or even. */

            //  int checkNumb = (2 % 2);
            //  bool oddOrEven = (checkNumb != 0);
            //  Console.Write(oddOrEven);

            /* Problem 2. Gravitation on the Moon
            The gravitational field of the Moon is approximately 17% of that on the Earth.
            Write a program that calculates the weight of a man on the moon by a given weight on the Earth. */

            //  float earthWeight = float.Parse(Console.ReadLine());
            //  float moonWeight = earthWeight * 0.17f;
            //  Console.WriteLine(moonWeight);

            /* Problem 3. Divide by 7 and 5
            Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
            3   false
            7   false
            35  true
            140 true  */

            // bool doubleDevide = 35 % 7 == 0 && 35 % 5 == 0;
            // Console.WriteLine(doubleDevide);

            /* Write an expression that calculates rectangle’s perimeter and area by given width and height.
            Examples:

            width	height	perimeter	area
            3	    4	    14	        12
            2.5	    3	    11	        7.5
            5	    5	    20	        25  */


            // float width = float.Parse(Console.ReadLine());
            // float height = float.Parse(Console.ReadLine());
            // float perimeter = width * 2f + height * 2f;
            // float area = width * height;
            // Console.WriteLine("The result of the calculations is : " + perimeter + " " + area);


            /* Problem 5. Third Digit is 7?

            Write an expression that checks for given integer if its third digit from right-to-left is 7.
            Examples:

            n	Third digit 7?
            5	false
            701	true
            9703	true
            877	false
            777877	false
            9999799	true */


            // Console.WriteLine("Please enter your number:");
            // int p = int.Parse(Console.ReadLine());
            // int checkDigitSeven = (p / 100) % 10;
            // bool checkResult = (checkDigitSeven == 7);

            // if (checkDigitSeven == 7)
            //  {
            //      Console.WriteLine("The third digit from right-to-left is 7!");
            //  }
            //  else
            //  {
            //      Console.WriteLine("The third digit from right-to-left is different than 7.");
            // }


            /* Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101). */


            //int fourDigitNumber = 9876;
            //int a = fourDigitNumber / 1000;
            //int b = (fourDigitNumber / 100) % 10;
            //int c = (fourDigitNumber / 10) % 10;
            //int d = fourDigitNumber % 10;

            //int digitSum = a + b + c + d;
            //Console.Write(digitSum);
            //Console.Write("\n{0}{1}{2}{3} \n", d, c, b, a);
            //Console.Write("{0}{1}{2}{3} \n", d, a, b, c);
            //Console.Write("{0}{1}{2}{3} \n", a, c, b, d);



            /* Problem 7. Point in a Circle
            Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).*/


            //bool check = false;
            //double X, Y;
            //Console.Write("Enter X:");
            //bool Xcheck = double.TryParse(Console.ReadLine(), out X);
            //Console.Write("Enter Y:");
            //bool Ycheck = double.TryParse(Console.ReadLine(), out Y);
            //if (Xcheck && Ycheck)
            //{
            //    if ((X * X + Y * Y) <= 25)
            //    {
            //        check = true;
            //    }
            //    Console.WriteLine("Is the point ({0},{1}) within the circle?:{2}", X, Y, check);
            //}
            //else
            //{
            //    Console.WriteLine("Not a valid entry!");
            //}



            /* Problem 8. Prime Number Check

Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder
only to itself and 1).
Note: You should check if the number is positive */

            //double n;
            //Console.WriteLine("Please enter a positive number, max 100:");
            //n = double.Parse(Console.ReadLine());
            //
            //if (n >= 0 && n <= 100)
            //{
            //    
            //
            //    if (n == 0)
            //    {
            //        Console.WriteLine("The number you have entered is 0 and it is not devisible.");
            //    }
            //
            //    else
            //    {
            //        if (n % 2 == 0)
            //        {
            //            Console.WriteLine("The number you have entered is prime!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("The number you have entered is not prime.");
            //        }
            //    }
            //
            //
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a positive number, max 100.");
            //}


            /* 
            Problem 9. Trapezoids
            Write an expression that calculates trapezoid's area by given sides a and b and height h. */














        }
    }
}
