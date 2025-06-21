namespace Point.Client.Main.Api.Extensions
{
    public static class StringExtensions
    {
        public static decimal ToAmountDecimal(this string value)
        {
            return decimal.TryParse(value, out var amount) ? amount : 0;
        }
    }
}
