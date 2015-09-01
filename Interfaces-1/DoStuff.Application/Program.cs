using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoStuff.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            IDoThings myStuff = new DoStuff.DoHickey();
            myStuff.DoNothing();
            myStuff.DoSomething(4);
            myStuff.DoSomethingElse("This is a string");

            myStuff = new DoStuff.DoDickey();
            myStuff.DoNothing();
            myStuff.DoSomething(4);
            myStuff.DoSomethingElse("This is a string");

        }
    }
}
