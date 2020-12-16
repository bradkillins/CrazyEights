using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transitions;
using System.Drawing;

namespace CrazyEights
{
    public class HandZone : CardZone
    {
        public bool IsMainPlayer { get; }

        public HandZone(bool isMainPlayer) : base()
        {
            IsMainPlayer = isMainPlayer;
            BackColor = GameSetup.handZoneColor;
            Text = "Player Hand";
            MaximumSize = new Size(GameSetup.cardSize.Width * 9 + GameSetup.zoneMargin, GameSetup.cardSize.Height + GameSetup.zoneMargin);
        }

        public int CalculateHandPoints()
        {
            int points = 0;
            foreach (Card card in Cards)
            {
                points += card.Value;
            }
            return points;
        }

        public override void AnimatePlacingCardInZone(Card card)
        {
            ResizeAndRepositionZone();
            RepositionCardsInHand();
            if (card != null)
                Utilities.AnimateCard(card, DetermineCardPosition(card), 0, 0, 500);
        }

        Point DetermineCardPosition(Card card)
        {
            int posInHand = Cards.FindIndex(x => x == card);
            int yPos = Location.Y + (GameSetup.zoneMargin / 2);
            int xPos;
            if (Cards.Count >= 8)
            {
                xPos = posInHand * (card.Width/2) + (GameSetup.zoneMargin / 2) + Location.X;
            }
            else
            {
                xPos = posInHand * card.Width + (GameSetup.zoneMargin / 2) + Location.X;
            }
            
            return new Point(xPos, yPos);
        }

        void ResizeAndRepositionZone()
        {
            int cardSpaces = Cards.Count + 1;
            if (Cards.Count >= 8)
            {
                MinimumSize = new Size(cardSpaces * (GameSetup.cardSize.Width/2) + GameSetup.zoneMargin, GameSetup.cardSize.Height + GameSetup.zoneMargin);
            }
            else 
            {
                MinimumSize = new Size(cardSpaces * GameSetup.cardSize.Width + GameSetup.zoneMargin, GameSetup.cardSize.Height + GameSetup.zoneMargin);
            }
            //MinimumSize = new Size(cardSpaces * GameSetup.cardSize.Width + GameSetup.zoneMargin, GameSetup.cardSize.Height + GameSetup.zoneMargin);
            Size = MinimumSize;
            SetLocation();
        }

        public void RepositionCardsInHand()
        {
            int count = 0;
            foreach (Card cardInHand in Cards)
            {
                cardInHand.Location = DetermineCardPosition(cardInHand);
                count++;
                cardInHand.BringToFront();
            }
        }

        public void SetLocation()
        {
            if (IsMainPlayer)
            Location = new Point((Parent.Width / 2) - (Width / 2), Parent.Height - Height - GameSetup.zoneMargin);
            else Location = new Point((Parent.Width / 2) - (Width / 2), GameSetup.zoneMargin);
        }
    }
}
