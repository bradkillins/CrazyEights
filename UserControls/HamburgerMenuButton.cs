using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyEights
{
    public partial class HamburgerMenuButton : UserControl
    {
        public HamburgerMenuButton()
        {
            InitializeComponent();
            Cursor = Cursors.Hand;
        }

        private void HamburgerMenuButton_Paint(object sender, PaintEventArgs e)
        {
            Rectangle[] lines = new Rectangle[] { 
                new Rectangle(5, 10, 40, 2), 
                new Rectangle(5, 19, 40, 2), 
                new Rectangle(5, 28, 40, 2) 
            };
            
            Pen pen = new Pen(Brushes.White);

            e.Graphics.DrawRectangles(pen, lines);
            e.Graphics.FillRectangles(Brushes.White, lines);
        }
    }
}
