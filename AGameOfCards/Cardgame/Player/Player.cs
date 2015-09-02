using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardgame.Cards;

namespace Cardgame.Player
{
    class Player : IPlayer
    {
        private List<ICard> _hand;
         
        public string Name { get; set; }

        public Player(String name)
        {
            _hand = new List<ICard>();
            Name = name;
        }
        public void ShowTotalValue()
        {
            int TotalValue = 0;
            foreach (var card in _hand)
            {
                TotalValue += card.CardValue();
            }
            Console.WriteLine("Player {0}'s hand has a total value of {1}", Name, TotalValue);
        }

        public void ShowHand()
        {
            Console.WriteLine("Player {0}'s hand: ", Name);
            foreach (var card in _hand)
            {
                Console.Write(card.Suit);
                Console.Write(" ");
                Console.Write(card.Value);
                Console.Write("\n");
            }
        }

        public void ReceiveCard(ICard card)
        {
            _hand.Add(card);
        }
    }
}
