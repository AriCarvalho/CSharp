using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Bridge
{
    class Livro: IRelatorio
    {
        private IBridgeRelatorio _rel;
        public Livro(IBridgeRelatorio rel)
        {
            _rel = rel;
        }
        public string Nome { get; set; }

        public string Relatorio()
        {
            return "LIVRO: " + _rel.Preparar(Nome);
        }
    }
}
