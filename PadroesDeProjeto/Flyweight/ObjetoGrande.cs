﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Flyweight
{
    class ObjetoGrande//:IClasse
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }
        
        public int Metodo()
        {
            return A + B + C + D + E;
        }
    }
}
