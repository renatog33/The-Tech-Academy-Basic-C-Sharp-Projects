using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            const int year = 1977;//#1 Create a const variable.

            var nickname = "The Blazers"; //#2 Create a variable using the keyword “var.”

            MyClass ripcity = new MyClass(); //#3 Chain two constructors together.
            Console.WriteLine(ripcity.nbaTeam + " are known as \"{0}\" and won a Championship in {1}.", nickname, year);
            Console.ReadLine();

        }
    }
}
