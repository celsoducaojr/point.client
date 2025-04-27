using Point.Client.Main.Api.Entities;

namespace Point.Client.Main.Globals
{
    public static class RecordStatus
    {
        public static class Categories
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

            public static void Updated()
            {
                LastUpdate = DateTime.Now;
            }
        }

        public static class Tags
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

            public static void Updated()
            {
                LastUpdate = DateTime.Now;
            }
        }
    }
}
