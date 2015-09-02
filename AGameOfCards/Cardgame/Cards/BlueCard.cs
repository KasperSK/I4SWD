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
        }
        public int Value { get; set; }
        public int CardValue()
        {
            return Value * _suit;
        }
    }
}
