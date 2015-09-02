using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardgame.Cards;
using Cardgame.Player;

namespace Cardgame.Deck
{
    public class Deck
    {
        private List<ICard> _deck;

        public Deck(int antalKort)
        {
            _deck = new List<ICard>();
            for (var i = 1; i <= antalKort ; i++)
            {
                _deck.Add(new RedCard(i));
                _deck.Add(new BlueCard(i));
                _deck.Add(new GreenCard(i));
                _deck.Add(new YellowCard(i)); 
            }
        }

        public void DealToPlayer(IPlayer acutalPlayer, int cards)
        {
            Random dealRandom = new Random();
            for (int i = 0; i < cards; i++)
            {
                var dealIndex = dealRandom.Next(8);
                acutalPlayer.ReceiveCard(_deck[dealIndex]);
                _deck.Remove(_deck[dealIndex]);
            }
        }
        
    }
}
