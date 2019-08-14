using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CardPicker.ProcessRound(new Card("heart", 10), "low"));

            //create Random object once to get different random values.
            Random rand = new Random();            
            var deck = new Deck();
            deck.shuffle(rand);
            var result = BestHand.FindBestHand(new Hand("Player1", 5, deck, rand), new Hand("Player2", 5, deck, rand));
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
