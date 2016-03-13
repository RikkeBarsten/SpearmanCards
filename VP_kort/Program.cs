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
            Deck sorted = new Deck();

            
            foreach (Card card in sorted.Cards)
            {
                Console.WriteLine("Suit: {0} - Value: {1}", card.CardSuit, card.Rank);
            }

            Deck shuffled1 = new Deck();
            shuffled1.Cards.Reverse();

            foreach (Card card in shuffled1.Cards)
            {
                Console.WriteLine("Suit: {0} - Value: {1}", card.CardSuit, card.Rank);
            }

            double rho = Spearman.Rho(sorted.Cards, shuffled1.Cards);

            Console.WriteLine("Spearman when reversed (-1 expected): {0}", rho);


            Console.ReadKey();
        }
    }
}
