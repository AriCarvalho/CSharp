using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Command
{
    class Programa
    {
        void ExecutarAcao()
        {
            var acao = "ComandoA";
            var commandos = new List<IComando> {new ComandoA(),
                                                new ComandoB() };


            var commando = commandos.FirstOrDefault(x => x.Name == acao);


            if (commando == null || ! commando.CanExecute())
            {
                //ERRO
            }
            else
                commando.Execute();
        }


    }
}
