using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardgame = Cardgame.Cardgame;

namespace AGameOfCards.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            global::Cardgame.Cardgame thisCardgame = new global::Cardgame.Cardgame();
            thisCardgame.GameLoop();
            Console.ReadKey();
        }
    }
}
