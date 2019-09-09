using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Singleton
{
    class Singleton
    {
        public static Singleton Instance { get => SingletonNested.Instance; }

        private class SingletonNested{
            static SingletonNested() { }
            internal static readonly Singleton Instance = new Singleton();
        }
    }
}
