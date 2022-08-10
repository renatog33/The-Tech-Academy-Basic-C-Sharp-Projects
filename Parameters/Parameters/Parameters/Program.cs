using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee<string> name = new Employee<string>(); //#3 Instantiate an Employee object with type “string” as its generic parameter.
            name.Things = new List<string>() { "Lott", "Montana", "Rice"};//#3 Assign a list of strings as the property value of Things.

            // creating generic class with type "int" and assigning collection of "ing" values
            // to list
            Employee<int> number = new Employee<int>();//#4 Instantiate an Employee object with type “int” as its generic parameter.
            number.Things = new List<int>() { 42, 16, 80 };//#4 Assign a list of integers as the property value of Things.

           
            foreach (string p in name.Things) //#5 Create a loop that prints all of the Things to the Console.
            {
                Console.WriteLine(p);
            }
           
            foreach (int i in number.Things)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
