using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCMovies.Models
{
    public class reviews
    {
        [Key]
        public int RevID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Text { get; set; }
        public int MovID { get; set; }
        public Movie Movie { get; set; } 
        
    }
}