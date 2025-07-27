using System.ComponentModel;

namespace Point.Client.Main.Globals.Common.Enums
{
    public enum PaymentType
    {
        [Description("Partial Payment")]
        PartialPayment,

        [Description("Full Payment")]
        FullPayment
    }
}
