using Point.Client.Main.Api.Entities;

namespace Point.Client.Main.Globals
{
    public static class RecordStatus
    {
        public static class Category
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

            public static void Updated()
            {
                LastUpdate = DateTime.Now;
            }
        }

        public static class Tag
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

            public static void Updated()
            {
                LastUpdate = DateTime.Now;
            }
        }
    }
}
