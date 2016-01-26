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

            int checkNumb = (2 % 2);
            bool oddOrEven = (checkNumb != 0);
            Console.Write(oddOrEven);

            /* Problem 2. Gravitation on the Moon
            The gravitational field of the Moon is approximately 17% of that on the Earth.
            Write a program that calculates the weight of a man on the moon by a given weight on the Earth. */

            float earthWeight = float.Parse(Console.ReadLine());
            float moonWeight = earthWeight * 0.17f;
            Console.WriteLine(moonWeight);

            /* Problem 3. Divide by 7 and 5
            Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
            3   false
            7   false
            35  true
            140 true  */

            bool doubleDevide = 35 % 7 == 0 && 35 % 5 == 0;
            Console.WriteLine(doubleDevide);

            /* Write an expression that calculates rectangle’s perimeter and area by given width and height.
            Examples:

            width	height	perimeter	area
            3	    4	    14	        12
            2.5	    3	    11	        7.5
            5	    5	    20	        25  */


            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float perimeter = width * 2f + height * 2f;
            float area = width * height;
            Console.WriteLine("The result of the calculations is : " + perimeter + " " + area);

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















        }
    }
}
