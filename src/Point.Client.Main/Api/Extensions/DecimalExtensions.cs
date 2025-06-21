using Point.Client.Main.Constants;

namespace Point.Client.Main.Api.Extensions
{
    public static class DecimalExtensions
    {
        public static string ToAmountString(this decimal value)
        {
            return value.ToString(FormConstants.Formats.Amount) ?? string.Empty;
        }
    }
}
