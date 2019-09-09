using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.ChainOfResponsability
{
    interface IProcesso
    {
        void SetProximo(IProcesso pro);
        Resultado Analisar(Requisicao rec);
        bool CanAnalisar(Requisicao rec);
    }
}
