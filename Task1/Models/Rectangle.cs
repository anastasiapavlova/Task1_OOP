using Task1.Interfaces;

namespace Task1.Models
{
    class Rectangle : IFigure
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }

        public float Height { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitRectangle(this);
        }
    }
}
