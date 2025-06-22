namespace Point.Client.Main.Api.Extensions
{
    public static class ObjectExtensiions
    {
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        public static T Parse<T>(this object obj) where T : class
        {
            return (T)obj;
        }
    }
}
