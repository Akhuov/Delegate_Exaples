using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KunUz.Delegates;

namespace KunUz
{
    public class KunUzAxborotXizmati
    {
        public CustomDelegate Xabar { get; set; }

        public void XabarlarniChopEtish()
        {
            while (true)
            {
                var yangiXabar = new Random().Next(100);
                Xabar(yangiXabar);

                Thread.Sleep(2000);
            }
        }
    }
}
