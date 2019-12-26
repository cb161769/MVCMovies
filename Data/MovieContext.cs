using MVCMovies.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCMovies.Data
{
    public class MovieContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}