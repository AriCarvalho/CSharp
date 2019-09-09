using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Builder
{
    interface IBuilder
    {
        void Parte1();
        void Parte2();
        void Parte3();
        ObjetoComplexo ObjetoPronto();
    }
}
