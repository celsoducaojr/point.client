namespace Point.Client.Main.Api.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ConvertToLongDateString(this DateTime dateTime)
        {
            return dateTime.ToString("ddd, MMM dd, yyyy");
        }
    }
}
