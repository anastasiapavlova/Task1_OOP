using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Models;

namespace Task1.Interfaces
{
    interface IVisitor
    {
        void VisitSquare(Square figure);
        void VisitCircle(Circle figure);
        void VisitRectangle(Models.Rectangle figure);
        void VisitLineSegment(LineSegment figure);
        void VisitEllipse(Ellipse figure);
        void VisitRhomb(Rhomb figure);
    }
}
