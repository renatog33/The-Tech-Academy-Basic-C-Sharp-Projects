using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    
    public class MathOperator
    {
        public void Div(int i)  //#1 Create a class. In that class, create a void method that
        //outputs an integer. Have the method divide the data passed to it by 2.
        {
            Console.WriteLine("Your number divided by 2 is " + i / 2);
        }
        public void Div(int a, out int b)//# 4-5 Create a method with output parameters. Add 1000 to imput number.
        {
            b = a + 1000;
        }
    }
}
