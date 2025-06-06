﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250603231642_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("API.Entities.Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<int>("EatingOutRating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FavoriteFoods")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullNames")
                        .HasColumnType("TEXT");

                    b.Property<int>("ListeningRadioRating")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WatchingMoviesRating")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WatchingTvRating")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Surveys");
                });
#pragma warning restore 612, 618
        }
    }
}
