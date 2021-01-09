using System;
using System.Collections.Generic;

namespace NewBlackjackCS
{
    class Program
    {
        class Player
        {
            public List<Card> PlayerHand;
            public int PlayerHandValue()
            {
                var handCount = 0;
                foreach (var cardInHand in PlayerHand)
                {
                    handCount = handCount + cardInHand.Value();
                }
                return handCount;
            }
        }
        class Card
        {
            public string Face { get; set; }
            public string Suits { get; set; }
            public int Value()
            {
                var answer = 0;
                switch (Face)
                {
                    case "2 of ":
                        answer = 2;
                        break;
                    case "3 of ":
                        answer = 3;
                        break;

                    case "4 of ":
                        answer = 4;
                        break;

                    case "5 of ":
                        answer = 5;
                        break;
                    case "6 of ":
                        answer = 6;
                        break;

                    case "7 of ":
                        answer = 7;
                        break;

                    case "8 of ":
                        answer = 8;
                        break;

                    case "9 of ":
                        answer = 9;
                        break;
                    case "10 of ":
                    case "Jack of ":
                    case "Queen of ":
                    case "King of ":
                        answer = 10;
                        break;

                    case "Ace of ":
                        answer = 11;
                        break;
                }
                return answer;
            }
        }
        static void DisplayGreeting()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Welcome to Blackjack!!!");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
            DisplayGreeting();
            var suits = new List<string>() { "Spades", "Clubs", "Hearts", "Diamonds" };
            var face = new List<string>() { "Ace of ", "2 of ", "3 of ", "4 of ", "5 of ", "6 of ", "7 of", "8 of ", "9 of ", "10 of " };
            var DeckOfCards = new List<Card>();

            foreach (var aCardValue in face)
            {
                foreach (var aCardSuit in suits)
                {
                    var card = new Card()
                    {
                        Face = aCardValue,
                        Suits = aCardSuit,
                    };
                    DeckOfCards.Add(card);

                }
            }
            var DeckSize = DeckOfCards.Count;
            for (var endOfDeck = DeckSize - 1; endOfDeck >= 0; endOfDeck--)
            {
                var cardPicker = new Random().Next(0, endOfDeck);
                var randomCard = DeckOfCards[cardPicker];
                var lastCard = DeckOfCards[endOfDeck];
                DeckOfCards[endOfDeck] = randomCard;
                DeckOfCards[cardPicker] = lastCard;
            }

            var computer = new Player();
            var playerOne = new Player();

            computer.PlayerHand = new List<Card>() { DeckOfCards[0], DeckOfCards[1] };
            DeckOfCards.Remove(DeckOfCards[0]);
            DeckOfCards.Remove(DeckOfCards[0]);

            playerOne.PlayerHand = new List<Card>() { DeckOfCards[0], DeckOfCards[1] };
            DeckOfCards.Remove(DeckOfCards[0]);
            DeckOfCards.Remove(DeckOfCards[0]);

        }
    }
}
