using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CrazyEights
{
    public class DiscardZone : CardZone
    {
        public int CurrentValue { get; set; }
        public char CurrentSuit { get; set; }

        public DiscardZone() : base()
        {
            BackColor = GameSetup.discardZoneColor;
            Text = "Discard";
        }

        public void SetLocation()
        {
            int x = (Parent.Width / 2) + GameSetup.zoneMargin;
            int y = (Parent.Height / 2) - (Height / 2);
            Location = new Point(x, y);
        }

        public bool IsValidDiscard(Card card, Card discardPile, char playableSuit)
        {
            bool isValid = false;
            if (card.Value == 8 || card.Value == discardPile.Value || card.Suit == playableSuit) isValid = true;
            
            return isValid;
        }

        public void ShuffleDiscardToDraw(DrawZone drawPile)
        {
            while (Cards.Count > 2)
            {
                TransferCard(drawPile, Cards[0]);
            }
            drawPile.Shuffle();
            drawPile.PlaceCardsInPile();
        }
    }
}
