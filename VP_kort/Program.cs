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

            
            //foreach (Card card in sorted.Cards)
            //{
            //    Console.WriteLine("Suit: {0} - Value: {1}", card.CardSuit, card.Rank);
            //}
            //Console.WriteLine();

            Deck shuffled1 = new Deck();
            shuffled1.Cards.Reverse();

            double rho = Spearman.Rho(sorted.Cards, shuffled1.Cards);

            Console.WriteLine("Spearman when reversed (-1 expected): {0}", rho);

            Deck shuffled2 = new Deck();
            shuffled2.FYShuffle();

            double rho2 = Spearman.Rho(sorted.Cards, shuffled2.Cards);

            Console.WriteLine("Spearman when FY-shuffled (0 expected): {0}", rho2);

            //Creating deck with extra card, to check exception casting
            Deck errorDeck = new Deck();
            errorDeck.Cards.Add(new Card(Suit.Diamonds, 13));

            Console.WriteLine("Calling Rho-method with uneven decks - exception expected:");

            try
            {
                double rho3 = Spearman.Rho(sorted.Cards, errorDeck.Cards);
                Console.WriteLine("Rho errordeck: {0}", rho3.ToString());
            }
            catch (ArgumentException errA)
            {
                Console.WriteLine("Exception message: {0}", errA.Message);
            }

           
            Console.ReadKey();
        }
    }
}
