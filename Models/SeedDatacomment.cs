using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedDatacomment
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
                    new comment
                    {
                        Name = "When Harry Met Sally",
                        ImageUrl=,
                        Content=,"When Harry Met Sally"
                        Author=' nguyenquanghuy'
                        CreatedAt= 7.99M
                    },

                    new comment
                     {
                        Name = "When Harry Met Sally",
                        ImageUrl=,
                        Content=,"When Harry Met Sally"
                        Author=' nguyenquanghuy'
                        CreatedAt= 7.99M
                    },
,

                    new comment
                    {
                        Name = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                        
                    },

                    new comment
                    {
                        Name = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                        
                    },
                      new comment
                    {
                        Name = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                        
                    },
                       new comment 
                    {
                        Name = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                        
                    }
                );
                context.SaveChanges();
            }
        }
    }
}