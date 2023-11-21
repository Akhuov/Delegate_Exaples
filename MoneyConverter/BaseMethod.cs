using static MoneyConverter.Delegates;

namespace MoneyConverter
{
    internal class BaseMethod
    {
        public static void BankService(float money, float currency, MoneyConverters converters)
        {
            converters(money, currency);
        }
    }
}
