using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCMovies.Models
{
    public class authors
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Fecha de nacimiento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime BrithDate { get; set; }
    }
}