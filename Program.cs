using System;
using System.Collections.Generic;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var cards = new List<string>() { "Ace of Hearts", "Two of Hearts", "Three of Hearts", "Four of Hearts", "Five of Hearts", "Six of Hearts", "Seven of Hearts", "Eight of Hearts", "Nine of Hearts", "10 of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts", "Ace of Diamonds", "Two of Diamonds", "Three of Diamonds", "Four of Diamonds", "Five of Diamonds", "Six of Diamonds", "Seven of Diamonds", "Eight of Diamonds", "Nine of Diamonds", "10 of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds", "Ace of Clubs", "Two of Clubs", "Three of Clubs", "Four of Clubs", "Five of Clubs", "Six of Clubs", "Seven of Clubs", "Eight of Clubs", "Nine of Clubs", "10 of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs", "Ace of Spades", "Two of Spades", "Three of Spades", "Four of Spades", "Five of Spades", "Six of Spades", "Seven of Spades", "Eight of Spades", "Nine of Spades", "10 of Spades", "Jack of Spades", "Queen of Spades", "King of Spades" };

            var n = 52;

            for (var firstIndex = n - 1; firstIndex >= 1; firstIndex--)

            {
                Random rnd = new Random();
                var secondIndex = rnd.Next(firstIndex);

                var firstValue = cards[firstIndex];
                var secondValue = cards[secondIndex];

                cards[firstIndex] = secondValue;
                cards[secondIndex] = firstValue;
            }

            Console.WriteLine(cards[0]);
            Console.WriteLine(cards[1]);
        }
    }
}








