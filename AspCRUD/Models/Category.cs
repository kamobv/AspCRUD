using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspCRUD.Models
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [MinLength(2)]
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}