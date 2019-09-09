using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Memento
{
    class Memento
    {

        public Memento()
        {
        }

        public Memento(Memento current)
        {
            //Duplicar
        }

        public object Estado { get; set; }
    }
}
