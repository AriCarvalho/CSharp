using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Prototype
{
    class Prototipo : ICloneable
    {
        public int Dados { get; set; } 
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
