using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Problem 1. Exchange If Greater
            Write an if-statement that takes two double variables a and b and exchanges their values if the first one 
            is greater than the second one. As a result print the values a and b, separated by a space. */

            //Console.WriteLine("Please enter two numbers, a and b.");
            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //double exchanger = new double();
            //if (a > b)
            //{   
            //    exchanger = a;
            //    a = b;
            //    b = exchanger;
            //    Console.WriteLine("The two numbers (reversed) are {0} and {1}.", a, b);
            //}
            //else
            //{
            //    Console.WriteLine("The two numbers as entered are {0} and {1}.", a, b);
            //}


            /* Problem 2. Bonus Score
            Write a program that applies bonus score to given score in the range [1…9] by the following rules:
            If the score is between 1 and 3, the program multiplies it by 10.
            If the score is between 4 and 6, the program multiplies it by 100.
            If the score is between 7 and 9, the program multiplies it by 1000.
            If the score is 0 or more than 9, the program prints “invalid score”. */

            //Console.WriteLine("Please enter your score, ranginf from 1 to 9.");
            //int score = new int();
            //score = int.Parse(Console.ReadLine());
            //
            //switch (score)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //        score *= 10;
            //        Console.WriteLine("The score is {0}.", score);
            //        break;
            //    case 4:
            //    case 5:
            //    case 6:
            //        score *= 100;
            //        Console.WriteLine("The score is {0}.", score);
            //        break;
            //    case 7:
            //    case 8:
            //    case 9:
            //        score *= 1000;
            //        Console.WriteLine("The score is {0}.", score);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid score!");
            //        break;
            //}


            /* Problem 3. Check for a Play Card
            Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
            Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples: */

            //Console.WriteLine("Please enter your suggestion for card validation:");
            //string cardValidator = Console.ReadLine();
            //
            //switch (cardValidator)
            //{
            //    case "2":
            //    case "3":
            //    case "4":
            //    case "5":
            //    case "6":
            //    case "7":
            //    case "8":
            //    case "9":
            //    case "10":
            //    case "J":
            //    case "Q":
            //    case "K":
            //    case "A":
            //    case "j":
            //    case "q":
            //    case "k":
            //    case "a":
            //        Console.WriteLine(cardValidator + " = yes");
            //        break;
            //    default:
            //        Console.WriteLine(cardValidator + " = no");
            //        break;
            //}


            /* Problem 4. Multiplication Sign
            Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
            Use a sequence of if operators. */

            //Console.WriteLine("Please enter 3 numbers:");
            //Console.Write("Number a:");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Number b:");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Number c:");
            //double c = double.Parse(Console.ReadLine());
            //
            //if (a < 0 & b < 0 & c > 0) //negative ab + c
            //{
            //    Console.WriteLine("The result is +");
            //}
            //else if (a > 0 & b < 0 & c > 0) //negative b + ac
            //{
            //    Console.WriteLine("The result is -");
            //}
            //else if (a < 0 & b > 0 & c > 0) //negative a + bc
            //{
            //    Console.WriteLine("The result is -");
            //}
            //else if (a > 0 & b > 0 & c < 0)  //negative c + ab
            //{
            //    Console.WriteLine("The result is -");
            //}
            //else if (a > 0 & b > 0 & c > 0) // +abc
            //{
            //    Console.WriteLine("The result is +");
            //}
            //else if (a < 0 & b < 0 & c < 0) // negative abc
            //{
            //    Console.WriteLine("The result is -");
            //}
            //else if (a < 0 & b < 0 & c < 0) // negative abc
            //{
            //    Console.WriteLine("The result is -");
            //}
            //
            //else if (a < 0 & b > 0 & c < 0) //negative ac + b
            //{
            //    Console.WriteLine("The result is +");
            //}
            //else if (a > 0 & b < 0 & c < 0) //negative bc + a
            //{
            //    Console.WriteLine("The result is +");
            //}
            //
            //else if (a == 0 | b == 0 | c == 0) // a, b or c == 0
            //{
            //    Console.WriteLine("The result is 0");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter exactly 3 numbers");
            //}


            /* Problem 5. The Biggest of 3 Numbers
            Write a program that finds the biggest of three numbers. */

            //Console.WriteLine("Please enter 3 numbers:");
            //Console.Write("Number a:");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Number b:");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Number c:");
            //double c = double.Parse(Console.ReadLine());
            //
            //if ((a-b) > 0 && (a-c) > 0)
            //{
            //    Console.WriteLine("The biggest number is {0}.", a);
            //}
            //else if ((b-a) > 0 && (b- c) > 0)
            //{
            //    Console.WriteLine("The biggest number is {0}.", b);
            //}
            //else if ((c-b) > 0 && (c-a) > 0)
            //{
            //    Console.WriteLine("The biggest number is {0}.", c);
            //}

            /* Problem 6. The Biggest of Five Numbers
            Write a program that finds the biggest of five numbers by using only five if statements. */

            //Console.WriteLine("Please enter 3 numbers:");
            //Console.Write("Number a:");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Number b:");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Number c:");
            //double c = double.Parse(Console.ReadLine());
            //Console.Write("Number d:");
            //double d = double.Parse(Console.ReadLine());
            //Console.Write("Number e:");
            //double e = double.Parse(Console.ReadLine());
            //
            //
            //if ((a-b) > 0 && (a-c) > 0 && (a- d) > 0 && (a- e) > 0) //biggest A
            //{
            //    Console.WriteLine("The biggest number is {0}.", a);
            //}
            //else if ((b-a) > 0 && (b-c) > 0 && (b- d) > 0 && (b- e) > 0) //biggest B
            //{
            //    Console.WriteLine("The biggest number is {0}.", b);
            //}
            //else if ((c-b) > 0 && (c-a) > 0 && (c- d) > 0 && (c- e) > 0) //biggest C
            //{
            //    Console.WriteLine("The biggest number is {0}.", c);
            //}
            //else if ((d - a) > 0 && (d - b) > 0 && (d- c) > 0 && (d- e) > 0)
            //{
            //    Console.WriteLine("The biggest number is {0}.", d); //biggest D
            //}
            //else if ((e - a) > 0 && (e - b) > 0 && (e - c) > 0 && (e - d) > 0)
            //{
            //    Console.WriteLine("The biggest number is {0}.", e); //biggest E
            //}


            /* Problem 7. Sort 3 Numbers with Nested Ifs
            Write a program that enters 3 real numbers and prints them sorted in descending order.
            Use nested if statements. 
            Note: Don’t use arrays and the built-in sorting functionality. */
















        }
    }
}
