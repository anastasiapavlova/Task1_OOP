using System.Collections.Generic;
using Task1.Interfaces;

namespace Task1.Models
{
    class Figure
    {
        List<IFigure> figures = new List<IFigure>();
        public void Add(IFigure figure)
        {
            figures.Add(figure);
        }
        public void Remove(IFigure figure)
        {
            figures.Remove(figure);
        }
        
        public void Accept(IVisitor visitor)
        {
            foreach (IFigure figure in figures)
                figure.Accept(visitor);
        }
    }
}
