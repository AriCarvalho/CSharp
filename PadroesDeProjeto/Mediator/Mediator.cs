using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Mediator
{
    class Mediator
    {
        List<Objeto> lis = new List<Objeto>();
        public void Register(Objeto objeto)
        {
            lis.Add(objeto);
        }

        public void BroadCast(Objeto objeto, string str)
        {
            lis.Where((x)=>x != objeto).AsParallel().ForAll((x) => x.OnBroadCast(str));
        }
    }
}
