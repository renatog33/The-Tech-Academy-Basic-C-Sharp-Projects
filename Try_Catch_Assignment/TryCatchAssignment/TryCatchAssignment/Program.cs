using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");//#1 Ask the user for their age.
            bool validAnswer = false;
            while (!validAnswer)
            {
                try //#3 Exceptions must be handled using “try/catch.”
                {
                    int age = Convert.ToInt32(Console.ReadLine());
                    DateTime birthyear = DateTime.Now.AddYears(-age);
                    Console.WriteLine("You were born in " + birthyear.Year+"."); //#2 Display the year the user was born.
                    validAnswer = true;               
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number."); //Display appropriate error messages if the user enters zero or negative numbers.
                    validAnswer = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred.");
                    Console.ReadLine();
                    return;
                }
            }

            Console.ReadLine();

        }
    }
}