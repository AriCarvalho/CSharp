using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.ModelViewPresenter
{
    class View:IView
    {
        private  Presenter presenter;

        public View()
        {
            presenter = new Presenter(this,12);
            presenter.SetData();
        }

        public void SetName(string name) { }
        public void SetDate(DateTime date) { }

        public void OnClick()
        {
            presenter.UpdateData();
        }
    }
}
