using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KFC.Domain.Models
{
    public sealed class ProductMenu : DomainObject
    {
        [Required]
        [StringLength(40, ErrorMessage ="Menu name can't be more than 40 symbols!")]
        public string MenuName { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Menu name can't be more than 40 symbols!")]
        public string MenuDescription { get; set; }

        [Required]
        [Range(0,1000)]
        public decimal MenuPrice { get; set; }
    }
}
