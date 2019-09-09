using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Visitor
{
    interface IVisitor
    {
         void Visit(TipoA tipoA);
         void Visit(TipoB tipoB);
         void Visit(TipoC tipoC);
    }
}
