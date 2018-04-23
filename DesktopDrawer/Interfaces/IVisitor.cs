using BusinessLogic.Models;

namespace BusinessLogic.Interfaces
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
