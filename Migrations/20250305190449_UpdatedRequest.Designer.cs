﻿// <auto-generated />
using System;
using HendrixSOSResources.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HendrixSOSResources.Migrations
{
    [DbContext(typeof(SOSContext))]
    [Migration("20250305190449_UpdatedRequest")]
    partial class UpdatedRequest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("SOSResources.Models.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("NeedWithin24Hours")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ResourceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ResourceId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("SOSResources.Models.Resource", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Various sizes of bandages",
                            Name = "Bandages",
                            Quantity = 100,
                            Type = 0
                        },
                        new
                        {
                            ID = 2,
                            Description = "Alcohol-based antiseptic wipes",
                            Name = "Antiseptic Wipes",
                            Quantity = 200,
                            Type = 0
                        },
                        new
                        {
                            ID = 3,
                            Description = "Ibuprofen and acetaminophen",
                            Name = "Pain Relievers",
                            Quantity = 150,
                            Type = 1
                        },
                        new
                        {
                            ID = 4,
                            Description = "Cough suppressant syrup",
                            Name = "Cough Syrup",
                            Quantity = 50,
                            Type = 1
                        },
                        new
                        {
                            ID = 5,
                            Description = "Fluoride toothpaste",
                            Name = "Toothpaste",
                            Quantity = 75,
                            Type = 2
                        },
                        new
                        {
                            ID = 6,
                            Description = "Gentle shampoo for daily use",
                            Name = "Shampoo",
                            Quantity = 60,
                            Type = 2
                        },
                        new
                        {
                            ID = 7,
                            Description = "Antiperspirant deodorant",
                            Name = "Deodorant",
                            Quantity = 80,
                            Type = 3
                        },
                        new
                        {
                            ID = 8,
                            Description = "Moisturizing lotion",
                            Name = "Lotion",
                            Quantity = 90,
                            Type = 3
                        },
                        new
                        {
                            ID = 9,
                            Description = "Advanced calculus textbook",
                            Name = "Calculus Textbook",
                            Quantity = 30,
                            Type = 4
                        },
                        new
                        {
                            ID = 10,
                            Description = "Introductory biology textbook",
                            Name = "Biology Textbook",
                            Quantity = 40,
                            Type = 4
                        });
                });

            modelBuilder.Entity("SOSResources.Models.Request", b =>
                {
                    b.HasOne("SOSResources.Models.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resource");
                });
#pragma warning restore 612, 618
        }
    }
}
