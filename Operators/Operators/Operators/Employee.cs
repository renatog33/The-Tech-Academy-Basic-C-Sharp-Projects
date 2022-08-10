using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Employee //#1 Create an Employee class with Id, FirstName and LastName properties.
    {
        public int Id { get; set;  }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee object1, Employee object2)//#2 In the Employee class,
       //overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
        {
            bool compare = (object1.Id == object2.Id);
            return compare;
        }
        public static bool operator !=(Employee object1, Employee object2)//#2Remember that comparison operators must be overloaded in pairs
        {
            bool compare = (object1.Id != object2.Id);
            return compare;
        }
    }
}