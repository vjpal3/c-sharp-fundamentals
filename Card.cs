using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Card
    {
        private string suit;
        private int value;

        public string Suit { get => suit; set => suit = value; }
        public int Value { get => value; set => this.value = value; }

        public Card(string suit, int value) // for static card
        {
            this.Suit = suit;
            this.Value = value;
        }

        public static Card GetCard(Card currentCard)
        {
            int min = 2;
            int max = 15;
            var suits = new string[4] {"heart", "spade", "club", "diamond" };
            Card nextCard;
            do
            {
                Random rand = new Random();
                nextCard = new Card(suits[rand.Next(0, 4)], rand.Next(min, max));

            } while ((nextCard.Value != currentCard.Value) && (nextCard.Suit != currentCard.Suit));

            Console.WriteLine("Randomly picked card: " + nextCard.Value + " " + nextCard.Suit);
            return nextCard;
        }


    }
}
