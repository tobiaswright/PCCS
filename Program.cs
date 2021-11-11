using System;

namespace PCCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Deck
    {
        public Deck()
        {
            CardSet = new List<Card>();
            for (int i = 0; i < 4; i++)         //Suit values 0-3 (0-clubs, 1-diamonds, 2-hearts, 3-spades)
            {
                for (int j = 1; j < 14; j++)    //Card values 1-13 (values ordered from 2 to Ace, Ace is high)
                {
                    CardSet.Add(new Card(i, j));
                }
            }
        }
    }

        public enum CardSuit
    {
        Clubs = 0,
        Diamonds = 1,
        Hearts = 2,
        Spades = 3,
    }
    //Card Values - Assuming that Ace is high
    public enum CardValue
    {
        two = 1,
        three = 2,
        four = 3,
        five = 4,
        six = 5,
        seven = 6,
        eight = 7,
        nine = 8,
        ten = 9,
        jack = 10,
        queen = 11,
        king = 12,
        ace = 13,
    }

    public enum CardJokers
    {
        LittleJoker,
        BigJoker
    }
}
