using Microsoft.EntityFrameworkCore;
using mission6_evans18.Models;
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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName="Family"},
                new Category { CategoryID = 2, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 3, CategoryName = "Comedy" },
                new Category { CategoryID = 4, CategoryName = "Horror" },
                new Category { CategoryID = 5, CategoryName = "Drama" },
                new Category { CategoryID = 6, CategoryName = "Television" },
                new Category { CategoryID = 7, CategoryName = "VHS" }

                );

            mb.Entity<MovieResponse>().HasData(

                new MovieResponse
                {
                    MovieID = 1,
                    CategoryID = 1,
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
                    CategoryID = 2,
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
                    CategoryID = 3,
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
