﻿// <auto-generated />
using System;
using FullstackBeatsBE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FullstackBeatsBE.Migrations
{
    [DbContext(typeof(FullstackBeatsBEDbContext))]
    [Migration("20241016062945_CategoryModel")]
    partial class CategoryModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FullstackBeatsBE.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Music"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Education"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gaming"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Presentation"
                        });
                });

            modelBuilder.Entity("FullstackBeatsBE.Models.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AirDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("HostId")
                        .HasColumnType("integer");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Rsvps")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("HostId");

                    b.ToTable("Shows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AirDate = new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 1,
                            Description = "Exploring the latest advancements in technology.",
                            HostId = 1,
                            Image = "future_tech.jpg",
                            Name = "Future Tech",
                            Rsvps = 120
                        },
                        new
                        {
                            Id = 2,
                            AirDate = new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 1,
                            Description = "How artificial intelligence is changing the world.",
                            HostId = 1,
                            Image = "ai_revolution.jpg",
                            Name = "AI Revolution",
                            Rsvps = 85
                        },
                        new
                        {
                            Id = 3,
                            AirDate = new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 2,
                            Description = "A live concert series featuring emerging artists.",
                            HostId = 2,
                            Image = "soundwave_live.jpg",
                            Name = "Soundwave Live",
                            Rsvps = 200
                        },
                        new
                        {
                            Id = 4,
                            AirDate = new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 2,
                            Description = "Exclusive interviews with top music producers.",
                            HostId = 2,
                            Image = "behind_the_beats.jpg",
                            Name = "Behind the Beats",
                            Rsvps = 150
                        },
                        new
                        {
                            Id = 5,
                            AirDate = new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 5,
                            Description = "A deep dive into the history of filmmaking.",
                            HostId = 3,
                            Image = "cinema_history.jpg",
                            Name = "Cinema History",
                            Rsvps = 95
                        },
                        new
                        {
                            Id = 6,
                            AirDate = new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 5,
                            Description = "Spotlighting indie filmmakers and their work.",
                            HostId = 3,
                            Image = "indie_scene.jpg",
                            Name = "The Indie Scene",
                            Rsvps = 110
                        });
                });

            modelBuilder.Entity("FullstackBeatsBE.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Uid")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "Loves exploring new gadgets and technologies.",
                            Email = "noahcurryallenpa@gmail.com",
                            Image = "tech_guru.png",
                            Uid = "fgikJy5FMVXz3M8t5DkBSzUp64i2",
                            UserName = "Noah"
                        },
                        new
                        {
                            Id = 2,
                            About = "Avid music lover with a passion for discovering new artists.",
                            Email = "deramust@gmail.com",
                            Image = "music_maven.jpg",
                            Uid = "MJ1mbp0Gm1dnXYqECtMh3PH5dHy2",
                            UserName = "Toren"
                        },
                        new
                        {
                            Id = 3,
                            About = "Movie enthusiast and amateur filmmaker.",
                            Email = "filmbuff@example.com",
                            Image = "film_buff.png",
                            Uid = "ghi789",
                            UserName = "film_buff"
                        });
                });

            modelBuilder.Entity("ShowUser", b =>
                {
                    b.Property<int>("AttendeeId")
                        .HasColumnType("integer");

                    b.Property<int>("WatchShowId")
                        .HasColumnType("integer");

                    b.HasKey("AttendeeId", "WatchShowId");

                    b.HasIndex("WatchShowId");

                    b.ToTable("UserShow", (string)null);
                });

            modelBuilder.Entity("FullstackBeatsBE.Models.Show", b =>
                {
                    b.HasOne("FullstackBeatsBE.Models.Category", "Category")
                        .WithMany("Show")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FullstackBeatsBE.Models.User", "Host")
                        .WithMany("HostShow")
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Host");
                });

            modelBuilder.Entity("ShowUser", b =>
                {
                    b.HasOne("FullstackBeatsBE.Models.User", null)
                        .WithMany()
                        .HasForeignKey("AttendeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FullstackBeatsBE.Models.Show", null)
                        .WithMany()
                        .HasForeignKey("WatchShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FullstackBeatsBE.Models.Category", b =>
                {
                    b.Navigation("Show");
                });

            modelBuilder.Entity("FullstackBeatsBE.Models.User", b =>
                {
                    b.Navigation("HostShow");
                });
#pragma warning restore 612, 618
        }
    }
}
