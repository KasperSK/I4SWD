using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardgame.Cards
{
    public interface ICard
    {

        int Value { get; set; }
        string Suit { get; }
        int CardValue();
    }
}
