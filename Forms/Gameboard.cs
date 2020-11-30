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
        Deck deck = new Deck();
        public Gameboard(int numOfOpps)
        {
            InitializeComponent();
            //card_2D.MouseDown += Utilities.MovingControlMouseDown;
            //card_2D.MouseUp += Utilities.MovingControlMouseUp;
            //card_2D.MouseUp += CardMouseUp;
            //card_2D.MouseMove += Utilities.MovingControlMouseMove;
            NumOfOppsText.Text = numOfOpps.ToString();
            deck.FillStartingDeck();
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CardMouseUp(object sender, MouseEventArgs e)
        {
            Control card = (Control)sender;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(100));

            if (TestPile.Bounds.Contains(card.Bounds))
            {
                lblTest.Text = "Yes!";
                t.add(card, "Left", TestPile.Location.X + 10);
                t.add(card, "Top", TestPile.Location.Y + 10);
                t.run();
            }
            else
            {
                lblTest.Text = "No!";
                t.add(card, "Left", TestHand.Location.X + 10);
                t.add(card, "Top", TestHand.Location.Y + 10);
                t.run();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            if(deck.Cards.Count <= 0)
            {
                //shuffle discard back into deck
            }
            Card card = deck.Cards[r.Next(0, deck.Cards.Count)];
            deck.Cards.Remove(card);
            Controls.Add(card);
            card.Location = new Point(TestHand.Location.X + 10, TestHand.Location.Y + 10);
            card.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //card.FlipCard();
        }
    }
}
