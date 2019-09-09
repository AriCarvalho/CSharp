using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Observer
{
    class Programa
    {
        void ExecutarAcao()
        {
            var dados = new Dados();
            var observadorA = new Observador();
            var observadorB = new Observador();

            using (dados.Subscribe(observadorA))
            using (dados.Subscribe(observadorB))
            {
                dados.Acao();
            }
        }
    }
}
