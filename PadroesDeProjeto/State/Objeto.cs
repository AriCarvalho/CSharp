using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.State
{
    class Objeto
    {
        public IComportamento comportamento;

        private Estado estado;

        public Estado Estado { get => estado; set {

                estado = value;
                switch(estado)
                {
                    case Estado.Ok: comportamento = new OkComportamento(); break;
                    case Estado.Novo: comportamento = new  NovoComportamento(); break;
                    case Estado.Deletado: comportamento = new DeletadoComportamento(); break;
                }

            } }

        public void Acao1()
        {
            comportamento.Acao1();
        }
        public void Acao2()
        {
            comportamento.Acao2();
        }
    }

   
}
