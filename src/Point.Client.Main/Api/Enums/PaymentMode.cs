using System.ComponentModel;

namespace Point.Client.Main.Api.Enums
{
    public enum PaymentMode
    {
        Cash,

        [Description("Digital Wallet")]
        DigitalWallet,

        [Description("Bank Transfer")]
        BankTransfer
    }
}
