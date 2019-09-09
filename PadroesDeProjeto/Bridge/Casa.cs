using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Bridge
{
    class Casa: IRelatorio
    {
        private IBridgeRelatorio _rel;
        public string Localidade { get; set; }
        public Casa(IBridgeRelatorio rel)
        {
            _rel = rel;
        }

        public string Relatorio() {
            return "CASA:" + _rel.Preparar(Localidade);
        }

    }
}
