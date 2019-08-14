using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BestHand
    {      
        public static string FindBestHand(Hand hand1, Hand hand2)
        {
            Console.WriteLine("Player1 Cards:");
            foreach (Card card in hand1.Cards)
                Console.WriteLine(card.Value + " # " + card.Suit);
            Console.WriteLine();
            Console.WriteLine("Player2 Cards:");
            foreach (Card card in hand2.Cards)
                Console.WriteLine(card.Value + " ## " + card.Suit);
            Console.WriteLine();
            var score = 0;
            for (int i = 0; i < hand1.Number; i++)
            {
                //If score is positive, Player 1 wins, if negative player 2 wins else draw
                score += hand1.Cards[i].Value;
                score -= hand2.Cards[i].Value;
            }
            string result = score > 0 ? hand1.HandName : score == 0 ? "Draw" : hand2.HandName;
            return result =  result == "Draw" ? "Draw" : result + " Wins";
        }
    }
}
