using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Hand
    {
        private List<Card> cards = new List<Card>();
        private int number;
        private string handName;

        public List<Card> Cards { get => cards; set => cards = value; }
        public int Number { get => number; set => number = value; }
        public string HandName { get => handName; set => handName = value; }


        
        public Hand(string handName, int numberOfCards, Deck deck, Random rand)
        {
            this.Number = numberOfCards;
            this.HandName = handName;
            for(int i=0; i < Number; i++)
            {
                cards.Add(deck.DrawCard(rand));
            }            
        }       
    }
}
