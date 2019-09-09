using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.EventAggregator
{
    class Receiver:IReceiver<SimpleEvent>
    {
        private EventAggregator ag;

        public Receiver(EventAggregator ag)
        {
            this.ag = ag;
            ag.Subscribe<SimpleEvent>(this);
        }
        public void OnEvent(SimpleEvent e)
        {
        }
    }
}
