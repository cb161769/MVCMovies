using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCMovies.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        [Required]

        public string title { get; set; }
        [Display(Name = "Release Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime releasedate { get; set; }
        public string Genre { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public int RevID { get; set; }
        public reviews reviews { get; set; }
        public ICollection<reviews> review { get; set; }
    }
   
}