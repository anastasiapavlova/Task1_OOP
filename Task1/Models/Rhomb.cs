using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Models
{
    class Rhomb : IFigure
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }

        public int height { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitRhomb(this);
        }
    }
}
