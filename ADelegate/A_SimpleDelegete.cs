using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADelegate
{
    internal class A_SimpleDelegete
    {
        public delegate void NoPrameters();

        public delegate int WithParameters(int x, int y);

        private delegate float WithLinks(ref int x, bool y);
    }
}
