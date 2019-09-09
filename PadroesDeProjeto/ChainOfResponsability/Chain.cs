using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.ChainOfResponsability
{
    class Chain
    {

        public void Processar()
        {
            var r = new Requisicao();

            var a = new ProcessoA();

            var b = new ProcessoB();
            a.SetProximo(b);

            var c = new ProcessoC();
            b.SetProximo(c);

            var res = a.Analisar(r);

        }
    }
}
