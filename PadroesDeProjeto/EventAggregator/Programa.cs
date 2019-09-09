using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.EventAggregator
{
    class Programa
    {
        void ExecutarAcao()
        {
            var ag = new EventAggregator();

            var sen = new Sender(ag);

            var rec = new Receiver(ag);

            sen.Send();
        }
    }
}
