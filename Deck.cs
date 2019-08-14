using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Deck
    {
        private Card[] cards = new Card[52];
        private IEnumerable<Card> shuffledCards;
        private static string[] suits = new string[4] { "heart", "spade", "club", "diamond" };
        private static int[] values = new int[13] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        internal Card[] Cards { get => cards; set => cards = value; }

        public Deck()
        {            
            //populate the deck
            int k = 0;
            for(int i=0; i < suits.Length; i++)
            {
                for(int j=0; j < values.Length; j++)
                {
                    cards[k] = new Card(suits[i], values[j]);                 
                    k++;
                }
            }
        }

        public void shuffle(Random rand)
        {
            shuffledCards = cards.OrderBy(card => rand.Next());         
        }

        //Draw a card and remove it from the deck
        public Card DrawCard(Random rand)
        {
            int min = 2;
            int max = 15;

            var randSuit = suits[rand.Next(0, 4)];
            var randVal = rand.Next(min, max);
            var nextCard = shuffledCards.Single(card => card.Suit == randSuit && card.Value == randVal);

            var remainingDeck = shuffledCards.ToList(); // Get IEnumerable as List

            remainingDeck.Remove(remainingDeck.First(card => card.Suit == nextCard.Suit && card.Value == nextCard.Value)); // Remove the card that is drawn

            shuffledCards = remainingDeck; // Assign the deck of remaining cards to the shuffledCards.

            //foreach (Card card in shuffledCards)
            //    Console.WriteLine(card.Value + " ** " + card.Suit);

            return nextCard;
        }
    }
}
