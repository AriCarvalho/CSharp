using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.EventAggregator
{
    class Sender
    {
        private EventAggregator ag;

        public Sender(EventAggregator ag)
        {
            this.ag = ag;
        }

        public void Send()
        {
            ag.Publish(new SimpleEvent());
        }
    }
}
