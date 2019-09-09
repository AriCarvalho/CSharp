using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Flyweight
{
    class ObjetoFlyweight:IClasse
    {
        public int A { get; set; }

        public int Metodo(int B, int C, int D, int E)
        {
            return A + B + C + D + E;
        }
    }
}
