using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.TemplateMethod
{
    abstract class Template
    {
        public void Acao()
        {
            Metodo1();
            Metodo2();
            Metodo3();
        }

        public abstract void Metodo1();
        public abstract void Metodo2();
        public abstract void Metodo3();

    }
}
