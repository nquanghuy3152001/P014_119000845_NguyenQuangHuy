using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedDataNews
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
                    new News
                    {
                        Name = "When Harry Met Sally",
                        {
                        ImageUrl=,
                        Content=,"When Harry Met Sally"
                        Author=' nguyenquanghuy'
                        CreatedAt= 7.99M
                    },
                        
                    },

                    new News
                    {
                        Name = "Ghostbusters ",
                    
                    },

                    new News
                    {
                        Name = "Ghostbusters 2",
                       
                    },

                    new News
                    {
                        Name = "Rio Bravo",
                        
                    }
                    new News
                    {
                        Name = "Rio Bravo",
                       
                    }
                );
                context.SaveChanges();
            }
        }
    }
}