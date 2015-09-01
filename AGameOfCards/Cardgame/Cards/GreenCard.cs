﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardgame.Cards
{
    class GreenCard : ICard
    {
        private readonly int _suit;
        GreenCard(int val)
        {
            Value = val;
            _suit = 3;
        }
        public int Value { get; set; }
        public int CardValue()
        {
            return _suit*Value;
        }
    }
}