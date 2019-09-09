using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Factory
{
    class Programa
    {
        void ExecutarAcao()
        {
            var factory = new Factory();
           var obj = factory.CreateInstance(ConfigurationManager.AppSettings["IClasse"] as string);
        }
    }
}
