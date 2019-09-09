using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Builder
{
    class MakerObjetoComplexo
    {
        private IBuilder _builder;
        public MakerObjetoComplexo(IBuilder builder) {
            _builder = builder;
        }
        public ObjetoComplexo Make()
        {
            _builder.Parte1();
            _builder.Parte2();
            _builder.Parte3();
           return _builder.ObjetoPronto();
        }

    }
}
