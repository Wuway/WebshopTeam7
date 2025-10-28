using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopTeam7.Model
{
    public class Order
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
        public int Customer { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public double OrderTotal { get; set; }
        //paymentmethod int?
        public PayMethod PaymentMethod { get; set; }




        public Order(int orderId, int customer, DateTime date)
        {
            OrderId = orderId;
            Date = date;
            Customer = customer;
        }

        public override string ToString()
        {
            return $"Order ID: {OrderId}, Customer: {Customer}, Date: {Date}, Status: {Status}, Total: {OrderTotal:C}, Payment Method: {PaymentMethod}";
        }
    }
}
