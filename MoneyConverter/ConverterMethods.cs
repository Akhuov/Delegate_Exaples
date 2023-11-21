

namespace MoneyConverter
{
    internal class ConverterMethods
    {
        public static float SumToUS(float sum, float currentValue)
        {
            var result = sum / currentValue;
            Console.WriteLine(result);
            return result;
        }

        public static float UsToSum(float us, float currentValue)
        {
            var result = us * currentValue;
            Console.WriteLine(result);
            return result;
        }
    }
}
