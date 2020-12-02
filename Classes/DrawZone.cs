using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyEights
{
    public class DrawZone : CardZone
    {
        public DrawZone() : base()
        {
            BackColor = GameSetup.drawZoneColor;
            Text = "Draw";
            FillStartingDeck();
            Shuffle();
        }

        void FillStartingDeck()
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

        public void Shuffle()
        {
            Random r = new Random();
            for (int i = Cards.Count - 1; i > 0; i--)
            {
                int randomIndex = r.Next(i + 1);
                Card swapingCard = Cards[randomIndex];
                Cards[randomIndex] = Cards[i];
                Cards[i] = swapingCard;
            }
        }

        public override void AnimatePlacingCardInZone(Card card)
        {
            //TODO - change this so that the first card in the zone is offset,
            //the rest follow normal animatation
            base.AnimatePlacingCardInZone(card);
        }

        public void SetLocation()
        {
            int x = (Parent.Width / 2) - Width - GameSetup.zoneMargin;
            int y = (Parent.Height / 2) - (Height / 2);
            Location = new Point(x, y);
        }

        public void PlaceCardsInPile()
        {
            int cardCount = 0;
            foreach (Card card in Cards)
            {
                card.ShowBack();
                Parent.Controls.Add(card);
                if (cardCount == 0)
                    //display first card slightly to the left
                    card.Location = new Point(Left + (GameSetup.zoneMargin / 3), Top + (GameSetup.zoneMargin / 2));
                else
                    card.Location = new Point(Left + (GameSetup.zoneMargin / 2), Top + (GameSetup.zoneMargin / 2));
                card.BringToFront();
                cardCount++;
            }
        }
    }
}
