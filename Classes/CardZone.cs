using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyEights
{
    public class CardZone : Label
    {
        public List<Card> Cards { get; set; }

        public CardZone()
        {
            Cards = new List<Card>();
            MinimumSize = new Size(GameSetup.cardSize.Width + GameSetup.zoneMargin, GameSetup.cardSize.Height + GameSetup.zoneMargin);
            Size = MinimumSize;
            MaximumSize = MinimumSize;
            TextAlign = ContentAlignment.MiddleCenter;
        }

        /// <summary>
        /// Transfers a card from this CardZone to another.
        /// </summary>
        /// <param name="transferToZone">The zone to transfer to.</param>
        /// <param name="card">The card to tansfer.</param>
        public void TransferCard(CardZone transferToZone, Card card)
        {
            Cards.Remove(card);
            transferToZone.Cards.Add(card);
        }

        public virtual void AnimatePlacingCardInZone(Card card)
        {
            Utilities.AnimateCard(card, Location, GameSetup.zoneMargin / 2, GameSetup.zoneMargin / 2);
        }
    }
}
