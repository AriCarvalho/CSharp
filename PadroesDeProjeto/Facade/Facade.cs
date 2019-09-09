using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Facade
{
    class Facade
    {
        public void MetodoSimples(string d)
        {
            var  api = new ApiComplexa();
            api.Metodo2(d);
            api.Metodo4(d);
            api.Metodo1();
            api.Metodo3(d);
        }
    }
}
