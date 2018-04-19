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
    class DrawFigure :IVisitor
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
            l.DrawEllipse(p, figure.x, figure.y, figure.width, figure.height);
        }

        public void VisitRectangle(Models.Rectangle figure)
        {
            Graphics l = evnt.Graphics;
            Pen p = new Pen(Color.Indigo, 4);
            l.DrawRectangle(p, figure.x, figure.y, figure.width, figure.height);
        }

        public void VisitSquare(Square figure)
        {
            Graphics l = evnt.Graphics;
            Pen p = new Pen(Color.Goldenrod, 4);
            l.DrawRectangle(p, figure.x, figure.y, figure.width, figure.height);
        }

        public void VisitLineSegment(LineSegment figure)
        {
            Graphics l = evnt.Graphics;
            Pen p = new Pen(Color.IndianRed, 4);
            l.DrawLine(p, figure.x1, figure.y1, figure.x2, figure.y2);
        }

        public void VisitEllipse(Ellipse figure)
        {
            Graphics l = evnt.Graphics;
            Pen p = new Pen(Color.DarkRed, 4);
            l.DrawEllipse(p, figure.x, figure.y, figure.width, figure.height);
        }

        public void VisitRhomb(Rhomb figure)
        {
            Graphics l = evnt.Graphics;
            using (GraphicsPath myPath = new GraphicsPath())
            {
                myPath.AddLines(new[]
                {
                    new Point(figure.x, figure.y + (figure.height / 2)),
                    new Point(figure.x + (figure.width / 2), figure.y),
                    new Point(figure.x + figure.width, figure.y + (figure.height / 2)),
                    new Point(figure.x + (figure.width / 2), figure.y + figure.height),
                    new Point(figure.x, figure.y + (figure.height / 2))
                });
                using (Pen pen = new Pen(Color.Black, 4))
                    l.DrawPath(pen, myPath);
            }
        }
    }
}
