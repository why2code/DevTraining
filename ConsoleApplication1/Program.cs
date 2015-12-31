using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primitiveDataTypes
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

            int HexaDec = 0xFE;
            Console.Write(Line + HexaDec);

            /* Problem 4. Unicode Character
            Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) 
            using the \u00XX syntax, and then print it. 
            Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.  */

            char A = '\u002A';
            Console.Write(A);

            /* Problem 5. Boolean Variable
            Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
            Print it on the console. */

            Console.WriteLine("Please enter your gender, male or female.");
            string Gender = Console.ReadLine();
            bool isFemale = Gender.Equals("male");
            Console.Write(isFemale);

            /*Problem 6. Strings and Objects

            Declare two string variables and assign them with Hello and World.
            Declare an object variable and assign it with the concatenation of the first two 
            variables (mind adding an interval between).
            Declare a third string variable and initialize it with the value of the object
            variable (you should perform type casting). */

            string Hello = "Hello";
            string World = "World";
            object concateHelloWorld = Hello + " " + World;
            Console.Write(concateHelloWorld);
            string equalObject = (string)concateHelloWorld;
            Console.Write(equalObject);

            /* Problem 7. Quotes in Strings
            Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
            Do the above in two different ways - with and without using quoted strings.
            Print the variables to ensure that their value was correctly defined. */

            string text1 = "The use of quotations causes difficulties.";
            string text2 = "The \"use\" of quotations causes difficulties.";
            Console.Write(text1 + Line + text2);


            /* Problem 8. Isosceles Triangle
            Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
               ©

              © ©

             ©   ©

            © © © ©
            Note: The © symbol may be displayed incorrectly at the console so you may need to change the
            console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

            Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of 
            how much effort you put to fix it. */

            
            char Tree = '©';
            char Space = '\t';
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(Line + "{0,4}\n{0,3}{0,2}\n{0,2}{0,4}\n{0}{0,2}{0,2}{0,2}", Tree);

            /* Problem 9. Exchange Variable Values
            Declare two integer variables a and b and assign them with 5 and 10 and after that exchange
            their values by using some programming logic. Print the variable values before and after the exchange */




        }
    }
}
