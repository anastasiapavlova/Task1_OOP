namespace BusinessLogic.Interfaces
{
    public interface IFigure
    {
        void Accept(IVisitor visitor);
    }
}
