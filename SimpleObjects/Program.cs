using System;
using System.Collections.Generic;

namespace SimpleObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Book cLang = new Book(120, "The C Programming Language",
                                        "Kernighan and Ritchey", "How I learned to program in 'C'");
            Console.WriteLine($"Written By: {cLang.Author}: {cLang.Title} changed my life");
            cLang.Pages = 228;
            Console.WriteLine(cLang);
            //  BuildACardDeck();
        }   //  end of Main

        public static void BuildACardDeck()
        {
            // print the special characters
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Card card;                      //  declare a Card variable
            card = new Card("A", "♦", 14);  //  creating a Card (instantiating)
            Console.WriteLine(card);

            List<Card> deck = new List<Card>();     //  creating an empty Card List

            // the value of v:  0    1    2    3    4    5    6    7    8     9    10   11   12
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suits = { "♥", "♦", "♣", "♠" };
            foreach (var suit in suits)                         //  do this 4 times
            {
                for (int v = 0; v < ranks.Length; v++)          //  do this 13 times
                {
                    //  deck.Add(new Card(ranks[v], suit, v + 2));

                    card = new Card(ranks[v], suit, v + 2);     //  so this happens 52 = 4 x 13 times
                    deck.Add(card);
                }
            }

            Random rnd = new Random();                          //  create a random number generator
            deck = deck.OrderBy(card => rnd.Next()).ToList();   //  order the deck randomly

            deck.ForEach(card => Console.WriteLine(card));      //  the deck is now shuffled

            var hand = deck.Take(5).ToList();                   //  deal 5 cards
            deck.RemoveAll(hand.Contains);                      //  remove all 5 cards from the deck
        }   //  end of BuildACardDeck
    }
}
