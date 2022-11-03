using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspCRUD.Models
{
    public class Movies
    {
        public int Id { get; set; }
        [Display(Name = "Kino adi")]
        [Required(ErrorMessage = "Ad sahesi bos ola bilmez!")]
        [MinLength(3, ErrorMessage = "Ad sahesi en azi 3 xarakter olmalidir!")]
        [MaxLength(150, ErrorMessage = "Ad sahesi en coxu 150 xarakter ola biler")]
        public string Name { get; set; }
        [Display(Name = "Muddet")]
        [Required(ErrorMessage = "Muddet sahesi bos ola bilmez!")]
        [Range(30,240, ErrorMessage = "Muddet 30-240 deqiqe araliginda olmalidir!")]
        public int Duration { get; set; }
        [Required]
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}