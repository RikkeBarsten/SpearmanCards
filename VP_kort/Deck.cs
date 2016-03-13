using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_kort
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (int i = 1; i <= 13; i++)
                {
                    Card card = new Card();
                    card.CardSuit = suit;
                    card.Rank = i;
                    Cards.Add(card);
                }
            }
        }

        
    }
}
