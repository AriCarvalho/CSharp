using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Adapter
{
    class ClasseCliente
    {
        public void MetodoDoCliente(IInterface ojb)
        {
            ojb.MetodoIInterface();
        }
    }
}
