using Microsoft.EntityFrameworkCore;
using Mvc_Movie.Data;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Mvc_MovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<Mvc_MovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Home Alone",
                    ReleaseDate = DateTime.Parse("202-01-06"),
                    Genre = "Drama",
                    Price = 8.00M,
                    Rating = "A"
                },
                new Movie
                {
                    Title = "Home Alone 2 ",
                    ReleaseDate = DateTime.Parse("2021-01-30"),
                    Genre = "Drama",
                    Price = 7.00M,
                    Rating = "A"
                },
                new Movie
                {
                    Title = "IT",
                    ReleaseDate = DateTime.Parse ("2002-03-01"), 
                    Genre = "Horror",
                    Price = 10.00M,
                    Rating = "3.8"
                },
                new Movie
                {
                    Title = "1920",
                    ReleaseDate = DateTime.Parse("2020-05-21"),
                    Genre = "Horror",
                    Price = 6.00M,
                    Rating = "3.0"

                },
                 new Movie
                 {
                     Title = "Holidays",
                     ReleaseDate = DateTime.Parse("2023-01-01"),
                     Genre = "Romantic",
                     Price = 9.00M,
                     Rating = "4.9" 
                 }
            );
            context.SaveChanges();
        }
    }
}