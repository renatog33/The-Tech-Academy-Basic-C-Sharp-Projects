using System;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");//Ask for age
            int age = Convert.ToInt32(Console.ReadLine());//cast as integer and save age

            Console.WriteLine("Have you ever had a DUI? Answer \'true\' or \'false\'.");//Ask about DUI status
            bool dui = Convert.ToBoolean(Console.ReadLine());//cast as boolean value and save dui status

            Console.WriteLine("How many speeding tickets do you have?");//Ask for number of speeding tickets
            int tickets = Convert.ToInt32(Console.ReadLine());//cast as integer and save number of speeding tickets

            Console.WriteLine("Qualified");//Determine if person is qualified
            bool qualified = (age > 15 && dui == false && tickets <=3);//use boolean operators to determin approval eligibility
            Console.WriteLine(qualified);
        }
    }
}
