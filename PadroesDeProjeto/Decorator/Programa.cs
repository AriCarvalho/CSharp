using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Decorator
{
    class Programa
    {
        void ExecutarAcao()
        {
            var cl = new ClasseAntiga();
            var dec = new ClasseDecorador(cl);

            dec.Acao();//Nova funcionalidade
        }
    }
}
