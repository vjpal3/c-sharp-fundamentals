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
            //Console.WriteLine(BestHand.findBestHand(new Hand("Player1", rand), new Hand("Player2", rand)));

            var deck = new Deck();
            deck.shuffle(rand);
            Card card1 = deck.drawCard(rand);
            Console.WriteLine(card1.Suit + " # " + card1.Value);

            Card card2 = deck.drawCard(rand);
            Console.WriteLine(card2.Suit + " # " + card2.Value);

        }

    }
}
