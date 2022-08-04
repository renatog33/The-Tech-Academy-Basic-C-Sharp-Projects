using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple shipping quote for a package program.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");//Enter the package weight
            int packageWeight = Convert.ToInt32(Console.ReadLine());//cast as integare and save the package weight

            Console.WriteLine("Please enter the package width:");//Enter the package weight
            int packageWidth = Convert.ToInt32(Console.ReadLine());//cast as integare and save the package width

            Console.WriteLine("Please enter the package height:");//Enter the package height
            int packageHeight = Convert.ToInt32(Console.ReadLine());//cast as integare and save the package height

            Console.WriteLine("Please enter the package length:");//Enter the package length
            int packageLength = Convert.ToInt32(Console.ReadLine());//cast as integare and save the package length

            int quote = (packageWidth * packageHeight * packageLength * packageWeight) / 100;//create varibale to represent quote calculation

            if (packageWidth + packageHeight + packageLength > 50)//Check to see if the dimensions total greater than 50
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote +
                    " \nThank you!");
            }
            Console.ReadLine();
        }
    }
}
