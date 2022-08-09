using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Input a number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input another number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                MathOperation Mult = new MathOperation();//In the Main() method of the console app, instantiate the class.
                Mult.Math(num1, num2);

                Console.ReadLine();
            }
        }   
}
