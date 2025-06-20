﻿namespace Point.Client.Main.Constants
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
                100, 200, 300
            ];
        }

        public static class DataGridView
        {
            public static class Columns
            {
                public const string Quantiy = "clmQuantity";
            }

            public static class Tags
            {
                public const string Price = "PRICETAG";
            }
        }

    }
}
