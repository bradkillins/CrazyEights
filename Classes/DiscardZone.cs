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

        public bool IsValidDiscard(Card card)
        {
            //TODO detect if either suit matches or value is correct 
            return true;
        }

        public void ShuffleDiscardToDraw(DrawZone drawPile)
        {
            while (Cards.Count > 0)
            {
                TransferCard(drawPile, Cards[0]);
            }
            drawPile.Shuffle();
            drawPile.PlaceCardsInPile();
        }
    }
}
