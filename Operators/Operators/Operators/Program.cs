using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee object1 = new Employee() { Id = 1, FirstName = "John", LastName = "Doe"};

            Employee object2 = new Employee() { Id = 2, FirstName = "Jane", LastName = "Doe" };


            Console.WriteLine("Do the two employees share the same Id number?:\n" + (object1 == object2));
            Console.ReadLine();
            
        }
    }
}

