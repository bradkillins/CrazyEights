using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace CrazyEights
{
    class Card : PictureBox
    {
        public int Value { get; }
        public char Suit { get; }
        string imgLocation;

        public Card(int value, char suit)
        {
            Value = value;
            Suit = suit;
            ImageLocation = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName 
                + $"\\Resources\\Cards\\{value}-{suit}.png";
            imgLocation = ImageLocation;
            SizeMode = PictureBoxSizeMode.StretchImage;
            Size = new Size(120, 150);
            BackgroundImage = CrazyEights.Properties.Resources.CardBackBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            MouseDown += Utilities.MovingControlMouseDown;
            MouseUp += Utilities.MovingControlMouseUp;
            MouseMove += Utilities.MovingControlMouseMove;
        }

        public void FlipCard()
        {
            if (ImageLocation == null)
                ImageLocation = imgLocation;
            else
                ImageLocation = null;
        }
    }
}
