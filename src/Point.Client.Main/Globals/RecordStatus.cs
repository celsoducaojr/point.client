using System.Security.Cryptography.X509Certificates;

namespace Point.Client.Main.Globals
{
    public static class RecordStatus
    {
        public static class Domain
        {
            public static class Listing
            {
                public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

                public static event Action OnDataUpdated;
                public static void Updated(DateTime? dateTime)
                {
                    LastUpdate = dateTime;
                    OnDataUpdated?.Invoke();
                }
            }
        }

        #region Orders

        public static class Customers
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

            public static event Action OnDataUpdated;
            public static void Updated()
            {
                LastUpdate = DateTime.Now;
                OnDataUpdated?.Invoke();
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

            public static event Action OnDataUpdated;
            public static void Updated()
            {
                LastUpdate = DateTime.Now;
                OnDataUpdated?.Invoke();

                Domain.Listing.Updated(LastUpdate);
            }
        }

        public static class Items
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

            public static event Action OnDataUpdated;
            public static void Updated()
            {
                LastUpdate = DateTime.Now;
                OnDataUpdated?.Invoke();

                Domain.Listing.Updated(LastUpdate);
            }
        }

        public static class Categories
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

            public static event Action OnDataUpdated;
            public static void Updated()
            {
                LastUpdate = DateTime.Now;
                OnDataUpdated?.Invoke();

                Domain.Listing.Updated(LastUpdate);
            }
        }

        public static class Units
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

            public static event Action OnDataUpdated;
            public static void Updated()
            {
                LastUpdate = DateTime.Now;
                OnDataUpdated?.Invoke();

                Domain.Listing.Updated(LastUpdate);
            }
        }

        public static class PriceTypes
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

            public static event Action OnDataUpdated;
            public static void Updated()
            {
                LastUpdate = DateTime.Now;
                OnDataUpdated?.Invoke();

                Domain.Listing.Updated(LastUpdate);
            }
        }

        public static class Tags
        {
            public static DateTime? LastUpdate { get; private set; } = DateTime.Now;

            public static event Action OnDataUpdated;
            public static void Updated()
            {
                LastUpdate = DateTime.Now;
                OnDataUpdated?.Invoke();

                Domain.Listing.Updated(LastUpdate);
            }
        }

        #endregion

        #region Stocks

        public static class Stocks
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
