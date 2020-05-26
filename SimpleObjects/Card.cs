using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleObjects
{
    class Card
    {
        string rank;
        string suit;
        int val;

        /// <summary>
        /// Create s Card object with the given card rank and suit.
        /// </summary>
        /// <param name="rank">A, K, Q, J, 10, 9...2</param>
        /// <param name="suit">club, spade, heart, or diamond (♣♠♥♦)</param>
        /// <param name="val">1,2,3,4,5,6,7,8,910,11,12,13,14</param>
        public Card(string rank, string suit, int val)
        {
            this.Rank = rank;
            this.Suit = suit;
            this.Val = val;
        }

        public string Rank { get => rank; set => rank = value; }
        public string Suit { get => suit; set => suit = value; }
        public int Val { get => val; set => val = value; }

        public override string ToString()
        {
            return Rank + " " + Suit;
        }
    }
}
