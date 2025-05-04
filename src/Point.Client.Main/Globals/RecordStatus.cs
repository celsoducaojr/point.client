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

        public static class Units
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

            public static void Updated()
            {
                LastUpdate = DateTime.Now;
            }
        }

        public static class PriceTypes
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;
            public static DateTime? IndexLastUpdate { get; private set; } = DateTime.Now;

            public static void Updated()
            {
                LastUpdate = DateTime.Now;
            }

            public static void IndexUpdated()
            {
                IndexLastUpdate = DateTime.Now;
            }
        }
    }
}
