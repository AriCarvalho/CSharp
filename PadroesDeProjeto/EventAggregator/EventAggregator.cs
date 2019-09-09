using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.EventAggregator
{
    class EventAggregator
    {
        //Lista
        public void Publish(SimpleEvent simpleEvent)
        {
            // lista.Find()
            // foreach 
            // r.OnEvent(simpleEvent)
        }

        public void Subscribe<T>(IReceiver<T> receiver)
        {
            // lista.Add(T,receiver)
        }
    }
}
