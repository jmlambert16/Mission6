using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<AddMovie> addMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddMovie>().HasData(

                    new AddMovie
                    {
                        MovieId = 1,
                        Category = "Action",
                        Title = "Spider-Man",
                        Year = 2002,
                        Director = "Sam Raimi",
                        Rating = "PG-13"
                    },

                    new AddMovie
                    {
                        MovieId = 2,
                        Category = "Sport/Drama",
                        Title = "Invincible",
                        Year = 2006,
                        Director = "M. Night Shyamalan",
                        Rating = "PG"
                    },

                    new AddMovie
                    {
                        MovieId = 3,
                        Category = "Comedy/Christmas/Musical ",
                        Title = "spirited ",
                        Year = 2022,
                        Director = "Sean Anders",
                        Rating = "PG-13"
                    }
                );
        }
    }
}
