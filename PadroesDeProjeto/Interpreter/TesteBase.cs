using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Interpreter
{
    abstract class TesteBase   {
       public  void Given(Action a) {
            a();
        }

        public void When(Action b) {
            b();
        }

        public void Then(Func<bool> c) {
            c();
        }
    }
}
