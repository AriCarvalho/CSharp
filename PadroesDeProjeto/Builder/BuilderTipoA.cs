using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Builder
{
    class BuilderTipoA : IBuilder
    {
        private ObjetoComplexo obj;
        public BuilderTipoA()
        {
            obj = new ObjetoComplexo();
        }
        public ObjetoComplexo ObjetoPronto()
        {
            return obj;
        }

        public void Parte1()
        {
            throw new NotImplementedException();
        }

        public void Parte2()
        {
            throw new NotImplementedException();
        }

        public void Parte3()
        {
            throw new NotImplementedException();
        }
    }
}
