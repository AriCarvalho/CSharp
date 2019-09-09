using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Mediator
{
    class Objeto
    {
        private Mediator mediator;
        public Objeto(Mediator mediator)
        {
            this.mediator = mediator;
            mediator.Register(this);
        }

        public void Comunicar(string str)
        {
            mediator.BroadCast(this,str);
        }

        public void OnBroadCast(string str)
        {

        }
    }
}
