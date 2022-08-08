using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a number to do a math operation on");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            int result1 = Test.add(userNumber);
            Console.WriteLine(result1);

            int result2 = Test.subtract(userNumber);
            Console.WriteLine(result2);

            int result3 = Test.multiply(userNumber);
            Console.WriteLine(result3);
            Console.ReadLine();
        }
        
    }
}
