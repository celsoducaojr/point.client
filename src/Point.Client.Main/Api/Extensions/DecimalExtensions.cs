using Point.Client.Main.Api.Entities.Orders;
using Point.Client.Main.Constants;

namespace Point.Client.Main.Api.Extensions
{
    public static class DecimalExtensions
    {
        public static string ToAmountString(this decimal value)
        {
            return value < 0 ? $"({Math.Abs(value):N2})" : value.ToString("N2");
        }
    }
}
