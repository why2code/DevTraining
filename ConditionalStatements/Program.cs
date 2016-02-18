using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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

            //Console.WriteLine("Please enter 3 numbers:");
            //Console.Write("Number a:");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Number b:");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Number c:");
            //double c = double.Parse(Console.ReadLine());
            //// a > b & a > c
            //// nested if b > c   abc
            //// else  acb
            //if (a > b & a > c)
            //{
            //    if (b > c)
            //    {
            //        Console.WriteLine("The 3 numbers in order are: {0}, {1} and {2}.", a, b, c);
            //    }
            //    else
            //    {
            //        Console.WriteLine("The 3 numbers in order are: {0}, {1} and {2}.", a, c, b);
            //    }
            //}
            //
            //// b > a & b > c
            //// nested if a > c   bac
            //// else bca
            //if (b > a & b > c)
            //{
            //    if (a > c)
            //    {
            //        Console.WriteLine("The 3 numbers in order are: {0}, {1} and {2}.", b, a, c);
            //    }
            //    else
            //    {
            //        Console.WriteLine("The 3 numbers in order are: {0}, {1} and {2}.", b, c, a);
            //    }
            //}
            //
            //// c > a & c > b
            //// nested if a > b   cab
            //// else  cba
            //if (c > a & c > b)
            //{
            //    if (a > b)
            //    {
            //        Console.WriteLine("The 3 numbers in order are: {0}, {1} and {2}.", c, a, b);
            //    }
            //    else
            //    {
            //        Console.WriteLine("The 3 numbers in order are: {0}, {1} and {2}.", c, b, a);
            //    }
            //// else if a == b == c
            //}
            //else if (a == b && b == c)
            //{
            //    Console.WriteLine("The 3 numbers in order are actually EQUAL: {0}, {1} and {2}.", a, b, c);
            //}

            /* Problem 8. Digit as Word
            Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
            Print “not a digit” in case of invalid input. Use a switch statement. */

            //Console.WriteLine("Please enter a digit between 0 and 9.");
            //string digit = Console.ReadLine();
            //    switch (digit)
            //    {
            //
            //        case "0": Console.WriteLine("zero"); break;
            //        case "1": Console.WriteLine("one"); break;
            //        case "2": Console.WriteLine("two"); break;
            //        case "3": Console.WriteLine("three"); break;
            //        case "4": Console.WriteLine("four"); break;
            //        case "5": Console.WriteLine("five"); break;
            //        case "6": Console.WriteLine("six"); break;
            //        case "7": Console.WriteLine("seven"); break;
            //        case "8": Console.WriteLine("eight"); break;
            //        case "9": Console.WriteLine("nine"); break;
            //        default: Console.WriteLine("Not a valid digit."); break;
            //    }


            /* Problem 9. Play with Int, Double and String
            Write a program that, depending on the user’s choice, inputs an int, double or string variable.
            If the variable is int or double, the program increases it by one. 
            If the variable is a string, the program appends * at the end. Print the result at the console. Use switch statement. */

            /*  Example 1:
            program user
            Please choose a type:	
            1-- > int
            2-- > double
            3-- > string    3
            Please enter a string:	hello
            hello * 

            Example 2:
            program	user
            Please choose a type:	
            1 --> int	
            2 --> double	2
            3 --> string	
            Please enter a double:	1.5
            2.5             */

            //Console.WriteLine("Please select one of the following 3 types of data:");
            //Console.WriteLine("1-- > int");
            //Console.WriteLine("2-- > double");
            //Console.WriteLine("3 --> string");
            //int userSelection = int.Parse(Console.ReadLine());
            //
            //switch (userSelection)
            //{
            //    case 1:
            //        Console.WriteLine("Selected option is intiger. Please enter a number:");
            //        int selectedInt = int.Parse(Console.ReadLine());
            //        selectedInt += 1;
            //        Console.WriteLine("The result is: {0}", selectedInt);
            //        break;
            //
            //    case 2:
            //        Console.WriteLine("Selected option is double. Please enter a number:");
            //        double selectedDouble = double.Parse(Console.ReadLine());
            //        selectedDouble += 1;
            //        Console.WriteLine("The result is: {0}", selectedDouble);
            //        break;
            //    case 3:
            //        Console.WriteLine("Selected option is string. Please enter your text:");
            //        string selectedText = Console.ReadLine();
            //        Console.WriteLine("The result is: " + selectedText + "*");
            //        break;
            //}

            /* Problem 10.* Beer Time
            A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt”
            (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer
            time according to the definition above or invalid time if the time cannot be parsed. 
            Note: You may need to learn how to parse dates and times. */

            Console.Write("Please enter time in format hours:minutes am/pm (ex 03:26 am): ");
            string inpit = Console.ReadLine();
            DateTime beerTime;
            bool timeCheck = DateTime.TryParse(inpit, out beerTime);
                        
            DateTime beerTimeStart = DateTime.Parse("1:00 PM");
            DateTime beerTimeEnd = DateTime.Parse("3:00 AM");
            
            if (timeCheck)
            {
                if ((beerTime >= beerTimeStart) || (beerTime < beerTimeEnd))
                {
                    Console.WriteLine("Beer time");
                }
                else
                {
                    Console.WriteLine("non beer time");
                }
            }
            else
            {
                Console.WriteLine("Could not convert, not a valid time entry!");
            }
            











        }
    }
}
