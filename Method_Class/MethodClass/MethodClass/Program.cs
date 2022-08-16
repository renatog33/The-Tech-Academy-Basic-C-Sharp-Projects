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
                MathOperation Mult = new MathOperation();//In the Main() method of the console app, instantiate the class.
                Mult.Math(num2: 10, num1: 5);//Call the method in the class, specifying the parameters by name.
                                             //note that named parameters allows you to switch up the sequence
                Mult.Math(5, 10);//#3

            Console.ReadLine();
            }
        }   
}
