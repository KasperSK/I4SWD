using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardgame.Cards
{
    public class GreenCard : ICard
    {
        private readonly int _suit;
        public GreenCard(int val)
        {
            Value = val;
            _suit = 3;
            Suit = "Green";
        }
        public int Value { get; set; }
        public string Suit { get; private set; }

        public int CardValue()
        {
            return _suit*Value;
        }
    }
}
