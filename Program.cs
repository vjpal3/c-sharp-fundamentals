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
            //var arr = new int[3, 3] {
            // { 1, 2, 3 },
            // { 4, 5, 6},
            // { 7, 8, 9 }

            // };
            // var sum = 0;
            // var rowCount = 0;
            // for (var i = 0; i < 3; i++)
            // {

            //     var colCount = 0;
            //     for (var j = 0; j < 3; j++)
            //     {
            //         if (!(rowCount == 1 && colCount != 1))
            //         {
            //             Console.WriteLine(arr[i, j]);
            //             sum += arr[i, j];
            //         }


            //         colCount++;
            //     }
            //     rowCount++;

            // }
            // Console.WriteLine(sum);

            //Run the code to play Deck Racer
            //var rand = new Random();
            //var racer = new DeckRacer();
            //Console.WriteLine(racer.StartGame(rand));

            //var racerDeck = new Deck(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            //var die = new DynamicDie(6);
            //racerDeck.Shuffle(rand);
            //racerDeck.ShowDeck();
            //racerDeck.ValidateDeck(rand);
            //Console.WriteLine("Showing deck after validating");
            //racerDeck.ShowDeck();

            //Run the code for D&D Game
            //var rand = new Random();
            //var die = new DynamicDie(20);
            //new DDGame().StartGame(die, 5, rand);


            //Run the code to play Yahtzee          
            //var rand = new Random();
            //var yahtzee = new Yahtzee(5, 6);
            //yahtzee.StartGame(3, rand);

            //Run the code for Guessing a card high or low
            //create Random object once to get different random values.
            Random rand = new Random();
            var deck = new Deck();
            deck.shuffle(rand);
            Console.WriteLine(GuessHighLowCard.ProcessRound(deck, rand));

            //Run the code for finding best hand
            //Random rand = new Random();            
            //var deck = new Deck();
            //deck.shuffle(rand);
            //var result = BestHand.FindBestHand(new Hand("Player1", 5, deck, rand), new Hand("Player2", 5, deck, rand));
            //Console.WriteLine(result);
            //Console.WriteLine();
        }
    }
}
