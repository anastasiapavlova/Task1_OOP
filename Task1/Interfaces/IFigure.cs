using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Interfaces
{
    interface IFigure
    {
        void Accept(IVisitor visitor);
    }
}
