using Task1.Models;

namespace Task1.Interfaces
{
    public interface IVisitor
    {
        void Visit(Circle figure);
        void Visit(Rectangle figure);
        void Visit(LineSegment figure);
        void Visit(Ellipse figure);
        void Visit(Rhomb figure);
        void Visit(Square figure);
    }
}
