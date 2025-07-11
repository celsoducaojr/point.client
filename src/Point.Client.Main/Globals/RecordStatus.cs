﻿namespace Point.Client.Main.Globals
{
    public static class RecordStatus
    {
        #region Orders

        public static class Customers
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

            public static void Updated()
            {
                LastUpdate = DateTime.Now;
            }
        }

        public static class Orders
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

            public static event Action OnDataUpdated;
            public static void Updated()
            {
                LastUpdate = DateTime.Now;

                OnDataUpdated?.Invoke();
            }
        }

        #endregion

        #region Listing

        public static class ItemUnits
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

            public static void Updated()
            {
                LastUpdate = DateTime.Now;
            }
        }

        public static class Items
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

            public static void Updated()
            {
                LastUpdate = DateTime.Now;
            }
        }

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

            public static void Updated()
            {
                LastUpdate = DateTime.Now;
            }
        }

        #endregion
    }
}
