using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Class day = new Class();
                Console.WriteLine("Enter the current day of the week:");//#2 Prompt the user to enter the current day of the week.
                string x = Console.ReadLine();
                string userInput = (char.ToUpper(x[0]) + x.Substring(1));
                day.Day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);
                Console.WriteLine("Yes, " + userInput + " is an actual day of the week.");
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();


        }
    }
}