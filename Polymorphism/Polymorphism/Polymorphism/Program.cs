using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            employee.SayName();
            Console.ReadLine();

            IQuittable x = new Employee();

            x.Quit(employee);
            Console.ReadLine();
        }
    }
}
