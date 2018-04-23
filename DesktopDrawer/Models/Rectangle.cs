using BusinessLogic.Interfaces;

namespace BusinessLogic.Models
{
    public class Rectangle : BaseFigure
    {
        public Rectangle(float x, float y, float width, float height) : base(x, y, width, height) { }

        public override void Accept(IVisitor visitor)
        {
            visitor?.Visit(this);
        }
    }
}
