using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Polymorphism
{
    interface IQuittable //#1 Create an interface called IQuittable and have it define a void method called Quit().
    {
        void Quit(Person person);
    }
}
