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

            Console.WriteLine("Spearman when reversed (-1 expected): {0:n3}", rho);

            //Creating deck to test FY shuffle method
            Deck shuffled2 = new Deck();
            shuffled2.FYShuffle();

            double rho2 = Spearman.Rho(sorted.Cards, shuffled2.Cards);

            Console.WriteLine("Spearman when FY-shuffled (0 expected): {0:n3}", rho2);


            // Creating deck to test Guid Shuffle
            Deck shuffled3 = new Deck();
            shuffled3.GuidShuffle();

            double rho3 = Spearman.Rho(sorted.Cards, shuffled3.Cards);

            Console.WriteLine("Spearman when Guid-shuffled (0 expected): {0:n3}", rho3);


            //Creating deck with extra card, to check exception throwing
            Deck errorDeck = new Deck();
            errorDeck.Cards.Add(new Card(Suit.Diamonds, 13));

            Console.WriteLine("Calling Rho-method with uneven decks - exception expected:");

            try
            {
                double rho4 = Spearman.Rho(sorted.Cards, errorDeck.Cards);
                Console.WriteLine("Rho errordeck: {0}", rho4.ToString());
            }
            catch (ArgumentException errA)
            {
                Console.WriteLine("Exception message: {0}", errA.Message);
            }


            // Creating lists of return values from rho-method, to check for result when 
            // shuffling more decks at once:

            List<double> FYShuffles = new List<double>();

            for (int i = 0; i < 10; i++)
            {
                Deck newShuffle = new Deck();
                newShuffle.FYShuffle();
                FYShuffles.Add(Spearman.Rho(sorted.Cards, newShuffle.Cards));
            }

            List<double> GuidShuffles = new List<double>();

            for (int i = 0; i < 10; i++)
            {
                Deck newShuffle = new Deck();
                newShuffle.GuidShuffle();
                GuidShuffles.Add(Spearman.Rho(sorted.Cards, newShuffle.Cards));
            }

            Console.WriteLine("Ten FYshuffles: ");

            foreach (var r in FYShuffles)
            {
                Console.WriteLine("{0:n3}", r);
            }

            Console.WriteLine("Ten Guid shuffles: ");

            foreach (var r in GuidShuffles)
            {
                Console.WriteLine("{0:n3}", r);
            }


            Console.ReadKey();
        }
    }
}
