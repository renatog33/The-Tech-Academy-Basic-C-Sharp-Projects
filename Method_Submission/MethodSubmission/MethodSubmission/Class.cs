using System;
using System.Collections.Generic;
using System.Text;

namespace MethodSubmission
{
    public class Class
    {
        public int Add(int input1, int input2=0)//second integer will be optional, will default to 0 to be used only the first integer is passed
        {
            int sum = input1 + input2 + 100;//do a math operation and return an integer result
            return sum;
        }
    }
}
