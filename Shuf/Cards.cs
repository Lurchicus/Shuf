using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuf
{
    //This project exists for the sole purpose of honing my C# skills as I transition away
    // from VB.NET as my primary .NET language.
    // Copyright Dan Rhea 2015
    public class Cards : IDisposable
    {
        private bool disposed = false;
        //Our "random" dealer
        public Random deal = new Random();
        //Default card suites and faces
        public string[] suites = { "Diamonds", "Clubs", "Hearts", "Spades" };
        public string[] faces = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        //The deck of "cards"
        List<Card> LDeck;

        public Cards()
        {
            //Set up a default deck
            LDeck = new List<Card>();
            openDeck();
        }

        public Cards(string[] newSuites, string[] newFaces)
        {
            //Set up a custom deck
            LDeck = new List<Card>();
            int size = newSuites.Length * newFaces.Length;
            suites = new string[newSuites.Length];
            faces = new string[newFaces.Length];

            for (int suite = 0; suite < suites.Length; suite++)
            {
                suites[suite] = newSuites[suite];
            }
            for (int face = 0; face < faces.Length; face++)
            {
                faces[face] = newFaces[face];
            }
            openDeck();
        }

        public void Dispose()
        {
            Close();
        }

        public void Close()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) 
        {
            
            if (!disposed)
            {
                suites = null;
                faces = null;
                deal = null;
                disposed = true;
                LDeck.Clear();
                LDeck = null;
            }
        }

        public int getDeckSize()
        {
            return suites.Length * faces.Length;
        }

        private void openDeck()
        {
            //Create the deck of cards
            int shoe = 0;

            for (int suite = 0; suite < suites.Length; suite++)
            {
                for (int face = 0; face < faces.Length; face++)
                {
                    LDeck.Add(new Card()
                    {
                        CardName = faces[face] + " of " + suites[suite],
                        CardID = shoe,
                        Order = -1
                    });
                    shoe++;
                }
            }
        }

        public void doTheShuffle()
        {
            //Shuffle the deck of cards
            int shoe = 0;
            int card = 0;

            //Clear the deck evey time we shuffle
            foreach (Card aCard in LDeck)
            {
                aCard.Order = -1;
            }
            //Shuffle the deck
            for (shoe = 0; shoe < getDeckSize(); shoe++)
            {
                //Bounce around the deck until we find an available (unused) card
                card = deal.Next(0, getDeckSize());
                while (card != -1)
                {
                    Card result = LDeck.Find(delegate(Card cd) { return cd.CardID == card; });
                    if (AvailableCard(result)) 
                    {
                        result.Order = shoe;
                        break;
                    }
                    else
                    {
                        card = deal.Next(0, getDeckSize());
                    }
                }
            }
        }

        public string getCard(int card)
        {
            //Return the current card (via the shuffle map)
            String Got = null;

            Card result = LDeck.Find(delegate(Card cd) { return cd.Order == card; });
            if (result != null) 
            {
                Got = result.CardName;
            }
            else
            {
                Got = "card error (" + card.ToString() + " is out of range)";
            }
            return Got;
        }

        public int getIndex(int card) 
        {
            //Return the shuffle index for the current card (debug)
            int Got = 0;

            Card result = LDeck.Find(delegate(Card cd) { return cd.CardID == card; });
            if (result != null)
            {
                Got = result.Order;
            }
            else
            {
                Got = -1;
            }
            return Got;
        }

        private static bool AvailableCard(Card cd)
        {
            if (cd.Order == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
