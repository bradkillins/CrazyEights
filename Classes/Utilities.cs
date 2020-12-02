using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace CrazyEights
{
    public static class Utilities
    {
        public static Point mouseDownPoint;
        public static bool moving = false;

        public static void MovingControlMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (((Control)sender).GetType() == typeof(Card))
                {
                    ((Control)sender).BringToFront();
                    ((Card)sender).zoneBeforeMove = CardZones.GetCurrentZone((Card)sender);
                    ((Card)sender).locationBeforeMove = ((Card)sender).Location;
                }
                ((Control)sender).Cursor = Cursors.SizeAll;
                mouseDownPoint = e.Location;
                moving = true;
            }
        }

        public static void MovingControlMouseUp(object sender, MouseEventArgs e)
        {
            ((Control)sender).Cursor = Cursors.Default;
            moving = false;
        }

        public static void MovingControlMouseMove(object sender, MouseEventArgs e)
        {
            if (moving && e.Button == MouseButtons.Left)
            {
                Control control = (Control)sender;
                if (
                    ((Control)sender).Parent.GetType() == typeof(MainForm) &&
                    ((Control)sender).GetType() == typeof(Panel)
                )
                {
                    control = ((Control)sender).Parent;
                }
                control.Left = e.X + control.Left - mouseDownPoint.X;
                control.Top = e.Y + control.Top - mouseDownPoint.Y;
            }
        }

        public static void AnimateCard(Card card, Point endPosition, int offsetX, int offsetY, int animationLength = 100)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(animationLength));
            t.add(card, "Left", endPosition.X + offsetX);
            t.add(card, "Top", endPosition.Y + offsetY);
            t.run();
        }
    }
}
