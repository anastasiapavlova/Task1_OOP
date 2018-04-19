using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Models
{
    class Ellipse : IFigure
    {
        public float x { get; set; }
        public float y { get; set; }
        public float width { get; set; }

        public float height { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitEllipse(this);
        }
    }
}
