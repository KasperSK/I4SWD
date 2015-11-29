using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMachineSwitchCase;
using StateMachineGoF;

namespace FlashLightRunner
{
    class Program
    {
        static void Main(string[] args)
        {
//            FlashLightSwitchCase Fl = new FlashLightSwitchCase();
            FlashLightContext Fl = new FlashLightContext();

            var C = Console.ReadKey(true);
            while (C.KeyChar != 'q')
            {
                if(C.KeyChar == 'o')
                    Fl.EventPower();
                C = Console.ReadKey(true);
            }
        }
    }
}
