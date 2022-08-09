using System;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Class myObj = new Class();//instantiate the class 

            //int sum1 = myObj.Add(20, 20); //for testing themethod
            //Console.WriteLine(sum1)

            Console.WriteLine("You will be asked to input two numbers, one at a time.\n" +
                "You do need not enter anything for the second number.");
            Console.WriteLine("Add the first  number:");
            int userNumber1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Would you line to add another number(y/n)?");
            char input = Console.ReadLine()[0];
            if (input == 'y' || input =='Y')
            {
                Console.WriteLine("Add the second number:");
                int userNumber2 = Convert.ToInt32(Console.ReadLine());
                int sum2 = myObj.Add(userNumber1, userNumber2);//if second number is added, pass both numbers to the method
                Console.WriteLine(sum2);//return an integer result
            }
            else
            {
                int sum2 = myObj.Add(userNumber1);//if second number is not added, pass only the first number to the method
                Console.WriteLine(sum2);//return an integer result
            }
            Console.ReadLine();
        }
    }
}
