using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shuf
{
    //This project exists for the sole purpose of honing my C# skills as I transition away
    // from VB.NET as my primary .NET language.
    // That said, it's 2021 and I'm just having fun with old code.
    //
    // Copyright Dan Rhea 2015 
    // ToDo:
    //  Add a shoe size so we can have one or more decks in the shoe (use a spinner control)
    public partial class Shuf1 : Form
    {
        Cards DeckOfCards; 
        public Boolean madeDeck = false;
        public Boolean changed = false;
        //An alternate deck of 5 suites and 8 faces
        public static string[] altSuites = { "Rocks", "Puppys", "Martians", "Poops", "Doors" };
        public static string[] altFaces = { "Ace", "Duce", "Triad", "Quad", "Quint", "Hex", "Sept", "Octet" };
        //Next... Maybe accept the custom deck definition as XML or JSON data?

        public Shuf1()
        {
            InitializeComponent();
            Application.DoEvents();
        }

        private void DealIt()
        {
            //Switch between default or custom deck? Toss out the current one.
            if (changed) 
            {
                changed = false;
                if (DeckOfCards != null) 
                {
                    // Toss the current deck
                    DeckOfCards.Close();
                }
                madeDeck = false;
            }
            //If we need a new deck, create it
            if (madeDeck == false)
            {
                if (cbxDeck.Checked)
                {
                    DeckOfCards = new Cards(altSuites, altFaces);
                } 
                else 
                {
                    DeckOfCards = new Cards();
                }
                madeDeck = true;
            }
            //Shuffle the cards
            DeckOfCards.doTheShuffle();
            //Show the deck
            showDeal(DeckOfCards);
            Application.DoEvents(); 
        }

        private void showDeal(Cards TheDeck)
        {
            //Show the shuffled cards
            int shoe = 0;

            for (shoe = 0; shoe < TheDeck.getDeckSize(); shoe++)
            {
                text1.AppendText(shoe.ToString() +
                    " \t" + TheDeck.getCard(shoe) +
                    " \t(" + TheDeck.getIndex(shoe).ToString() + ")\r\n");
            }
        }

        private void Done_Click(object sender, EventArgs e)
        {
            //Throw out the deck of cards and exit
            if (DeckOfCards != null) 
            {
                DeckOfCards.Close();
            }
            Application.Exit(); 
        }

        private void Redeal_Click(object sender, EventArgs e)
        {
            //Shuffle and redeal the cards
            text1.Clear();
            DealIt();
            Application.DoEvents();
        }

        private void cbxDeck_CheckedChanged(object sender, EventArgs e)
        {
            //We switched the decks
            changed = true;
        }
    }
}
