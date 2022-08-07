using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //CONSOLE APP PART ONE ASSIGNMENT
        string[] names = { "Bill", "Joe", "Bob", "Jeff" };//A one-dimensional array of strings.

        Console.WriteLine("Please enter a name for the Group:");//Ask the user to input some text.
        string groupName = Console.ReadLine();

        for (int i = 0; i < names.Length; i++)//A loop that iterates through each string in the array and adds the user's text input to the end of each string.
            names[i] += groupName;
        foreach (string s in names) //create a second loop that prints off each string in the array one at a time.
            Console.WriteLine(s);
        Console.ReadLine();


        //Infinite Loop - CONSOLE APP PART TWO ASSIGNMENT
        for (int a = 0; a < 5; a++)//Initially , to create the infinite loop the
            //for statement was:for (int a = 0; a < 50; a--)
            //to fix, change a-- to a++
        {
            Console.WriteLine("value : {0}", a);
        }
        Console.ReadLine();

        //Infinite Loop - CONSOLE APP PART THREE ASSIGNMENT
        for (int a = 0; a < 3; a++)//A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
        {
            Console.WriteLine("value : {0}", a);
        }
        Console.ReadLine();
        for (int b = 0; b <= 3; b++)
        {
            Console.WriteLine("value : {0}", b);//Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.

        }
        Console.ReadLine();

        //CONSOLE APP PART FOUR ASSIGNMENT
        List<string> names1 = new List<String>() { "Jesse", "Erik", "Adam" };//A list of strings where each item in the list is unique.

        for (; ; )//uncontrolled loop
        {
            Console.WriteLine("Input text to search for in the list?");//Ask the user to input text to search for in the list.
            string search = Console.ReadLine();
            int i;
            for (i = 0; i < names1.Count && !names1[i].Contains(search); i++) { }
            if (i < names1.Count)
            {
                Console.WriteLine("Search found at index " + i);//A loop that iterates through the list and then displays the index of the list item
                //that contains matching text on the screen.
                break;//leave the loop now
            }
            Console.WriteLine("That search is not on the list");
        }
        Console.ReadLine();

        ////CONSOLE APP PART FIVE ASSIGNMENT

        List<string> names2 = new List<String>() { "Jesse", "Erik", "Adam", "Adam" };//A list of strings where each item in the list is unique.

        for (; ; )//uncontrolled loop
        {
            Console.WriteLine("Input text to search for in the list?");//Ask the user to input text to search for in the list.
            string search = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < names2.Count; i++)//Create a loop that iterates through the list and then displays
                //the indices of the items matching the user-selected text
                if (names2[i] == search)
                {
                    Console.WriteLine("Search found at index " + i);
                    found = true;
                }
            if (found)
                break;//leave the loop now
            Console.WriteLine("That search is not on the list");
        }
        Console.ReadLine();

        ////CONSOLE APP PART SIX ASSIGNMENT

        List<string> checkthis = new List<String>() { "A", "B", "C", "C" };//Create a list of strings that has at least two identical strings in the list.
        List<string> alreadySeen = new List<String>();//Create empty list

        foreach (string s in checkthis)
        {
            if (alreadySeen.Contains(s))//for each element with a duplicate
            {
                Console.WriteLine(s + " this item is duplicate.");
            }
            else //otherwise, say the elemetn ius unique
            {
                Console.WriteLine(s + " this item is unique.");
            }
            alreadySeen.Add(s);
        }
        Console.ReadLine();
    }

}
