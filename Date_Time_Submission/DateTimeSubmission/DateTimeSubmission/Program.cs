using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = DateTime.Now;  //#1  prints current date and time to the console 
            Console.WriteLine("The current date and time is " + timeNow);

            Console.WriteLine("Enter a number:");//#2 Asks the user for a number.
            int userNum = Convert.ToInt32(Console.ReadLine());

            //#3 Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine("The current time plus " + userNum + " hours = " + timeNow.AddHours(userNum));

            Console.ReadLine();
        }
    }
}
