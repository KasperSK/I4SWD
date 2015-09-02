using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardgame.Cards;

namespace Cardgame.Player
{
    public class WeakPlayer : IPlayer
    {
        private List<ICard> _hand;

        public string Name { get; set; }

        public WeakPlayer(String name)
        {
            _hand = new List<ICard>();
            Name = name;
        }
        public int ShowTotalValue()
        {
            int TotalValue = _hand.Sum(card => card.CardValue());
            Console.WriteLine("Player {0}'s hand has a total value of {1}", Name, TotalValue);
            return TotalValue;
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
            if (_hand.Count() > 3)
            {
                _hand.RemoveAt(0);
            }
        }
    }
}
