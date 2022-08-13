using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: "); //Asks the user for a number.
            
            string number = (Console.ReadLine());//Logs that number to a text file.

            File.WriteAllText(@"C:\Users\Act-On Giveaway\Desktop\Log.txt", number);

            using (StreamWriter file = new StreamWriter(@"C:\Users\Act-On Giveaway\Desktop\Log.txt", true))//Prints the text file back to the user.
            {
                file.WriteLine("\n" + number);
            }

            Console.Read();
        }
    }
}