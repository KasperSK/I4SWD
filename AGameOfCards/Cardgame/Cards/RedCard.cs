using System.Xml.Schema;

namespace Cardgame.Cards
{
    public class RedCard : ICard
    {
        private readonly int _suit;
        public RedCard(int val)
        {
            Value = val;
            _suit = 1;
        }
        public int Value { get; set; }

        public int CardValue()
        {
            return _suit * Value;
        }
    }
}