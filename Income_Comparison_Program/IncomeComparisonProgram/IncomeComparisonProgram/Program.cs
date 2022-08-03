using System;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple anonymous income comparison program.
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");//Gather input for Person 1
            Console.WriteLine("Hourly Rate?");//Enter Person 1's hourly rate
            int p1HourlyRate = Convert.ToInt32(Console.ReadLine());//cast as integare and save Person 1's hourly rate
            Console.WriteLine("Hourly Worked per week?");//Enter Person 1's hours worked per week
            int p1HoursWorked = Convert.ToInt32(Console.ReadLine());//cast as integer save Person 1's hours per week worked
            Console.WriteLine("Annual salary of Person 1:");
            int weeks = 52; //number of weeks in a year
            int p1annualSalary = (p1HourlyRate * p1HoursWorked * weeks);//multiple hourly rate by hours worked per week * 52 to get annual salary
            Console.WriteLine(p1annualSalary);

            Console.WriteLine("Person 2");//Gather input for Person 2
            Console.WriteLine("Hourly Rate?");//Enter Person 2's hourly rate
            int p2HourlyRate = Convert.ToInt32(Console.ReadLine());//cast as integare and save Person 1's hourly rate
            Console.WriteLine("Hourly Worked per week?");//Enter Person 2's hours worked per week
            int p2HoursWorked = Convert.ToInt32(Console.ReadLine());//cast as integer save Person 1's hours per week worked
            Console.WriteLine("Annual salary of Person 1:");
            //number of weeks in a year
            int p2annualSalary = (p2HourlyRate * p2HoursWorked * weeks);//multiple hourly rate by hours worked per week * 52 to get annual salary
            Console.WriteLine(p2annualSalary);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool comparison = (p1annualSalary > p2annualSalary);//Compare annual salaries
            Console.WriteLine(comparison);//Result of question will be "true" or "false"





        }
    }
}
