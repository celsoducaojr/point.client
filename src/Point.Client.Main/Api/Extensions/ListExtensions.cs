using Point.Client.Main.Constants;

namespace Point.Client.Main.Api.Extensions
{
    public static class ListExtensions
    {
        public static string ToSearchResultLabel(this List<string> list, int length = 80)
        {
            var strings = string.Join(", ", list.Where(s => !string.IsNullOrWhiteSpace(s)).ToList());
            if (strings.Length > length) strings = strings.Substring(0, length);
            return string.Format("Search results for '{0}'...", strings);
        }
    }
}
