using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Interfaces;
using Task1.Models;

namespace Task1.Drawing
{
    internal class DrawFigure :IVisitor
    {
        public PaintEventArgs evnt { get; set; }
        public DrawFigure(PaintEventArgs e)
        {
            evnt = e;
        }
        public void VisitCircle(Circle figure)
        {
            Graphics l = evnt.Graphics;
            Pen p = new Pen(Color.DodgerBlue, 4);
            l.DrawEllipse(p, figure.X, figure.Y, figure.Width, figure.Height);
        }

        public void VisitRectangle(Models.Rectangle figure)
        {
            Graphics l = evnt.Graphics;
            Pen p = new Pen(Color.Indigo, 4);
            l.DrawRectangle(p, figure.X, figure.Y, figure.Width, figure.Height);
        }

        public void VisitSquare(Square figure)
        {
            Graphics l = evnt.Graphics;
            Pen p = new Pen(Color.Goldenrod, 4);
            l.DrawRectangle(p, figure.X, figure.Y, figure.Width, figure.Height);
        }

        public void VisitLineSegment(LineSegment figure)
        {
            Graphics l = evnt.Graphics;
            Pen p = new Pen(Color.IndianRed, 4);
            l.DrawLine(p, figure.X1, figure.Y1, figure.X2, figure.Y2);
        }

        public void VisitEllipse(Ellipse figure)
        {
            Graphics l = evnt.Graphics;
            Pen p = new Pen(Color.DarkRed, 4);
            l.DrawEllipse(p, figure.X, figure.Y, figure.Width, figure.Height);
        }

        public void VisitRhomb(Rhomb figure)
        {
            Graphics l = evnt.Graphics;
            using (GraphicsPath myPath = new GraphicsPath())
            {
                myPath.AddLines(new[]
                {
                    new Point(figure.X, figure.Y + (figure.Height / 2)),
                    new Point(figure.X + (figure.Width / 2), figure.Y),
                    new Point(figure.X + figure.Width, figure.Y + (figure.Height / 2)),
                    new Point(figure.X + (figure.Width / 2), figure.Y + figure.Height),
                    new Point(figure.X, figure.Y + (figure.Height / 2))
                });
                using (Pen pen = new Pen(Color.Black, 4))
                    l.DrawPath(pen, myPath);
            }
        }
    }
}
