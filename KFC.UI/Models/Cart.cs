using KFC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KFC.UI.Models
{
    public class Cart
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int TotalCount { get; set; }
        public decimal TotalPrice { get; set; }

        public Cart(int orderId)
        {
            OrderId = orderId;
            TotalCount = 0;
            TotalPrice = 0m;
        }
    }
}
