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
        public static readonly List<string> deck = new List<string>();

        public static List<string> GetOrderedDeck()
        {
            deck[0] = "2C";
            deck[1] = "2S";
            deck[2] = "2H";
            deck[3] = "2D";
            deck[4] = "3C";
            deck[5] = "3S";
            deck[6] = "3H";
            deck[7] = "3D";
            deck[8] = "4C";
            deck[9] = "4S";
            deck[10] = "4H";
            deck[11] = "4D";
            deck[12] = "5C";
            deck[13] = "5S";
            deck[14] = "5H";
            deck[15] = "5D";
            deck[16] = "6C";
            deck[17] = "6S";
            deck[18] = "6H";
            deck[19] = "6D";
            deck[20] = "7C";
            deck[21] = "7S";
            deck[22] = "7H";
            deck[23] = "7D";
            deck[24] = "8C";
            deck[25] = "8S";
            deck[26] = "8H";
            deck[27] = "8D";
            deck[28] = "9C";
            deck[29] = "9S";
            deck[30] = "9H";
            deck[31] = "9D";
            deck[32] = "10C";
            deck[33] = "10S";
            deck[34] = "10H";
            deck[35] = "10D";
            deck[36] = "JC";
            deck[37] = "JS";
            deck[38] = "JH";
            deck[39] = "JD";
            deck[40] = "QC";
            deck[41] = "QS";
            deck[42] = "QH";
            deck[43] = "QD";
            deck[44] = "KC";
            deck[45] = "KS";
            deck[46] = "KH";
            deck[47] = "KD";
            deck[48] = "AC";
            deck[49] = "AS";
            deck[50] = "AH";
            deck[51] = "AD";

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
