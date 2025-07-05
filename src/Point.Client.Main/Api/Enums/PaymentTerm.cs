using System.ComponentModel;

namespace Point.Client.Main.Api.Enums
{
    public enum PaymentTerm
    {
        [Description("30 Days")]
        Mothly,

        [Description("60 Days")]
        Bimonthly
    }
}
