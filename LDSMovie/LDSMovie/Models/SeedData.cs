using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LDSMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LDSMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<LDSMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "The RM",
                         ReleaseDate = DateTime.Parse("2002-1-1"),
                         Genre = "Non-Fiction Comedy",
                         Price = 9.99M,
                         Rating = "PG"
                     },

                     new Movie
                     {
                         Title = "Other Side of Heaven",
                         ReleaseDate = DateTime.Parse("2000-1-1"),
                         Genre = "Non-Fiction",
                         Price = 9.99M,
                         Rating = "PG"
                     },

                     new Movie
                     {
                         Title = "Meet the Mormons",
                         ReleaseDate = DateTime.Parse("2010-1-1"),
                         Genre = "Non-Fiction Comedy",
                         Price = 9.99M,
                         Rating = "PG"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
