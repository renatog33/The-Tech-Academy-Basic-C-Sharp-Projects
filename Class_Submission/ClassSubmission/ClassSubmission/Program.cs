using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperator Divide = new MathOperator(); //#2 inititate class

            Console.WriteLine("Enter a number to be divided by 2:");//#3 Have the user enter a number. Call the method on that number. Display the output to the screen.
           //It should be the entered number, divided by two.
            int userInput = Convert.ToInt32(Console.ReadLine());
            Divide.Div(userInput);
            Console.ReadLine();

            Console.WriteLine("Your number will be added to 1000");//uisng output parameters
            Divide.Div(userInput, out int b);
            Console.WriteLine(b);
            Console.ReadLine();

            int c = Static.subtract(userInput);//static class- do not need to initiate class
            Console.WriteLine("Your number minus 10 is " + c);

            Console.ReadLine();

        }

    }

}
