using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Bridge
{
    class RelatorioGeral
    {
        public void Relatorios()
        {
            var bridge = new NormalBridgeRelatorio();
            //var bridge = new TruncadoBridgeRelatorio();

            var casa = new Casa(bridge);
            var livro = new Livro(bridge);

            var objs = new List<IRelatorio>();
            objs.Add(casa);
            objs.Add(livro);

            objs.ForEach(x =>Console.WriteLine(x.Relatorio()));
        }
    }
}
