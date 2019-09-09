using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Strategy
{
    class Programa
    {
        void ExecutarAcao()
        {
            var obj = new Objeto(new EstrategiaA());
            obj.Acao(new Dados());
        }
    }
}
