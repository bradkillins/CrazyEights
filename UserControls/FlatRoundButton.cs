using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CrazyEights
{
    class FlatRoundButton : Button
    {
        public FlatRoundButton() : base()
        {
            FlatStyle = FlatStyle.Flat;
        }
        private float borderRadius = 5.0f;
        public float BorderRadius 
        { 
            get 
            {
                return borderRadius;
            } 
            set 
            {
                if (value <= 0)
                    borderRadius = 0.1f;
                else
                    borderRadius = value;
            } 
        }

        private GraphicsPath RoundedGPath(RectangleF rect, float radius)
        {
            float pad = FlatAppearance.BorderSize;
            GraphicsPath gp = new GraphicsPath();
            
            gp.AddArc(rect.X + pad, rect.Y + pad, radius, radius, 180, 90); //top-left arc
            gp.AddLine(rect.X + pad + radius, rect.Y + pad, rect.X + rect.Width - pad - radius, rect.Y + pad); //top line
            gp.AddArc(rect.X + rect.Width - pad - radius, rect.Y + pad, radius, radius, 270, 90); //top-right arc
            gp.AddLine(rect.X + rect.Width - pad, rect.Y + pad + radius, rect.X + rect.Width - pad, rect.Y + rect.Height - pad - radius); //right line
            gp.AddArc(rect.X + rect.Width - pad - radius, rect.Y + rect.Height - pad - radius, radius, radius, 0, 90); //bottom-right arc
            gp.AddLine(rect.X + rect.Width - pad - radius, rect.Y + rect.Height - pad, rect.X + pad + radius, rect.Y + rect.Height - pad); //bottom line
            gp.AddArc(rect.X + pad, rect.Y + rect.Height - pad - radius, radius, radius, 90, 90); //bottom-left arc
            gp.AddLine(rect.X + pad, rect.Y + rect.Height - pad - radius, rect.X + pad, rect.Y + pad + radius); //left line
            
            gp.CloseFigure();
            return gp;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rectangle = new Rectangle(0, 0, Width, Height);
            GraphicsPath gp = RoundedGPath(rectangle, borderRadius);
            Region = new Region(gp);
            Pen pen = new Pen(FlatAppearance.BorderColor, FlatAppearance.BorderSize);
            pen.Alignment = PenAlignment.Inset;
            e.Graphics.DrawPath(pen, gp);               
        }
    }
}
