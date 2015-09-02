using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardgame.Cards
{
    public class BlueCard : ICard
    {
        private readonly int _suit;

        public BlueCard(int val)
        {
            Value = val;
            _suit = 2;
            Suit = "Blue";
        }
        public int Value { get; set; }
        public string Suit { get; private set; }
        public int CardValue()
        {
            return Value * _suit;
        }
    }
}
