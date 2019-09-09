using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Visitor
{
    class TipoC
    {
        void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
