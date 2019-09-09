using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Memento
{
    class Programa
    {
        Stack<Memento> stack;
        Memento Current;
        void ExecutarAcao()
        {
            Current = new Memento();
            //Acões
            SalvarEstado();
            //Acões
            SalvarEstado();
            //Acões
            SalvarEstado();
            //Acões
            RestaurarEstado();
        }

        private void RestaurarEstado()
        {
            Current = stack.Pop();
        }

        private void SalvarEstado()
        {
            stack.Push(Current);
            Current = new Memento(Current);
        }
    }
}
