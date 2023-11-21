using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDelegate
{
    internal class A_SimpleDelegete
    {
        public delegate T NoPrameters<T>(T param1, T param2);
        //public delegate T NoPrameters<T,I>(T param1, I param2);
    }
}
