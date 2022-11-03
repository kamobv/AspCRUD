using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspCRUD.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [NotMapped]
        public decimal TotalPrice { get { return Quantity * Price; } }
    }
}