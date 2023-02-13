﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission6_evans18.Models;

namespace mission6_evans18.Migrations
{
    [DbContext(typeof(MovieResponseContext))]
    partial class MovieResponseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("mission6_evans18.Models.MovieResponse", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Family/Comedy",
                            Director = "Jon Favreau",
                            Edited = false,
                            Rating = "PG",
                            Title = "Elf",
                            Year = "2003"
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Action/Adventure",
                            Director = "Matt Reeves",
                            Edited = false,
                            LentTo = "",
                            Notes = "Darker than the others",
                            Rating = "PG-13",
                            Title = "The Batman",
                            Year = "2022"
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Comedy",
                            Director = "Adam McKay",
                            Edited = false,
                            LentTo = "",
                            Notes = "funniest movie",
                            Rating = "R",
                            Title = "Step Brothers",
                            Year = "2008"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
