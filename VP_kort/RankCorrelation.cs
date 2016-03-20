using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_kort
{
    public static class Spearman
    {
        public static double Rho(List<Card> sorted, List<Card> shuffled)
        {

            // Check if both list are of equal size
            if (sorted.Count == shuffled.Count)
            {

                // Declare and initialize diffs to be used in calculation
                int diff = 0;
                int diffSquared = 0;


                // For each card, add rank difference
                for (int i = 0; i < sorted.Count; i++)
                {
                    Card toBeCompared = new Card();
                    //Find the card at element i in sorted list
                    toBeCompared = sorted.ElementAt(i);

                    // Calulate diff between i and index of the same card in shuffeled deck                                    
                    diff = i - shuffled.FindIndex(c => c.CardSuit == toBeCompared.CardSuit && c.Rank == toBeCompared.Rank);

                    // Add the diff squared to the diffsquared variable
                    diffSquared += diff * diff;
                }

                // Setting up the numerator and denominater
                int numerator = 6 * diffSquared;
                int denominator = sorted.Count * ((sorted.Count * sorted.Count) - 1);

                // Calculate the Spearman Coefficient (rho)
                double rho = 1.0 - ((double)numerator / (double)denominator);

                return rho;
            }
            else
                // If decks are not complete
                //return 2;

                //replace with throw argument out of range exception
                throw new ArgumentException("The two decks are not of equal size");
        }
    }
}
