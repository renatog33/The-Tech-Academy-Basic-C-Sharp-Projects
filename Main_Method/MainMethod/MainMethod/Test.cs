using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethod
{
    public class Test
    {
        public int add(int input)//Method #1
        //In that class, create a method that will take in an integer, create a math 
        //operation for this integer (addition, subtraction, etc.), then return the answer as an integer.
        {
            return input + 5;
        }

        public int add(decimal input)//Method #2
        {
            return Convert.ToInt32(input - 5);
        }

        public int add(string input)//Method #2
        {
            return Convert.ToInt32(input) * 10;
        }
    }
}
