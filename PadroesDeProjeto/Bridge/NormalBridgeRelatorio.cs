using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Bridge
{
    class NormalBridgeRelatorio : IBridgeRelatorio
    {
        public string Preparar(string str)
        {
            return str;
        }
    }
}
