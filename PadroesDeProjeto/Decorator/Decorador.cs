using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Decorator
{
    class ClasseDecorador : IClasse
    {
        private readonly IClasse cl;

        public ClasseDecorador(IClasse cl)
        {
            this.cl = cl;
        }

        public void Acao()
        {
            cl.Acao();

            //DEMAIS AÇÕES
        }
    }
}
