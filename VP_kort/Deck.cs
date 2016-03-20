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

        // Initalized and create sorted deck of cards in default constructor
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

        // First Fisher-Yates Shuffle
        public void FYShuffle()
        {
            Random random = new Random();

            for (int i = Cards.Count -1; i > 0; --i)
            {
                int j = random.Next(i-1);
                Card temp = Cards[i];
                Cards[i] = Cards[j];
                Cards[j] = temp;    
            }
        }

        // Second Fisher-Yates Shuffle according to Jeff Atwood: http://blog.codinghorror.com/shuffling/
        public void GuidShuffle()
        {
            var shuffledCards = Cards.OrderBy(a => Guid.NewGuid());
            Cards = (List<Card>)shuffledCards;
        }


    }
}
