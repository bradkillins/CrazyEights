using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace CrazyEights
{
    public partial class Gameboard : Form
    {
        DrawZone drawPile = new DrawZone();
        DiscardZone discardPile = new DiscardZone();
        HandZone mainPlayerHand = new HandZone(true);
        HandZone opponent1Hand = new HandZone(false);
        HandZone opponent2Hand = new HandZone(false);
        HandZone opponent3Hand = new HandZone(false);
        public Gameboard(int numOfOpps)
        {
            InitializeComponent();
            NumOfOppsText.Text = numOfOpps.ToString();
            Controls.Add(drawPile);
            drawPile.SetLocation();
            Controls.Add(discardPile);
            discardPile.SetLocation();
            Controls.Add(mainPlayerHand);
            mainPlayerHand.SetLocation();
            //if (numOfOpps == 1)
            //    Controls.Add(opponent1Hand);
            //if (numOfOpps == 2)
            //{
            //    Controls.Add(opponent1Hand);
            //    Controls.Add(opponent2Hand);
            //}
            //if (numOfOpps == 3)
            //{
            //    Controls.Add(opponent1Hand);
            //    Controls.Add(opponent2Hand);
            //    Controls.Add(opponent3Hand);
            //}

            CardZones.Zones.Add(drawPile);
            CardZones.Zones.Add(discardPile);
            CardZones.Zones.Add(mainPlayerHand);
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CardMouseUp(object sender, MouseEventArgs e)
        {
            Card card = (Card)sender;

            if (discardPile.Bounds.Contains(card.Bounds))
            {
                if(card.zoneBeforeMove == mainPlayerHand && discardPile.IsValidDiscard(card))
                {
                    //TODO - complete IsValidDiscard method
                    //then set discardPile suit and value appropriatly
                    //we'll also need to handel crazy 8s!
                    
                    mainPlayerHand.TransferCard(discardPile, card);
                    discardPile.AnimatePlacingCardInZone(card);
                    mainPlayerHand.AnimatePlacingCardInZone(null);
                }
                else
                {
                    card.FailedMove();
                }                
            }
            else if (mainPlayerHand.Bounds.Contains(card.Bounds))
            {
                if (card.zoneBeforeMove == drawPile)
                {
                    card.ShowFace();
                    drawPile.TransferCard(mainPlayerHand, card);
                    mainPlayerHand.AnimatePlacingCardInZone(card);
                }
                else
                    card.FailedMove();
            }
            else
            {
                card.FailedMove();
            }
        }

        private void Gameboard_Load(object sender, EventArgs e)
        {
            int cardCount = 0;
            foreach (Card card in drawPile.Cards)
            {
                card.MouseUp += CardMouseUp;
                card.ShowBack();
                Controls.Add(card);
                if (cardCount == 0)
                    //display first card slightly to the left
                    card.Location = new Point(drawPile.Left + (GameSetup.cardZoneMargin/3), drawPile.Top + (GameSetup.cardZoneMargin / 2));
                else
                    card.Location = new Point(drawPile.Left + (GameSetup.cardZoneMargin / 2), drawPile.Top + (GameSetup.cardZoneMargin / 2));
                card.BringToFront();
                cardCount++;
            }
        }
    }
}
