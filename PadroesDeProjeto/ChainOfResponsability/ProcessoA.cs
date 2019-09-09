using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.ChainOfResponsability
{
    class ProcessoA : IProcesso
    {
        IProcesso outro;
        public Resultado Analisar(Requisicao rec)
        {
            if(!CanAnalisar(rec))
            {
                if (outro != null)
                    return outro.Analisar(rec);
                else
                    return null; 
            }
            //PROCESSO
            return new Resultado();

        }

        public bool CanAnalisar(Requisicao rec)
        {
            throw new NotImplementedException();
        }

        public void SetProximo(IProcesso pro)
        {
            outro = pro;
        }
    }
}
