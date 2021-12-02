using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KFC.UI.Models
{
    public class OrderItemModel
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public int Count { get; set; }

        public decimal Price { get; set; }
    }
}
