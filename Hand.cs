using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Hand
    {
        private List<int> cards = new List<int>();
        private int number;
        private string handName;

        public List<int> Cards { get => cards; set => cards = value; }
        public int Number { get => number; set => number = value; }
        public string HandName { get => handName; set => handName = value; }
        
        public Hand(string handName, Random rand)
        {
            int min = 2;
            int max = 15;
            this.Number = 7;
            this.HandName = handName;
            
            for (int i=0; i < this.Number; i++)
            {              
                this.Cards.Add(rand.Next(min, max));
            }
         
        }       
    }
}
