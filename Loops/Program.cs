using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Problem 1. Numbers from 1 to N
            Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n,
            on a single line, separated by a space. */

            //Console.WriteLine("Please, enter a positive number n:");
            //int n = int.Parse(Console.ReadLine());
            //
            //for (int i = 1; i < n; i++)
            //{
            //    Console.Write(" " + i);
            //}

            /* Problem 2. Numbers Not Divisible by 3 and 7
            Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n
            not divisible by 3 or 7, on a single line, separated by a space. */

            //Console.WriteLine("Please, enter a positive number n:");
            //int n = int.Parse(Console.ReadLine());
            //
            //for (int i = 1; i <= n; i++)
            //{
            //
            //    if ((i % 7 != 0) && (i % 3 != 0))
            //    {
            //        Console.Write(i + " ");
            //    }
            //   
            //}


            /* Problem 3. Min, Max, Sum and Average of N Numbers
            Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
            the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
            The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 
            The output is like in the examples below. 
            input	output
            3       min = 1 
            2       max = 5
            5       sum = 8 
            1	    avg = 2.67                    */


            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //int number;
            //
            //int max = int.MinValue;
            //int min = int.MaxValue;
            //int sum = 0;
            //
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Enter number {0}: ", i + 1);
            //    number = int.Parse(Console.ReadLine());
            //
            //    if (number > max)
            //    {
            //        max = number;
            //    }
            //
            //    if (number < min)
            //    {
            //        min = number;
            //    }
            //
            //    sum += number;
            //}
            //double avg = (double)sum / n;
            //Console.WriteLine("min = {0}", min);
            //Console.WriteLine("max = {0}", max);
            //Console.WriteLine("sum = {0}", sum);
            //Console.WriteLine("average = {0:F2}", avg);


            /* Problem 4. Print a Deck of 52 Cards
            Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
            The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of
            diamonds). The card faces should start from 2 to A. Print each card face in its four possible suits: 
            clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement. */

            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //for (int i = 2; i <= 14; i++)
            //{
            //    if (i >= 11)
            //    {
            //        
            //        for (int j = 11; j <= 14; j++)
            //        {
            //            
            //            switch (j)
            //            {
            //                case 11:
            //                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
            //                    break;
            //                case 12:
            //                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
            //                    break;
            //                case 13:
            //                    Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
            //                    break;
            //                case 14:
            //                    Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
            //                    break;
            //            }
            //            
            //        }
            //        break;
            //
            //
            //    }
            //    else
            //    {
            //        switch (i)
            //        {
            //            case 2:
            //                Console.WriteLine("{0} of spades, {1} of clubs, {2} of hearts, {3} of diamonds", i, i, i, i);
            //                break;
            //            case 3:
            //                Console.WriteLine("{0} of spades, {1} of clubs, {2} of hearts, {3} of diamonds", i, i, i, i);
            //                break;
            //            case 4:
            //                Console.WriteLine("{0} of spades, {1} of clubs, {2} of hearts, {3} of diamonds", i, i, i, i);
            //                break;
            //            case 5:
            //                Console.WriteLine("{0} of spades, {1} of clubs, {2} of hearts, {3} of diamonds", i, i, i, i);
            //                break;
            //            case 6:
            //                Console.WriteLine("{0} of spades, {1} of clubs, {2} of hearts, {3} of diamonds", i, i, i, i);
            //                break;
            //            case 7:
            //                Console.WriteLine("{0} of spades, {1} of clubs, {2} of hearts, {3} of diamonds", i, i, i, i);
            //                break;
            //            case 8:
            //                Console.WriteLine("{0} of spades, {1} of clubs, {2} of hearts, {3} of diamonds", i, i, i, i);
            //                break;
            //            case 9:
            //                Console.WriteLine("{0} of spades, {1} of clubs, {2} of hearts, {3} of diamonds", i, i, i, i);
            //                break;
            //            case 10:
            //                Console.WriteLine("{0} of spades, {1} of clubs, {2} of hearts, {3} of diamonds", i, i, i, i);
            //                break;
            //        }
            //    }
            //    
            //}


            /* Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
            Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
            Use only one loop. Print the result with 5 digits after the decimal point. */

            //double x, n;
            //Console.Write("Please enter number n:");
            //bool parseN = double.TryParse(Console.ReadLine(), out n);
            //Console.Write("Please enter number x:");
            //bool parseX = double.TryParse(Console.ReadLine(), out x);
            //double sum = 1;
            //double factoriel = 1;
            //
            //if (parseN && parseX)
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        
            //        factoriel *= i;
            //        sum += factoriel / Math.Pow(x, i);
            //        
            //    }
            //    Console.WriteLine("The result for Sum is: {0:F5} .", sum);
            //}
            //
            //else
            //{
            //    Console.WriteLine("Not a valid entry, please enter two numbers.");
            //}


            /* Problem 6. Calculate N! / K!
            Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
            Use only one loop. */

            //Console.Write("Please input n:");
            //double n = int.Parse(Console.ReadLine());
            //Console.Write("Please input k:");
            //double k = int.Parse(Console.ReadLine());
            //double result = 0;
            //double factorielN = 1;
            //double factorielK = 1;
            //
            //if (k > 1 && n < 100 && k < n)
            //{
            //    for (double i = 1; i <= n; i++) //calculating factoriel n! where the value of i grows based on n.
            //    {
            //        factorielN *= i; 
            //        if (i <= k) // calculating factoriel k! only for the value growing until k.
            //         {
            //             factorielK *= i; 
            //         }
            //        result = factorielN / factorielK;
            //        
            //    }
            //     
            //     Console.WriteLine(result);
            //
            // }
            //else
            //{
            //    Console.WriteLine("Please enter k and n according to: 1 < k < n < 100 ");
            //}


            /* Problem 7. Calculate N! / (K! * (N-K)!)
            In combinatorics, the number of ways to choose k different members out of a group of n different elements
            (also known as the number of combinations) is calculated by the following formula: formula For example, 
            there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
            Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
            Try to use only two loops. */

            //Console.Write("Please input n:");
            //double n = int.Parse(Console.ReadLine());
            //Console.Write("Please input k:");
            //double k = int.Parse(Console.ReadLine());
            //double result = 0;
            //double factorielN = 1;
            //double factorielK = 1;
            //double factorielNminusK = (n - k);
            //
            //if (k > 1 && n < 100 && k < n)
            //{
            //    for (double i = 1; i <= n; i++) //calculating factoriel n! where the value of i grows based on n.
            //    {
            //        factorielN *= i; 
            //
            //        if (i <= k) // calculating factoriel k! only for the value growing until k.
            //         {
            //            factorielK *= i; //calculating factoriel for K where i is dependent ot k
            //         }   
            //
            //        if (i == 1) // this ensures we only calculate (n-k)! once during the first look i = 1.
            //        {
            //            for (int j = 1; j < (n - k); j++)
            //            {
            //                factorielNminusK *= j; 
            //            }
            //        }
            //        
            //         
            //        result = factorielN / (factorielK*factorielNminusK) ;
            //        
            //    }
            //    Console.WriteLine(result);
            //
            //
            //}
            //else
            //{
            //    Console.WriteLine("Please enter k and n according to: 1 < k < n < 100 ");
            //}


            /* Problem 8. Catalan Numbers
            In combinatorics, the Catalan numbers are calculated by the following formula: 
            - see the web site for the formule: catalan-formula.
            Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100). */

            //BigInteger n;
            //BigInteger result = 0;
            //Console.Write("Please enter the value for n:");
            //bool checkN = BigInteger.TryParse(Console.ReadLine(), out n);
            //BigInteger factoriel = 1;
            //BigInteger factoriel_2n = (2 * n);
            //BigInteger factoriel_n_plus_one = (n + 1);
            //
            //
            //if (checkN && n >= 0 && n <= 100)
            //{
            //
            //    if (n == 0)
            //    {
            //        for (int m = 1; m <= 1; m++)
            //        {
            //            factoriel *= m;
            //            factoriel_2n = 1 + (factoriel_2n*m);
            //            factoriel_n_plus_one *= m;
            //            result = factoriel_2n / (factoriel_n_plus_one * factoriel);
            //        }
            //    }
            //
            //    for (int i = 1; (i <= n); i++)
            //    {
            //
            //        factoriel *= i;
            //        
            //        if (i == 1)
            //        {
            //            for (int j = 1; j < (2 * n); j++)
            //            {
            //                factoriel_2n *= j;
            //            }
            //            for (int k = 1; k <= n; k++)
            //            {
            //                factoriel_n_plus_one *= k;
            //            }
            //        }
            //
            //        
            //        result = factoriel_2n / (factoriel_n_plus_one * factoriel);
            //    }
            //
            //    Console.WriteLine(result);
            //
            //
            //}
            //
            //else
            //{
            //    Console.WriteLine("Please enter n based on the condition: 0 <= n <= 100");
            //}


            /* Problem 9. Matrix of Numbers
            Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints
            a matrix like in the examples below. Use two nested loops. */

            //Console.WriteLine("Enter an integer in the range (1 ≤ n ≤ 20):");
            //int n = int.Parse(Console.ReadLine());
            //int countCol = 1;
            //if (n < 1 || n > 20)
            //{
            //    Console.WriteLine("Invalid input!");
            //    return;
            //}
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = i; j < 2 * n; j++)
            //    {
            //        if (countCol <= n)
            //        {
            //            Console.Write("{0} ", j);
            //            countCol++;
            //        }
            //    }
            //    Console.WriteLine();
            //    countCol = 1;
            //}


            /* Problem 10. Odd and Even Product
            You are given n integers (given in a single line, separated by a space).
            Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
            Elements are counted from 1 to n, so the first element is odd, the second is even, etc. */

            //Console.WriteLine("Enter integers with a space between them:");
            //string[] num = Console.ReadLine().Split();
            //int sumOdd = 1;
            //int sumEven = 1;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sumOdd *= Convert.ToInt32(num[i]);
            //    }
            //    else
            //    {
            //        sumEven *= Convert.ToInt32(num[i]);
            //    }
            //}
            //if (sumEven == sumOdd)
            //{
            //    Console.WriteLine("yes");
            //    Console.WriteLine("product={0}", sumOdd);
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //    Console.WriteLine("odd_product={0}", sumOdd);
            //    Console.WriteLine("even_product={0}", sumEven);
            //}


            /* Problem 11. Random Numbers in Given Range
            Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers
            in the range [min...max]. */

            Console.Write("Please enter your min value:");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Please enter your max value:");
            int max = int.Parse(Console.ReadLine());
            Console.Write("Please enter the n amount of numbers to be generated:");
            int n = int.Parse(Console.ReadLine());
            Random randomer = new Random();
            int numbers = 1;
            
            for (int k = 1; k <= n; k++)
            {
                for (int i = min; i >= min && i <= max; i++)
                {
                    numbers = randomer.Next(i);
                }
            
                Console.Write("{0} ", numbers);
            }


            









        }
    }
}
