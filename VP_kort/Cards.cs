using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_kort
{
    enum Suit {Diamonds, Hearts, Clubs, Spades};

    class Card
    {
        public Suit CardSuit { get; set; }
        public int Value { get; set; }
    }
}
