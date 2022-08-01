using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program to capture daily report (DR) for students of The Tech Academy.
            Console.WriteLine("The Tech Academy.\nStudent Daily Report");
            Console.WriteLine("What is your name?");//Ask for student's name
            string yourName = Console.ReadLine();//save Student's Name
            

            Console.WriteLine("What course are you on?");//Ask for course name
            string courseName = Console.ReadLine();//save course name
            

            Console.WriteLine("What page number?");//Ask for course page number.
            string coursePage = Console.ReadLine();//save course page number as string.
            ushort page = Convert.ToUInt16(coursePage);//convert and save course page number as ushort type.

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");//Ask if they need help..
            string needHelp = Console.ReadLine();//save as string.
            bool help = Convert.ToBoolean(needHelp);//convert and save course page number as boolean value.

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");//Ask for positive experiences.
            string positiveFeedback = Console.ReadLine();//save positive feedback

            Console.WriteLine("Is there any other feedback you’d like to provide ? Please be specific.");//Ask for other feedback..
            string otherFeedback = Console.ReadLine();//save other feedback

            Console.WriteLine("How many hours did you study today?");//Ask for number of hours studied today.
            string hoursStudied = Console.ReadLine();//save hours studied number as string.
            float hours = Convert.ToSingle(hoursStudied);//save and convert hours studied as float type.

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");//End of the progra

        }
    }
}
