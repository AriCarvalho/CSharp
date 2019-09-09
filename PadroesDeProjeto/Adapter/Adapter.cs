using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Adapter
{
    class Adapter: IInterface
    {
        public void MetodoIInterface()
        {
            var ci = new ClasseImutavel();
            ci.MetodoUtil(12, 13);
        }

        
    }
}
