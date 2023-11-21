

namespace DDelegate
{
    internal static class Methods
    {
        public static int Qoshish(int a, int b)
        {
            var result = a + b;
            Console.WriteLine($"Natija: {result}");
            return result;
        }

        public static string Birlashtirish(string txt1, string txt2)
        {
            var result = $"{txt1} {txt2}";
            Console.WriteLine($"Natija: {result}");
            return result;
        }

        public static string Birlashtirish(int x, string txt2)
        {
            var result = $"{x} {txt2}";
            Console.WriteLine($"Natija: {result}");
            return result;
        }

    }
}

