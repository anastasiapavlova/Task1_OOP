using System.Collections;
using System.Collections.Generic;
using BusinessLogic.Interfaces;

namespace DesktopDrawer.Models
{
    public class FigureCollection : IEnumerable<IFigure>
    {
        private readonly List<IFigure> _figures = new List<IFigure>();

        public void Add(IFigure figure)
        {
            _figures.Add(figure);
        }
        public void Remove(IFigure figure)
        {
            _figures.Remove(figure);
        }

        public IEnumerator GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator<IFigure> IEnumerable<IFigure>.GetEnumerator()
        {
            return _figures.GetEnumerator();
        }
    }
}
