using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person //#3 Create another class called Employee and have it inherit from the Person class.
    {
        public override void SayName()//#4 Implement the SayName() method inside of the Employee class.
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }    
    }
}
