using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Task1.Interfaces;
using Task1.Models;

namespace Task1.Drawing
{
    internal class DrawFigure : IVisitor
    {
        private PaintEventArgs _event { get; set; }
        public DrawFigure(PaintEventArgs e)
        {
            _event = e;
        }

        public void Visit(Circle figure)
        {
            Graphics l = _event.Graphics;
            Pen p = new Pen(Color.DodgerBlue, 4);
            l.DrawEllipse(p, figure.X, figure.Y, figure.Width, figure.Height);
        }

        public void Visit(Models.Rectangle figure)
        {
            Graphics l = _event.Graphics;
            Pen p = new Pen(Color.Indigo, 4);
            l.DrawRectangle(p, figure.X, figure.Y, figure.Width, figure.Height);
        }

        public void Visit(Square figure)
        {
            Graphics l = _event.Graphics;
            Pen p = new Pen(Color.Goldenrod, 4);
            l.DrawRectangle(p, figure.X, figure.Y, figure.Width, figure.Height);
        }

        public void Visit(Ellipse figure)
        {
            Graphics l = _event.Graphics;
            Pen p = new Pen(Color.DarkRed, 4);
            l.DrawEllipse(p, figure.X, figure.Y, figure.Width, figure.Height);
        }

        public void Visit(Rhomb figure)
        {
            Graphics l = _event.Graphics;
            using (GraphicsPath myPath = new GraphicsPath())
            {
                myPath.AddLines(new[]
                {
                    new Point((int)figure.X, (int)figure.Y + ((int)figure.Height / 2)),
                    new Point((int)figure.X + ((int)figure.Width / 2), (int)figure.Y),
                    new Point((int)figure.X + (int)figure.Width, (int)figure.Y + ((int)figure.Height / 2)),
                    new Point((int)figure.X + ((int)figure.Width / 2), (int)figure.Y + (int)figure.Height),
                    new Point((int)figure.X, (int)figure.Y + ((int)figure.Height / 2))
                });
                using (Pen pen = new Pen(Color.Black, 4))
                    l.DrawPath(pen, myPath);
            }
        }

        public void Visit(LineSegment figure)
        {
            Graphics l = _event.Graphics;
            Pen p = new Pen(Color.IndianRed, 4);
            l.DrawLine(p, figure.X1, figure.Y1, figure.X2, figure.Y2);
        }

        public void DrawFigures(IEnumerable<IFigure> figures)
        {
            foreach (IFigure figure in figures)
            {
                figure.Accept(this);
            }
        }
    }
}
