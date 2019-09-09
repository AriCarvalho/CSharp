using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Composite
{
    class NoGrupo : INo
    {
        private List<INo> nos;

        public NoGrupo()
        {
            nos = new List<INo>();
        }

        public void Add(INo no)
        {
            nos.Add(no);
        }
        public int Funcao()
        {
           return nos.Sum(x => x.Funcao());
        }
    }
}
