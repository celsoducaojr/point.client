﻿using Point.Client.Main.Api.Entities.Orders;

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
            if (order?.Payments == null) return 0;

            return order.Payments.Sum(payment => payment.Amount);
        }

        public static decimal GenerateBalance(this Order? order)
        {
            if (order == null) return 0;

            var payments = order.GenerateTotalPayment();
            return order.Total - payments;
        }

        public static DateTime? GetLastPayment(this Order? order)
        {
            if ( order == null || order.Payments == null) return null;

            return order.Payments.Max(payment => payment.Created);
        }
    }
}
