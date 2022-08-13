using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    public class MyClass
    {
        public string nbaTeam;
        public MyClass() : this("The Portland Trailblazers")
        {
        }
        public MyClass(string team)
        {
            nbaTeam = team;
        }
    }
}