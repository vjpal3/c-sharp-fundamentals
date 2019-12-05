using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Algorithms
{
    class GuessHighLowCard
    {
        public enum Guesses { low, high }

        public static string ProcessRound(Deck deck, Random rand)
        {
            //var guess = (int)(Guesses)Enum.Parse(typeof(Guesses), strGuess.ToLower());
            var currentCard = deck.DrawCard(rand);
           

            Console.WriteLine("Current Card: {0}, {1}", currentCard.Value, currentCard.Suit);
            Console.WriteLine("Guess Next Card - Type high or low: ");
            var strGuess = Console.ReadLine();
            var guess = (int)(Guesses)Enum.Parse(typeof(Guesses), strGuess.ToLower());

            var nextCard = deck.DrawCard(rand);
            Console.WriteLine("Next Card: {0}, {1}", nextCard.Value, nextCard.Suit);
            //Console.WriteLine("Guess: " + strGuess);
            //Console.WriteLine();
             
            if (currentCard.Value == nextCard.Value)
                return "Draw";

            switch (guess)
            {
                case 0:
                    return IsGreater(currentCard, nextCard) ? "Loss" : "Win";
                case 1:
                    return IsGreater(currentCard, nextCard) ? "Win" : "Loss";
            }
            return "Error";
        }

        public static bool IsGreater(Card currentCard, Card nextCard)
        {
            return nextCard.Value > currentCard.Value;
        }
    }
}
