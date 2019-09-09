using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Mediator
{
    class Programa
    {
        void ExecutarAcao()
        {
            var med = new Mediator();

            var objA = new Objeto(med);
            var objB = new Objeto(med);
            var objC = new Objeto(med);

            objA.Comunicar("Dados");
        }
   }
}
