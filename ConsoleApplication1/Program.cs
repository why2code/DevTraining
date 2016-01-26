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

            int Five = 5;
            int Ten = 10;
            Console.WriteLine("The values before the swap are {0} and {1} .", Five, Ten);
            int SwapValues = Five;
            Five = Ten;
            Ten = SwapValues;
            Console.WriteLine("The values after the swap are {0} and {1} .", Five, Ten);


            /* Problem 10. Employee Data
            A marketing company wants to keep record of its employees. Each record would have the following
            characteristics:

            First name
            Last name
            Age (0...100)
            Gender (m or f)
            Personal ID number (e.g. 8306112507)
            Unique employee number (27560000…27569999)
            
            Declare the variables needed to keep the information for a single employee using appropriate
            primitive data types. Use descriptive names. Print the data at the console. */

            string firstName = "Haralampi";
            string lastName = "Stoyanov";
            byte userAge = 27;
            char personGender = 'm';
            long personalID = 8306112507;
            uint employeeNumber = 27569999;

            Console.WriteLine("Employee data: {0}, {1}, {2}, {3}, {4}, {5}", firstName, lastName, userAge, personGender, personalID, employeeNumber );


            /* Problem 12. Null Values Arithmetic
            Create a program that assigns null values to an integer and to a double variable.
            Try to print these variables at the console.
            Try to add some number or the null literal to these variables and print the result. */

            int? intAsNull = null;
            double? doubleAsInt = null;
            Console.Write("These are the null values:" + intAsNull + doubleAsInt);

            intAsNull = 100;
            doubleAsInt = 30.148432456;

            Console.Write("These are the assigned values:" + intAsNull + "  " + doubleAsInt);


            /* Problem 13.* Comparing Floats

            Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
            Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the
            floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other
            than a fixed constant eps. */

            double compareOne = 5.00000005;
            double compareTwo = 5.00000001;
            double eps = 0.000001;
            bool calculateDelta = Math.Abs(compareOne - compareTwo) < eps;
            Console.Write(calculateDelta);



            /* Problem 14.* Print the ASCII Table

            Find online more information about ASCII (American Standard Code for Information Interchange) and write
            a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
            
            Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or
            display them differently. 
            Note: You may need to use for-loops (learn in Internet how). */

            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine("{0}-->{1}", i, (char)i);
            }








        }
    }
}
