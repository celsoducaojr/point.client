using Point.Client.Main.Api.Entities;

namespace Point.Client.Main.Globals
{
    public static class RecordStatus
    {
        public static class Category
        {
            public static DateTime LastUpdate { get; private set; }
            public static void Updated()
            {
                LastUpdate = DateTime.Now;
            }
        }
    }
}
