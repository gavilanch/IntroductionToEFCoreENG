﻿// <auto-generated />
using System;
using IntroductionToEFCoreENG;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IntroductionToEFCoreENG.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230124133449_TonsOfData")]
    partial class TonsOfData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("GenresId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("GenreMovie");

                    b.HasData(
                        new
                        {
                            GenresId = 5,
                            MoviesId = 2
                        },
                        new
                        {
                            GenresId = 5,
                            MoviesId = 3
                        },
                        new
                        {
                            GenresId = 6,
                            MoviesId = 4
                        });
                });

            modelBuilder.Entity("IntroductionToEFCoreENG.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<decimal>("Fortune")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortune = 15000m,
                            Name = "Samuel L. Jackson"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortune = 18000m,
                            Name = "Robert Downey Jr."
                        });
                });

            modelBuilder.Entity("IntroductionToEFCoreENG.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<bool>("Recommend")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Content = "Very good!!!",
                            MovieId = 2,
                            Recommend = true
                        },
                        new
                        {
                            Id = 3,
                            Content = "I love it!",
                            MovieId = 2,
                            Recommend = true
                        },
                        new
                        {
                            Id = 4,
                            Content = "They shouldn't have done that",
                            MovieId = 3,
                            Recommend = false
                        });
                });

            modelBuilder.Entity("IntroductionToEFCoreENG.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Animation"
                        });
                });

            modelBuilder.Entity("IntroductionToEFCoreENG.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("InTheaters")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            InTheaters = false,
                            ReleaseDate = new DateTime(2019, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Avengers Endgame"
                        },
                        new
                        {
                            Id = 3,
                            InTheaters = false,
                            ReleaseDate = new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Spider-Man: No Way Home"
                        },
                        new
                        {
                            Id = 4,
                            InTheaters = false,
                            ReleaseDate = new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Spider-Man: Across the Spider-Verse (Part One)"
                        });
                });

            modelBuilder.Entity("IntroductionToEFCoreENG.Entities.MovieActor", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Character")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MoviesActors");

                    b.HasData(
                        new
                        {
                            ActorId = 2,
                            MovieId = 3,
                            Character = "Nick Fury",
                            Order = 1
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 2,
                            Character = "Nick Fury",
                            Order = 2
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 2,
                            Character = "Iron Man",
                            Order = 1
                        });
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("IntroductionToEFCoreENG.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IntroductionToEFCoreENG.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IntroductionToEFCoreENG.Entities.Comment", b =>
                {
                    b.HasOne("IntroductionToEFCoreENG.Entities.Movie", "Movie")
                        .WithMany("Comments")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("IntroductionToEFCoreENG.Entities.MovieActor", b =>
                {
                    b.HasOne("IntroductionToEFCoreENG.Entities.Actor", "Actor")
                        .WithMany("MoviesActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IntroductionToEFCoreENG.Entities.Movie", "Movie")
                        .WithMany("MoviesActors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("IntroductionToEFCoreENG.Entities.Actor", b =>
                {
                    b.Navigation("MoviesActors");
                });

            modelBuilder.Entity("IntroductionToEFCoreENG.Entities.Movie", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("MoviesActors");
                });
#pragma warning restore 612, 618
        }
    }
}
