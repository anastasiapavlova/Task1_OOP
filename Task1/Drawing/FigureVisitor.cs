using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;

namespace DesktopDrawer.Drawing
{
    public class FigureVisitor : IVisitor
    {
        private PaintEventArgs Event { get; set; }
        public FigureVisitor(PaintEventArgs e)
        {
            Event = e;
        }
        public void FiguresVisitor(IEnumerable<IFigure> figures)
        {
            foreach (IFigure figure in figures)
            {
                figure?.Accept(this);
            }
        }

        public void Visit(Circle figure)
        {
            FigureDrawer.DrawCircle(figure, Event);
        }

        public void Visit(Square figure)
        {
            FigureDrawer.DrawSquare(figure, Event);
        }

        public void Visit(Ellipse figure)
        {
            FigureDrawer.DrawEllipse(figure, Event);
        }

        public void Visit(Rhomb figure)
        {
            FigureDrawer.DrawRhomb(figure, Event);
        }

        public void Visit(LineSegment figure)
        {
            FigureDrawer.DrawLineSegment(figure, Event);
        }

        public void Visit(Rectangle figure)
        {
            FigureDrawer.DrawRectangle(figure, Event);
        }
    }
}
