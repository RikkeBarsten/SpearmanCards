using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_kort
{
    public static class Spearman
    {
        public static double RankCorrelation(List<Card> sorted, List<Card> shuffeled)
        {

            // Check if both list contains 52 cards
            if (sorted.Count == 52 && shuffeled.Count == 52)
            {

                int diff = 0;
                int diffSquared = 0;
                

                // For each card, add rank difference
                for (int i = 0; i < 52; i++)
                {
                    Card toBeCompared = new Card();
                    toBeCompared = sorted.ElementAt<Card>(i);
                                                        
                    diff = i - shuffeled.FindIndex(c => c.CardSuit == toBeCompared.CardSuit && c.Rank == toBeCompared.Rank);
                    diffSquared += diff * diff;
                   
                }

                int numerator = 6 * diffSquared;
                int denominator = sorted.Count * ((sorted.Count * sorted.Count) - 1);

                double rho = 1 - (numerator / denominator);

                return rho;
            }
            else
                return 2;
        }
    }
}
