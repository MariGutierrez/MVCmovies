using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using MvcMovies.Data;
using MvcMovies.Models;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMoviesContext(
        serviceProvider.GetRequiredService<
                DbContextOptions<MvcMoviesContext>>()))
        {
            // Look for any movies.
            //ESTE ARCHIVO SE EJECUTA CUANDO INICIA LA APLICACION
            //Valida si la tabla de movies esta vacia 
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    RealeaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "A"
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    RealeaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    RealeaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "D"
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    RealeaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "A"
                }
            );
            context.SaveChanges();
        }
    }
}