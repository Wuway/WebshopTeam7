using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopTeam7.Model
{
    internal class Order
    {
        //OrderStatus enum til at repræsentere ordre status?
        public enum OrderStatus
        {
            Pending,
            Processing,
            Completed,
            Cancelled
        }
        //PaymentMethod enum til at repræsentere betalingsmetode?
        public enum PayMethod
        {
            CreditCard,
            PayPal,
            BankTransfer,
            MobilePay
        }

        public int OrderId { get; set; }
        //nullable hvis vi tillader folk til at lave ordre uden at lave en konto?
        public Customer UserId { get; set; } = null;
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public double OrderTotal { get; set; }
        //paymentmethod int?
        public PayMethod PaymentMethod { get; set; }




        public Order(int orderId, Customer userId, DateTime date, double orderTotal, PayMethod paymentMethod, OrderStatus status)
        {
            OrderId = orderId;
            Date = date;
            Status = status;
            OrderTotal = orderTotal;
            PaymentMethod = paymentMethod;
            UserId = userId;
        }

        public override string ToString()
        {
            return $"Order ID: {OrderId}, User: {UserId?.Name ?? "Guest"}, Date: {Date}, Status: {Status}, Total: {OrderTotal:C}, Payment Method: {PaymentMethod}";
        }
    }
}
