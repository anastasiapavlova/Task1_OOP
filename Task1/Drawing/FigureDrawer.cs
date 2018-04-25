using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using BusinessLogic.Models;

namespace DesktopDrawer.Drawing
{
    public static class FigureDrawer
    {
        public static void DrawCircle(Circle figure, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.DodgerBlue, 4);
            l.DrawEllipse(p, figure.X, figure.Y, figure.Width, figure.Height);
        }

        public static void DrawSquare(Square figure, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.Goldenrod, 4);
            l.DrawRectangle(p, figure.X, figure.Y, figure.Width, figure.Height);
        }

        public static void DrawEllipse(Ellipse figure, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.DarkRed, 4);
            l.DrawEllipse(p, figure.X, figure.Y, figure.Width, figure.Height);
        }

        public static void DrawRhomb(Rhomb figure, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
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

        public static void DrawLineSegment(LineSegment figure, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.IndianRed, 4);
            l.DrawLine(p, figure.X1, figure.Y1, figure.X2, figure.Y2);
        }

        public static void DrawRectangle(BusinessLogic.Models.Rectangle figure, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.Indigo, 4);
            l.DrawRectangle(p, figure.X, figure.Y, figure.Width, figure.Height);
        }

        
    }
}
