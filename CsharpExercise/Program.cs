using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExercise
{
    class Program
    {
        static void Main()
        {
            DateTime birthDay = new DateTime(1990, 10, 09);
            DateTime todaysDay = DateTime.Now;
            var MyAge = todaysDay.Year - birthDay.Year;
            Console.WriteLine(MyAge);
            var myFutureAge = MyAge + 10;
            Console.WriteLine(myFutureAge);





        }
    }
}
