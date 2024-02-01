﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2456),
                            Email = "klara.andersson@telia.com",
                            Name = "Klara Andersson",
                            Phone = "123854",
                            UpdatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2529)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2533),
                            Email = "peter.andersson@telia.com",
                            Name = "Peter Andersson",
                            Phone = "467215",
                            UpdatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2535)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2538),
                            Email = "arvid.andersson@telia.com",
                            Name = "Arvid Andersson",
                            Phone = "8751345",
                            UpdatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2540)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rating");

                    b.Property<int>("RuntimeMins")
                        .HasColumnType("integer")
                        .HasColumnName("runtime_mins");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2648),
                            Description = "Adaption of the greatest book",
                            Rating = "PG-13",
                            RuntimeMins = 160,
                            Title = "Throne of Glass",
                            UpdatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2651)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2655),
                            Description = "A girl assassin saves the city",
                            Rating = "PG-20",
                            RuntimeMins = 200,
                            Title = "Queen of Shadows",
                            UpdatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2657)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2660),
                            Description = "Riding dragons",
                            Rating = "PG-10",
                            RuntimeMins = 100,
                            Title = "Fourth Wing",
                            UpdatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2662)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screen_number");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("starts_at");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("screening");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieId = 2,
                            Capacity = 40,
                            CreatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2674),
                            ScreenNumber = 5,
                            StartsAt = new DateTime(2024, 1, 31, 23, 0, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2676)
                        },
                        new
                        {
                            Id = 2,
                            MovieId = 3,
                            Capacity = 100,
                            CreatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2684),
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2024, 1, 31, 23, 0, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2686)
                        },
                        new
                        {
                            Id = 3,
                            MovieId = 1,
                            Capacity = 20,
                            CreatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2691),
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2024, 1, 31, 23, 0, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2693)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", "Movie")
                        .WithMany("Screenings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Navigation("Screenings");
                });
#pragma warning restore 612, 618
        }
    }
}
