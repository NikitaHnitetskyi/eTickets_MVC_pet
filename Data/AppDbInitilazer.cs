
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace eTickets.Data
{
    public class AppDbInitilazer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo =
                            descriptio
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo =
                            des
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo =


                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo =


                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo =


                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = " "
                            prof
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo =
                            des
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo =


                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo =


                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo =


                        },
                    });
                    context.SaveChanges();


                    //Producers
                    if (!context.Producers.Any())
                    {

                    }
                    //Movies
                    if (!context.Movies.Any())
                    {

                    }
                    //Actors & Movies
                    if (!context.Actors_Movies.Any())
                    {

                    }

                }
            }
        }
    }
}
