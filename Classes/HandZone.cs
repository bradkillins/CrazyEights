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
                Utilities.AnimateCard(card, DetermineCardPosition(card), 0, 0);
        }

        Point DetermineCardPosition(Card card)
        {
            int posInHand = Cards.FindIndex(x => x == card);
            int xPos = posInHand * card.Width + (GameSetup.cardZoneMargin / 2) + Location.X;
            int yPos = Location.Y + (GameSetup.cardZoneMargin / 2);
            return new Point(xPos, yPos);
        }

        void ResizeAndRepositionZone()
        {
            MaximumSize = new Size((Cards.Count + 1) * GameSetup.cardSize.Width + ZoneMargin, GameSetup.cardSize.Height + ZoneMargin);
            MinimumSize = MaximumSize;
            Size = MaximumSize;
            SetLocation();
        }

        void RepositionCardsInHand()
        {
            int count = 0;
            foreach (Card cardInHand in Cards)
            {
                int xPos = cardInHand.Width * count + (GameSetup.cardZoneMargin / 2) + Location.X;
                int yPos = Location.Y + (GameSetup.cardZoneMargin / 2);
                cardInHand.Location = new Point(xPos, yPos);
                count++;
            }
        }

        public void SetLocation()
        {
            Location = new Point((Parent.Width / 2) - (Width / 2), Parent.Height - Height - (GameSetup.cardZoneMargin * 2));
        }
    }
}
