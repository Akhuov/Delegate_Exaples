using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CDelegate.A_SimpleDelegete;

namespace CDelegate
{
    internal static class Methods
    {
        public static int Sum(int a, int b)
        {
            var result = a + b;
            Console.WriteLine($"Yig'indi: {result}");
            return result;
        }

        public static int Multiply(int x, int y)
        {
            var result = x * y;
            Console.WriteLine($"Ko'paytma: {result}");
            return result;
        }

        public static void InvokeDelegate(NoPrameters del)
        {
            del();
        }
    }
}
