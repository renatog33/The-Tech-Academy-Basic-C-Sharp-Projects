using System;

namespace ConsoleAppAssignmnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");//Ask for user to input a number
            double userNumber = Convert.ToDouble(Console.ReadLine());
            int mul = 50; //varibale for 50
            double result = (userNumber * mul); //multiple user number by 50
            Console.WriteLine(result);

            Console.WriteLine("Input another number:");//Ask for user to input another number
            int newNumber = Convert.ToInt32(Console.ReadLine());
            int add = 25; //varibale for 25
            int addNumbers = (newNumber + add); //add 25 to users number
            Console.WriteLine(addNumbers);

            Console.WriteLine("Input another number:");//Ask for user to input another number
            int newNumber1 = Convert.ToInt32(Console.ReadLine());
            float divide = 12.5f; //varibale for 12.5
            float divideNumbers = (newNumber1 / divide); //divide user's number by 12.5
            Console.WriteLine(divideNumbers);

            Console.WriteLine("Input another number:");//Ask for user to input another number
            int newNumber2 = Convert.ToInt32(Console.ReadLine());
            int compare = 50; //varibale for 50
            bool comparison = (newNumber2 > compare); //check to see is user's number is greater than 50
            Console.WriteLine(comparison);

            Console.WriteLine("Input another number:");//Ask for user to input another number
            int newNumber3 = Convert.ToInt32(Console.ReadLine());
            int divisor = 7; //varibale for 7
            int remainder = (newNumber3 % divisor); //get remiander of user's number divided by 7
            Console.WriteLine(remainder);
        }
    }
}
