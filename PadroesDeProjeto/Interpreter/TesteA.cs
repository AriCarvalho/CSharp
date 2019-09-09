using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Interpreter
{
    class TesteA:TesteBase
    {
        public void Testar()
        {
            int x=0;
            int y=0;

            Given(()=> {
                x = 3;
            });

            When(() => {
                y = 5;
            });

            Then(() => {
                return (y + x == 8);
            });
        }
    }
}
