using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Declaring single-dimensional string array
        string[] AirportCode = new string[3];
        AirportCode[0] = "SFO";
        AirportCode[1] = "PDX";
        AirportCode[2] = "LAX";

        Console.WriteLine("The airport code array is:\n");

        Console.WriteLine(AirportCode[0] +" "+ AirportCode[1] +" "+ AirportCode[2]);
        Console.ReadLine();

        Console.WriteLine("Enter an index of the array:");//Ask the user to select an index of the Array 
        int index = Convert.ToInt32(Console.ReadLine());
        if (index > 2)
        {
        Console.WriteLine("That index doesn’t exist.");//Add in a message that displays when the user selects an index that doesn’t exist.
        }
        else
        {
        Console.WriteLine(AirportCode[index]);//and then display the string at that index on the screen.
        }
        Console.ReadLine();

        //Declaring single-dimensional integer array
        int[] weight = new int[3];
        weight[0] = 100;
        weight[1] = 150;
        weight[2] = 200;

        Console.WriteLine("The weight array is:\n");

        Console.WriteLine(weight[0] + " " + weight[1] + " " + weight[2]);
        Console.ReadLine();

        Console.WriteLine("Enter an index of the array:");//Ask the user to select an index of the Array 
        int index1 = Convert.ToInt32(Console.ReadLine());
        if (index1 > 2)
        {
            Console.WriteLine("That index doesn’t exist.");//Add in a message that displays when the user selects an index that doesn’t exist.
        }
        else
        {
            Console.WriteLine(weight[index1]);//and then display the string at that index on the screen.
        }
        Console.ReadLine();

        List<string> stringList = new List<string>();
        stringList.Add("Hello.");
        stringList.Add("My name is Renato.");
        stringList.Add("I am a student at the Tech Academy.");

        Console.WriteLine("The string list is:\n");

        Console.WriteLine(stringList[0] + " " +stringList[1] + " " + stringList[2]);
        Console.ReadLine();

        Console.WriteLine("Enter an index of the array:");//Ask the user to select an index of the Array 
        int index2 = Convert.ToInt32(Console.ReadLine());
        if (index2 > 2)
        {
            Console.WriteLine("That index doesn’t exist.");//Add in a message that displays when the user selects an index that doesn’t exist.
        }
        else
        {
            Console.WriteLine(stringList[index2]);//and then display the string at that index on the screen.
        }
        Console.ReadLine();




    }
}
