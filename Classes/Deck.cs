using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyEights
{
    class Deck
    {
        public List<Card> Cards { get; set; }

        public void FillStartingDeck()
        {
            List<Card> cards = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                char suit = 'Z';
                if (i == 0)
                    suit = 'C';
                if (i == 1)
                    suit = 'D';
                if (i == 2)
                    suit = 'H';
                if (i == 3)
                    suit = 'S';
                
                for (int j = 1; j <= 13; j++)
                {
                    cards.Add(new Card(j, suit));
                }
            }
            Cards = cards;
        }
    }
}
