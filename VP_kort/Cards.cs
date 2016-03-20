using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_kort
{
    public enum Suit {Diamonds, Hearts, Clubs, Spades};

    public class Card
    {
        public Suit CardSuit { get; set; }
        public int Rank { get; set; }

        public Card() { }

        public Card(Suit suit, int rank)
        {
            CardSuit = suit;
            Rank = rank;
        }
    }
}
