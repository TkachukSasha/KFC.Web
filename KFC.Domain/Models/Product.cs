using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KFC.Domain.Models
{
    public sealed class Product : DomainObject
    {
        [Required]
        [StringLength(40, ErrorMessage ="Product name can't be more than 40 symbols!")]
        public string ProductName { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Product description can't be more than 200 symbols!")]
        public string ProductDescription { get; set; }

        [Required]
        [Range(0,500)]
        public int ProductAmount { get; set; }

        [Required]
        public SizeOfProduct ProductSize { get; set; }

        [Required]
        [Range(0,1000)]
        public decimal ProductPrice { get; set; }

        [Required]
        public string ProductPhoto { get; set; }

        public Product(int id, string productname, string productdescription, int productamount, SizeOfProduct productsize, decimal productprice, string productphoto)
        {
            Id = id;
            ProductName = productname;
            ProductDescription = productdescription;
            ProductAmount = productamount;
            ProductSize = productsize;
            ProductPrice = productprice;
            ProductPhoto = productphoto;
        }
    }
}
