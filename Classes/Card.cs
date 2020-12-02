using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Transitions;

namespace CrazyEights
{
    public class Card : PictureBox
    {
        public int Value { get; }
        public char Suit { get; }
        public CardZone zoneBeforeMove;
        public Point locationBeforeMove;
        string imgLocation;

        public Card(int value, char suit)
        {
            Value = value;
            Suit = suit;
            ImageLocation = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName 
                + $"\\Resources\\Cards\\{value}-{suit}.png";
            imgLocation = ImageLocation;
            SizeMode = PictureBoxSizeMode.StretchImage;
            Size = GameSetup.cardSize;
            BackgroundImage = CrazyEights.Properties.Resources.CardBackBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            MouseDown += Utilities.MovingControlMouseDown;
            MouseUp += Utilities.MovingControlMouseUp;
            MouseMove += Utilities.MovingControlMouseMove;
        }

        public void ShowFace()
        {
            ImageLocation = imgLocation;   
        }

        public void ShowBack()
        {
            ImageLocation = null;
        }

        public void FailedMove()
        {
            if(zoneBeforeMove.GetType() == typeof(HandZone)) 
            {
                zoneBeforeMove.AnimatePlacingCardInZone(this);
            }
            else 
            {
                Utilities.AnimateCard(this, locationBeforeMove, 0, 0);
            }
            
        }
    }
}
