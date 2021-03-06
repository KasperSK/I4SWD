﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardgame.Cards
{
    public class YellowCard : ICard
    {
        private readonly int _suit;

        public YellowCard(int val)
        {
            Value = val;
            _suit = 4;
            Suit = "Yellow";
        }
        public int Value { get; set; }
        public string Suit { get; private set; }

        public int CardValue()
        {
            return _suit * Value;
        }
    }
}
