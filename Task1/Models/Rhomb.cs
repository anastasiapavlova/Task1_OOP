using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task1.Interfaces;

namespace Task1.Models
{
    class Rhomb : IFigure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }

        public int Height { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitRhomb(this);
        }
    }
}
