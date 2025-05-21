namespace Point.Client.Main.Constants
{
    public static class FormConstants
    {
        public const string AmountFormat = "N2";

        public static class Pagination
        {
            public const string TotalPagesCountLabel = "of {0}";

            public static readonly int[] PageSizes =
            [
                1,2
            ];
        }

        public static class DataGridViewColumn
        {
            public const string PriceTag = "PRICETAG";
        }
    }
}
