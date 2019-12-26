using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCMovies.Models;

namespace MVCMovies.Data
{
    public class reviewContext : DbContext
    {
        public DbSet<reviews> reviews { get; set; }
    }
}