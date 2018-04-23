using BusinessLogic.Interfaces;

namespace BusinessLogic.Models
{
    public abstract class BaseFigure : IFigure
    {
        protected BaseFigure(float x, float y, float width, float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public abstract void Accept(IVisitor visitor);
    }
}
