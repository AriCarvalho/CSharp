using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Bridge
{
    class TruncadoBridgeRelatorio : IBridgeRelatorio
    {
        public string Preparar(string str)
        {
            return str.Substring(0, Math.Min(4, str.Length));
        }
    }
}
