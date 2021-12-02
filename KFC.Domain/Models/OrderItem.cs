using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KFC.Domain.Models
{
    public sealed class OrderItem 
    {

        private int count;

        public int Count 
        {
            get { return count; }
            set
            {
                count = value;
            }
        }

        [Required]
        public decimal Price { get; set; }

        public int ProductId { get; set; }

        public OrderItem(int productId, int count, decimal price)
        {

            if(count < 0)
            {
                throw new ArgumentOutOfRangeException("Count must be greater than 0");
            }

            Count = count;
            Price = price;
            ProductId = productId;
        }
    }
}
