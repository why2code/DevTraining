using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            /*Problem 1. Declare Variables
            Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong 
            to represent the following values: 52130, -115, 4825932, 97, -10000.
            Choose a large enough type for each number to ensure it will fit in it. Try to compile the code. */

            ushort VarOne = 52130;
            sbyte VarTwo = -115;
            int VarThree = 4825932;
            byte VarFour = 97;
            short VarFive = -10000;

            /* Problem 2. Float or Double?
            Which of the following values can be assigned to a variable of type float and which to a variable of type 
            double: 34.567839023, 12.345, 8923.1234857, 3456.091?
            Write a program to assign the numbers in variables and print them to ensure no precision is lost. */

            double LongNum = 34.567839023;
            double SecondLongNum = 8923.1234857;
            float ShortNum = 12.345f;
            float SecondShortNum = 3456.091f;
            string Line = "\n";

            Console.Write(LongNum + Line + SecondLongNum + Line + ShortNum + Line + SecondShortNum);

            /* Problem 3. Variable in Hexadecimal Format
            Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
            Use Windows Calculator to find its hexadecimal representation.
            Print the variable and ensure that the result is 254. */




        }
    }
}
