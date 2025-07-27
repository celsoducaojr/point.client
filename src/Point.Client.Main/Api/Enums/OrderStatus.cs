using System.ComponentModel;

namespace Point.Client.Main.Api.Enums
{
    public enum OrderStatus
    {
        New,
        Released,

        [Description("Partially Paid")]
        PartiallyPaid,

        Paid,
        Refunded,
        Cancelled
    }
}
