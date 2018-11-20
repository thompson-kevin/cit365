using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LDSMovie.Models
{
    public class LDSMovieContext : DbContext
    {
        public LDSMovieContext (DbContextOptions<LDSMovieContext> options)
            : base(options)
        {
        }

        public DbSet<LDSMovie.Models.Movie> Movie { get; set; }
    }
}
