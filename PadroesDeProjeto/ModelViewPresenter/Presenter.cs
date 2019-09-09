using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.ModelViewPresenter
{
    class Presenter
    {
        IView view;

        Model model;
        public Presenter(IView view,int id)
        {
            model = new Model();//Buscar
            this.view = view;
        }

        public void SetData()
        {
            view.SetName(model.Name);
            view.SetDate(model.Date);
        }

        public void UpdateData()
        {
        // model.Name = "Nome";
        }
    }
}
