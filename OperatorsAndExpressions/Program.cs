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
            Write an expression that calculates trapezoid's area by given sides a and b and height h. 
            A = 1/2(b1 + b2).h 
            a	b	h
            5	7	12
            2	1	33
            8.5	4.3	2.7 */

            //double sideA = 8.5;
            //double sideB = 4.3;
            //double height = 2.7;
            //double trapezoidArea;
            //
            //trapezoidArea = 0.5 * (sideA + sideB) * height;
            //Console.Write(trapezoidArea);


            /* Problem 10. Point Inside a Circle & Outside of a Rectangle
            Write an expression that checks for given point (x, y) if it is within the circle 
            K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).*/


            //bool check = false;
            //double X, Y;
            //Console.Write("Enter X:");
            //bool Xcheck = double.TryParse(Console.ReadLine(), out X);
            //Console.Write("Enter Y:");
            //bool Ycheck = double.TryParse(Console.ReadLine(), out Y);
            //if (Xcheck && Ycheck)
            //{
            //    if ((X >= -1 && Y >= -1) && (X <= 5 && Y <= 1))
            //    {
            //        //Do nothing   
            //    }
            //    else
            //    {
            //        double displacedX = X - 1;
            //        double displacedY = Y - 1;
            //        if ((displacedX * displacedX + displacedY * displacedY) <= 2.25)
            //        {
            //            check = true;
            //
            //        }
            //    }
            //    Console.WriteLine("Is the point ({0},{1}) within the circle and out of the rectangle?:{2}", X, Y, check);
            //}
            //else
            //{
            //    Console.WriteLine("Not a valid entry!");
            //}





            /* Problem 11. Bitwise: Extract Bit #3

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0. 
        n	binary representation	bit #3
        5	00000000 00000101	    0
        0	00000000 00000000	    0
        15	00000000 00001111	    1
        5343 00010100 11011111	    1*/

            //int checkBitNum = 3;
            //int num = 5343;
            //int mask = (1 << checkBitNum);
            //int positionCheck = num & mask;
            //int bit = positionCheck >> checkBitNum;
            //Console.Write(bit);


            /* Problem 12. Extract Bit from Integer
            Write an expression that extracts from given integer n the value of given bit at index p */

            //int num;
            //int bitPosition;
            //Console.WriteLine("Please enter the integer number.");
            //bool checkInt = int.TryParse(Console.ReadLine(), out num);
            //Console.WriteLine("Please enter the bit index number.");
            //bool checkBit = int.TryParse(Console.ReadLine(), out bitPosition);
            //
            //if (checkBit && checkInt)
            //{
            //    int mask = (1 << bitPosition);
            //    int numAndMask = num & mask;
            //    int bit = numAndMask >> bitPosition;
            //    Console.Write("The value of the bit at position {0} in number {1} is {2}.", bitPosition, num ,bit);
            //}
            //
            //else
            //{
            //    Console.WriteLine("This is not a valid entry, please enter whole numbers only.");
            //}



            /* Problem 13. Check a Bit at Given Position
            Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in 
            given integer number n, has value of 1. */

            //int num;
            //int bitPosition;
            //Console.WriteLine("Please enter the integer number.");
            //bool checkInt = int.TryParse(Console.ReadLine(), out num);
            //Console.WriteLine("Please enter the bit index number.");
            //bool checkBit = int.TryParse(Console.ReadLine(), out bitPosition);
            //
            //if (checkBit && checkInt)
            //{
            //    int mask = (1 << bitPosition);
            //    int numAndMask = num & mask;
            //    int bit = numAndMask >> bitPosition;
            //    bool confirmNumberAtP = (bit == 1);
            //    Console.Write("Is the number at position {0} in integer {1} a 1? The answer is {2} !", 
            //        bitPosition, num, confirmNumberAtP);
            //    
            //}
            //
            //else
            //{
            //    Console.WriteLine("This is not a valid entry, please enter whole numbers only.");
            //}


            /* Problem 14. Modify a Bit at Given Position
            We are given an integer number n, a bit value v (v=0 or 1) and a position p.
            Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at 
            the position p from the binary representation of n while preserving all other bits in n. 
            n	binary representation of n	p	v	binary result	   result
            5	00000000 00000101	        2	0	00000000 00000001	1
            0	00000000 00000000	        9	1	00000010 00000000	512
            15	00000000 00001111	        1	1	00000000 00001111	15
            5343	00010100 11011111	    7	0	00010100 01011111	5215
            62241	11110011 00100001	    11	0	11110011 00100001	62241 */
            
            //int num;
            //int bitPosition;
            //int bitValue;
            //Console.WriteLine("Please enter the integer number.");
            //bool checkInt = int.TryParse(Console.ReadLine(), out num);
            //Console.WriteLine("Please enter the bit position number.");
            //bool checkBit = int.TryParse(Console.ReadLine(), out bitPosition);
            //Console.WriteLine("Please enter the bit value of 0 or 1.");
            //bool checkBitValue = int.TryParse(Console.ReadLine(), out bitValue);
            //
            //if (checkInt && checkBit)
            //{
            //    if (bitValue == 0 | bitValue == 1)
            //        {
            //        int mask = (1 << bitPosition);
            //        int numAndMask = mask & num;
            //        int maskResult = numAndMask >> bitPosition;
            //
            //            if (maskResult == 1 & bitValue == 1)
            //                {
            //                int finalOne = ~mask & num;
            //                int tweakingMask = 0 << bitPosition;
            //                int resultOne = tweakingMask ^ num;
            //                Console.WriteLine(resultOne);
            //                }
            //            if (maskResult == 0 & bitValue == 0)
            //                {
            //                int finalTwo = ~mask & num;
            //                
            //                Console.WriteLine(finalTwo);
            //                }
            //            if (maskResult == 0 & bitValue == 1) 
            //                {
            //                int finalThree = mask ^ num;
            //                Console.WriteLine(finalThree);
            //                }
            //            if (maskResult == 1 & bitValue == 0)
            //                {
            //                int finalFour = ~mask & num;
            //                Console.WriteLine(finalFour);
            //                }
            //
            //        }
            //
            //    else
            //    {
            //        Console.WriteLine("INVALID BIT ENTRY! Please enter a bit value if 0 or 1.");
            //    }
            //
            // }




            /* Problem 15.* Bits Exchange
            Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. */















        }
    }
}
