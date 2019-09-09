using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Visitor
{
    class TipoA
    {
        void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
