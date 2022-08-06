using System;
using System.Collections.Generic;


class Program
{

    static void Main(string[] args)
    {
        try
        {
            List<int> integers = new List<int>() { 10, 20, 100 };
            Console.WriteLine("The list of integers is:");
            Console.WriteLine(String.Join(", ", integers));

            Console.WriteLine("Pick a number to divide list by.");//Ask the user for a number to divide each number in the list by.
            int numberOne = Convert.ToInt32(Console.ReadLine());

            foreach (int integer in integers)//A loop that takes each integer in the list,
            //divides it by the number the user entered, and displays the result to the screen.
            {
                if (integer > -10000)
                {
                    Console.WriteLine("The results are:" + integer / numberOne);
                }
            }
            
        }
        catch (FormatException)
        {
            Console.WriteLine("Please type a whole number.");//If a string is entered as the number to divide by
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Please don't divide by zero.");//If a zero is entered as the number to divide by
        }
        catch (Exception ex)//general exception
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
        Console.WriteLine("The program has emerged from the try/catch block and will continue on with program execution.");
        //make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.
        Console.ReadLine();
    }
}
