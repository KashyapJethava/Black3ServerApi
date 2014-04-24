using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Black3ClassLibrary.Enums;

namespace Black3ClassLibrary.Common
{
    public static class Deck
    {   
        public static List<string> GetOrderedDeck()
        {
            List<string> deck = new List<string>();
            
            deck.Add("2C");
            deck.Add("2D");
            deck.Add("2S");
            deck.Add("2H");
            deck.Add("3C");
            deck.Add("3S");
            deck.Add("3H");
            deck.Add("3D");
            deck.Add("4C");
            deck.Add("4S");
            deck.Add("4H");
            deck.Add("4D");
            deck.Add("5C");
            deck.Add("5S");
            deck.Add("5H");
            deck.Add("5D");
            deck.Add("6C");
            deck.Add("6S");
            deck.Add("6H");
            deck.Add("6D");
            deck.Add("7C");
            deck.Add("7S");
            deck.Add("7H");
            deck.Add("7D");
            deck.Add("8C");
            deck.Add("8S");
            deck.Add("8H");
            deck.Add("8D");
            deck.Add("9C");
            deck.Add("9S");
            deck.Add("9H");
            deck.Add("9D");
            deck.Add("10C");
            deck.Add("10S");
            deck.Add("10H");
            deck.Add("10D");
            deck.Add("JC");
            deck.Add("JS");
            deck.Add("JH");
            deck.Add("JD");
            deck.Add("QC");
            deck.Add("QS");
            deck.Add("QH");
            deck.Add("QD");
            deck.Add("KC");
            deck.Add("KS");
            deck.Add("KH");
            deck.Add("KD");
            deck.Add("AC");
            deck.Add("AS");
            deck.Add("AH");
            deck.Add("AD");

            return deck;
        }

        public static List<string> GetDecksForPlayers(NPlayers nPlayers)
        {
            List<string> orderedDecs = new List<string>();
            switch (nPlayers)
            {
                case NPlayers.Four :
                    break;
                case NPlayers.Five:
                    break;
                case NPlayers.Six:
                    break;
                case NPlayers.Seven:
                    break;
                case NPlayers.Eight:
                    orderedDecs = GetOrderedDeck();
                    orderedDecs.Concat(GetOrderedDeck());
                    break;
                case NPlayers.Nine:
                    break;
            }
            return orderedDecs;
        }
    }
}
