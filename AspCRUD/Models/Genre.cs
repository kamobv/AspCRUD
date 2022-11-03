using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspCRUD.Models
{
    public class Genre
    {
        public Genre()
        {
            Movies = new List<Movies>();
        }
        public int Id { get; set; }
        [Display(Name = "Janr adi")]
        [Required(ErrorMessage ="Ad sahesi bos ola bilmez!")]
        [MinLength(3,ErrorMessage = "Ad sahesi en azi 3 xarakter olmalidir!")]
        [MaxLength(150, ErrorMessage = "Ad sahesi en coxu 150 xarakter ola biler")]
        public string Name { get; set; }
        public virtual List<Movies> Movies { get; set; }
    }
}