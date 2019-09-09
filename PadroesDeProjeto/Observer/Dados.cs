using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Observer
{
    class Dados : IObservable<Valores>
    {
        List<IObserver<Valores>> observers = new List<IObserver<Valores>>();

        Valores valores;
        public Valores Valores { get { return valores; } set { valores = value;Notify(); } }

        public IDisposable Subscribe(IObserver<Valores> observer)
        {
            observers.Add(observer);
            return new Unsubscriber( observers, observer);
        }

        public void Acao()
        {
            //Ação com valores


            Notify();
        }

        private void Notify()
        {
            observers.AsParallel().ForAll((x) => { x.OnNext(valores); });
        }

        class Unsubscriber : IDisposable
        {
            private readonly List<IObserver<Valores>> observers;
            private readonly IObserver<Valores> observer;

            public Unsubscriber(List<IObserver<Valores>> observers, IObserver<Valores> observer)
            {
                this.observers = observers;
                this.observer = observer;
            }

            public void Dispose()
            {
                observers.Remove(observer);
            }
        }
    }
}
