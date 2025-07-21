using System.Runtime.CompilerServices;
using Point.Client.Main.Api.Entities.Orders;

namespace Point.Client.Main.Api.Extensions
{
    public static class PaymentExtensions
    {
        public static decimal GenerateTotal(this List<Payment>? payments)
        {
            if (payments == null) return 0;

            return payments.Sum(payment => payment.Amount);
        }
    }
}
