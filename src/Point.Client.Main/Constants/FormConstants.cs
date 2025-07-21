using Point.Client.Main.Api.Enums;

namespace Point.Client.Main.Constants
{
    public static class FormConstants
    {
        public static class Formats
        {
            public const string Amount = "N2";
            public const string Timestamp = "MMM dd, yyyy, hh:mm tt";
        }
       
        public static class Pagination
        {
            public const string TotalPagesCountLabel = "of {0}";

            public static readonly int[] PageSizes =
            [
                100, 250, 500
            ];
        }

        public static class DataGridView
        {
            public static class Columns
            {
                public const string Quantiy = "clmQuantity";
                public const string Price = "clmPrice";
            }

            public static class Tags
            {
                public const string Price = "PRICETAG";
            }
        }

        public static class Order
        {
            public static class StatusAction
            {
                public static string Release = "Release";
                public static string Cancel = "Cancel";
            }

            public static Dictionary<OrderStatus, string> StatusActionDictionary = new()
            {
                { OrderStatus.Released, StatusAction.Release },
                { OrderStatus.Cancelled, StatusAction.Cancel }
            };

            public static string ChangeStatusLabel = "Type '{0}' to update status...";
            public static string ChangeStatuslButtonLabel = "{0} ORDER";
        }

    }
}
