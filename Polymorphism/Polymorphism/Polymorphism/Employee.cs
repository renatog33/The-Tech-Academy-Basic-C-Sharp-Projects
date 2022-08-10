using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee : Person, IQuittable //#2 Have your Employee class from the previous drill inherit that interface
    //and implement the Quit() method in any way you choose.
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit(Person person)
        {
            Console.WriteLine("This perosn has quit.");
        }
    }
}
