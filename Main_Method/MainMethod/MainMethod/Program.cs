using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Test myObj = new Test();//instantiate the class 

            int result1 = myObj.add(19);
            Console.WriteLine(result1);

            int result2 = myObj.add(1.9m);
            Console.WriteLine(result2);

            int result3 = myObj.add("10");
            Console.WriteLine(result3);
            Console.ReadLine();

            
        }

    }
}
