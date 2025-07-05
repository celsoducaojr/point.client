namespace Point.Client.Main.Api.Extensions
{
    public static class StringExtensions
    {
        public static string ToOrderNumberString(this string number)
        {
            return $"Order {number}";    
        }

        public static decimal ToAmountDecimal(this string value)
        {
            return decimal.TryParse(value, out var amount) ? amount : 0;
        }
    }
}
