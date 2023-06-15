using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The Saratov Approach",
                    ReleaseDate = DateTime.Parse("2013-10-9"),
                    Genre = "Drama",
                    Price = 19.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "17 Miracles",
                    ReleaseDate = DateTime.Parse("2011-6-3"),
                    Genre = "Adventure-Drama",
                    Price = 9.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "The Best Two Years",
                    ReleaseDate = DateTime.Parse("2004-9-7"),
                    Genre = "Comedy-Drama",
                    Price = 19.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "The Other Side of Heaven",
                    ReleaseDate = DateTime.Parse("2001-12-14"),
                    Genre = "Adventure-Drama",
                    Price = 15.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Ephraim's Rescue",
                    ReleaseDate = DateTime.Parse("2013-5-31"),
                    Genre = "Adventure-Drama",
                    Price = 19.99M,
                    Rating = "PG"
                }
            );
            context.SaveChanges();
        }
    }
}