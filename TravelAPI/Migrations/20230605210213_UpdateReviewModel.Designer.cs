﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelAPI.Models;

#nullable disable

namespace TravelAPI.Migrations
{
    [DbContext(typeof(TravelAPIContext))]
    [Migration("20230605210213_UpdateReviewModel")]
    partial class UpdateReviewModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelAPI.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ReviewCountry")
                        .HasColumnType("longtext");

                    b.Property<string>("ReviewDestination")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("ReviewRating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewUserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            ReviewCountry = "Space",
                            ReviewDestination = "Beach",
                            ReviewRating = 8,
                            ReviewUserName = "me"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
