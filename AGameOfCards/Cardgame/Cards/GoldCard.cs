using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardgame.Cards
{
    class GoldCard : ICard
    {
        public int Value { get; set; }
        private int _suit;
        public string Suit { get; private set; }

        public GoldCard(int val)
        {
            Value = val;
            _suit = 5;
            Suit = "Gold";
        }
        public int CardValue()
        {
            return _suit * Value;
        }
    }
}
