using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_kort
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();

            List<Card> testDeck = newDeck.Cards;

            foreach (Card card in testDeck)
            {
                Console.WriteLine("Suit: {0} - Value: {1}", card.CardSuit, card.Value);
            }

            Console.ReadKey();
        }
    }
}
