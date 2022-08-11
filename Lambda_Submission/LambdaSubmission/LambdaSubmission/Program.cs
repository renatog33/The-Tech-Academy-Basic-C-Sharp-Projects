
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()//#2 In the Main() method, create a list of at least 10 employees.
            //At least two employees should have the first name “Joe”.
            {
                new Employee {First_Name = "Joe", Last_Name = "Montana", Id = 1},
                new Employee {First_Name = "Joe", Last_Name = "Theismann", Id = 2},
                new Employee {First_Name = "Tom", Last_Name = "Brady", Id = 3},
                new Employee {First_Name = "Peyton", Last_Name = "Manning", Id = 4},
                new Employee {First_Name = "Steve", Last_Name = "Young", Id = 5},
                new Employee {First_Name = "Eli", Last_Name = "Manning", Id = 6},
                new Employee {First_Name = "Baker", Last_Name = "Mayfield", Id = 7},
                new Employee {First_Name = "Matt", Last_Name = "Stafford", Id = 8},
                new Employee {First_Name = "Patrick", Last_Name = "Mahomes", Id = 9},
                new Employee {First_Name = "Joe", Last_Name = "Namath", Id = 10}
            };

            List<Employee> newList = new List<Employee>(); //#3Using a foreach loop, create a new list of all
            //employees with the first name “Joe”.
            foreach (Employee employee in employees)
            {
                if (employee.First_Name == "Joe")//In your comparison statement, remember to reference the property of the object you are checking.
                {
                    newList.Add(employee);
                }
            }

            foreach (Employee a in newList)
            {
                Console.WriteLine(a.First_Name +" "+ a.Last_Name);
            }
            Console.ReadLine();

            List<Employee> lambdaList = employees.Where(x => x.First_Name == "Joe").ToList();//#4
            //Perform the same action again, but this time with a lambda expression.

            foreach (Employee b in lambdaList)
            {
                Console.WriteLine(b.First_Name + " " + b.Last_Name);
            }
            Console.ReadLine();

            List<Employee> IdList = employees.Where(x => x.Id > 5).ToList();//#5
            //Using a lambda expression, make a list of all employees with an Id number greater than 5.

            foreach (Employee c in IdList)
            {
                Console.WriteLine(c.First_Name + " " + c.Last_Name +" is Id: " +c.Id);
            }
            Console.ReadLine();
        }
    }
}