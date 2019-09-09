using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Flyweight
{
    class FlyweightFactory
    {
        private Dictionary<string, IClasse> dic = new Dictionary<string, IClasse>();
        public IClasse CreateObjeto(string str)
        {
            if (dic.ContainsKey(str))
                return dic[str];
            else
            {
                var obj = new ObjetoFlyweight();
                dic[str] = obj;
                return obj;
            }
        }
    }
}
