using DT191G_moment45.Data;
using DT191G_moment45.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;


namespace DT191G_moment45.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {


            // Artists
            using (var context = new CollectionContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CollectionContext>>()))
            {
                // Look for any Artists.
                if (context.Artist.Any())
                {
                    return;   // DB has been seeded
                }
                context.Artist.AddRange(
                    new Artist
                    {
                        Title = "Madonna"
                    },
                    new Artist
                    {
                        Title = "Tori Amos"
                    },
                    new Artist
                    {
                        Title = "Pearl Jam"
                    },
                    new Artist
                    {
                        Title = "Meatloaf"
                    },
                    new Artist
                    {
                        Title = "The Pixies"
                    }
                );
                context.SaveChanges();
            }

            // CD Albums
            using (var context = new CollectionContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CollectionContext>>()))
            {
                // Look for any CD Albums in collection.
                if (context.Collection.Any())
                {
                    return;   // DB has been seeded
                }
                context.Collection.AddRange(
                    new Collection
                    {
                        ArtistId = 1,
                        AlbumTitle = "Confessions on a Dance Floor",
                        ReleaseYear = "2005",
                        SongList = "Hung Up, Get Together, Sorry, Future Lovers, I Love New York, Let It Will Be, Forbidden Love, Jump, How High, Isaac, Push, Like It Or Not"
                    },
                    new Collection
                    {
                        ArtistId = 1,
                        AlbumTitle = "Hard Candy",
                        ReleaseYear = "2008",
                        SongList = "Hard Candy, Candy Shop, 4 Minutes, Give It 2 Me, Heartbeat, Miles Away, She's Not Me, Incredible, Beat Goes On, Dance 2night, Spanish Lesson, Devil Wouldn't Recognize You, Voices"
                    },
                    new Collection
                    {
                        ArtistId = 3,
                        AlbumTitle = "Ten",
                        ReleaseYear = "1991",
                        SongList = "Once, Even Flow, Alive, Why Go, Black, Jeremy, Oceans, Porch, Garden, Deep,Once, Even Flow, Alive, Why Go, Black, Jeremy, Oceans, Porch, Garden, Deep"
                    },
                    new Collection
                    {
                        ArtistId = 2,
                        AlbumTitle = "Little Earthquakes",
                        ReleaseYear = "1991",
                        SongList = "Crucify, Girl, Silent All These Years, Precious Things, Winter, Happy Phantom, China, Leather, Mother, Tear in Your Hand, Me and a Gun, Little Earthquakes"
                    },
                    new Collection
                    {
                        ArtistId = 5,
                        AlbumTitle = "Trompe le Monde",
                        ReleaseYear = "1991",
                        SongList = "Trompe le Monde, Planet of Sound, Alec Eiffel, The Sad Punk, Head On, U-Mass, Palace of the Brine, Letter to Memphis, Bird Dream of the Olympus Mons, Space (I Believe In), Subbacultcha, Distance Equals Rate Times Time, Lovely Day, Motorway to Roswell, The Navajo Know"
                    },
                    new Collection
                    {
                        ArtistId = 4,
                        AlbumTitle = "Bat Out of Hell II: Back into Hell",
                        ReleaseYear = "1993",
                        SongList = "I'd Do Anything for Love (But I Won't Do That), Life Is a Lemon and I Want My Money Back, Rock and Roll Dreams Come Through, It Just Won't Quit, Out of the Frying Pan (And into the Fire), Objects in the Rear View Mirror May Appear Closer Than They Are, Wasted Youth, Everything Louder than Everything Else, Good Girls Go to Heaven (Bad Girls Go Everywhere), Back into Hell, Lost Boys and Golden Girls"
                    }
                );
                context.SaveChanges();
            }

            // Friends
            using (var context = new CollectionContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CollectionContext>>()))
            {
                // Look for any Friends.
                if (context.Friends.Any())
                {
                    return;   // DB has been seeded
                }
                context.Friends.AddRange(
                    new Friends
                    {
                        Name = "Jennifer",
                        Email = "jennifer@email.com"
                    },
                    new Friends
                    {
                        Name = "Fredrik",
                        Email = "fredrik@email.com"
                    },
                    new Friends
                    {
                        Name = "Sanna",
                        Email = "sanna@email.com"
                    }
                );
                context.SaveChanges();
            }

            // Borrowed
            using (var context = new CollectionContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CollectionContext>>()))
            {
                // Look for any Borrowed.
                if (context.Borrowed.Any())
                {
                    return;   // DB has been seeded
                }
                context.Borrowed.AddRange(
                    new Borrowed
                    {
                        FriendId = 1,
                        CollectionId = 2
                    },
                    new Borrowed
                    {
                        FriendId = 2,
                        CollectionId = 4
                    },
                    new Borrowed
                    {
                        FriendId = 1,
                        CollectionId = 1
                    }
                );
                context.SaveChanges();
            }
            }
        }
    }




