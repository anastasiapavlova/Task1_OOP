using Task1.Interfaces;

namespace Task1.Models
{
    class LineSegment : IFigure
    {
        public float X1 { get; set; }
        public float Y1 { get; set; }
        public float X2 { get; set; }
        public float Y2 { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor?.VisitLineSegment(this);
        }
    }
}
