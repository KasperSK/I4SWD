using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoStuff
{
    public interface IDoThings
    {
        void DoNothing();
        int DoSomething(int number);
        string DoSomethingElse(string input);
    }

    public class DoHickey : IDoThings
    {
        public void DoNothing()
        {
            System.Console.WriteLine("DoHickey::DoNothing()");
        }

        public int DoSomething(int number)
        {
            System.Console.WriteLine("DoHickey::DoSomething(): " + number);
            return number;
        }

        public string DoSomethingElse(string input)
        {
            System.Console.WriteLine("DoHickey::DoSomethingElse(): " + input);
            return input;
        }
    }

    public class DoDickey : IDoThings
    {
        public void DoNothing()
        {
            System.Console.WriteLine("DoDickey::DoNothing()");
        }

        public int DoSomething(int number)
        {
            System.Console.WriteLine("DoDickey::DoSomething(): " + number);
            return number;
        }

        public string DoSomethingElse(string input)
        {
            System.Console.WriteLine("DoDickey::DoSomethingElse(): " + input);
            return input;
        }
    }
}
