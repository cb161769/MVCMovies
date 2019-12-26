using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCMovies.Models;
using System.Data.Entity;


namespace MVCMovies.Data
{
    public class authorsContext :DbContext 
    {
        public DbSet<authors> authors { get; set; }
    }
}