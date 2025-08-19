using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopTeam7.Model
{
    internal class OrderItem
    {
        public required Order OrderId { get; set; }
        public Product ProductId { get; set; }
        public double Amount { get; set; }


        public OrderItem(Order orderId, Product productId, double amount)
        {
            OrderId = orderId;
            ProductId = productId;
            Amount = amount;
        }
    }
}
