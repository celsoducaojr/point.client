using Point.Client.Main.Api.Entities.Orders;

namespace Point.Client.Main.Api.Extensions
{
    public static class OrderExtensions
    {
        public static string GenerateOrderNumberString(this Order? order)
        {
            return $"Order {order?.Number}";
        }

        public static decimal GenerateTotalPayment(this Order? order)
        {
            return order?.Payments?.Sum(payment => payment.Amount) ?? 0;
        }

        public static decimal GenerateTotalRefund(this Order? order)
        {
            return order?.Refunds?.Sum(payment => payment.Amount) ?? 0;
        }

        public static decimal GenerateBalance(this Order? order)
        {
            return order?.Total - order?.GenerateTotalPayment() ?? 0;
        }

        public static DateTime? GetLastPayment(this Order? order)
        {
            return order?.Payments?.Max(payment => payment.Created) ?? null;
        }
    }
}
