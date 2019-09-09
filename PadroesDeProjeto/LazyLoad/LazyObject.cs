using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.LazyLoad
{
    class LazyObject
    {
        Lazy<object> _obj = new Lazy<object>(()=>new object());
        public object Obj => _obj.Value;
    }
}
