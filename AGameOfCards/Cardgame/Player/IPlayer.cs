using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardgame.Cards;

namespace Cardgame.Player
{
    public interface IPlayer
    {
        string Name { get; set; }
        void ShowTotalValue();
        void ShowHand();
        void ReceiveCard(ICard card);

    }
}
