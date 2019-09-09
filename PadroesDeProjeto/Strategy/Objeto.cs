using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Strategy
{
    class Objeto
    {
        private readonly IEstrategia estategia;

        public Objeto(IEstrategia estategia)
        {
            this.estategia = estategia;
        }
        public void Acao(Dados dados)
        {
            estategia.Acao(dados);
        }
    }
}
