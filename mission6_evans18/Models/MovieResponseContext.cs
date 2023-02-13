using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission6_evans18.Models
{
    public class MovieResponseContext : DbContext
    {
        //Constructor
        public MovieResponseContext(DbContextOptions<MovieResponseContext> options): base (options)
        {
            //leave blank for now
        }

        public DbSet<MovieResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(

                new MovieResponse
                {
                    MovieID = 1,
                    Category = "Family/Comedy",
                    Title = "Elf", 
                    Year = "2003",
                    Director = "Jon Favreau",
                    Rating = "PG",
                    Edited = false,
                    LentTo = null,
                    Notes = null,


                },

                new MovieResponse
                {
                    MovieID = 2,
                    Category = "Action/Adventure",
                    Title = "The Batman",
                    Year = "2022",
                    Director = "Matt Reeves",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Darker than the others",
                },

                new MovieResponse
                {
                    MovieID = 3,
                    Category = "Comedy",
                    Title = "Step Brothers",
                    Year = "2008",
                    Director = "Adam McKay",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = "funniest movie",
                }
            );
        }


    }
}
