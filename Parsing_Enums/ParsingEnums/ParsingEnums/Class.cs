using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Class
    {
        public DaysOfTheWeek Day { get; set; }
    }
    public enum DaysOfTheWeek //#1 Create an enum for the days of the week.
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}