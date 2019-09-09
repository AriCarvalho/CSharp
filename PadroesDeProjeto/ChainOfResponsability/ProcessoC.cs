using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.ChainOfResponsability
{
    class ProcessoC : IProcesso
    {
        public Resultado Analisar(Requisicao rec)
        {
            throw new NotImplementedException();
        }

        public bool CanAnalisar(Requisicao rec)
        {
            throw new NotImplementedException();
        }

        public void SetProximo(IProcesso pro)
        {
            throw new NotImplementedException();
        }
    }
}
