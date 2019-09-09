using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Composite
{
    class Programa
    {
        void ExecutarAcao()
        {
            var raiz = new NoGrupo();
            raiz.Add(new NoFolha());


            var gr = new NoGrupo();
            gr.Add(new NoFolha());
            gr.Add(new NoFolha());
            raiz.Add(gr);

            var res = raiz.Funcao();
        }
    }
}
