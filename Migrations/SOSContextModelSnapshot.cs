﻿// <auto-generated />
using System;
using HendrixSOSResources.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HendrixSOSResources.Migrations
{
    [DbContext(typeof(SOSContext))]
    partial class SOSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("SOSResources.Models.Profile", b =>
                {
                    b.Property<string>("CampusEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("CampusAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Classification")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CurrentEmployer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentEmployerPhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmFirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmLastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmPhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmRelationship")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FinAidStatement")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("HendrixID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobPosition")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("MonthlyWages")
                        .HasColumnType("TEXT");

                    b.Property<int>("Pay")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PayPeriod")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReferredBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CampusEmail");

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            CampusEmail = "student1@hendrix.edu",
                            CampusAddress = "Veasey Hall 101",
                            Classification = 0,
                            CurrentEmployer = "null",
                            CurrentEmployerPhoneNumber = "null",
                            EmEmail = "bob.smith@email.com",
                            EmFirstName = "Bob",
                            EmLastName = "Smith",
                            EmPhoneNumber = "501-987-6543",
                            EmRelationship = "Father",
                            Email = "alice.smith@email.com",
                            FinAidStatement = "Receiving partial financial aid.",
                            FirstName = "Alice",
                            HendrixID = 1001,
                            JobPosition = "null",
                            LastName = "Smith",
                            MonthlyWages = 15m,
                            Pay = 0,
                            PayPeriod = 7,
                            PhoneNumber = "501-123-4567",
                            ReferredBy = "Orientation Leader"
                        },
                        new
                        {
                            CampusEmail = "staff.jones@hendrix.edu",
                            CampusAddress = "Admin Building, Office 210",
                            Classification = 6,
                            CurrentEmployer = "Hendrix College",
                            CurrentEmployerPhoneNumber = "501-450-1000",
                            EmEmail = "diana.jones@email.com",
                            EmFirstName = "Diana",
                            EmLastName = "Jones",
                            EmPhoneNumber = "501-777-8899",
                            EmRelationship = "Spouse",
                            Email = "charlie.jones@work.com",
                            FinAidStatement = "null",
                            FirstName = "Charlie",
                            HendrixID = 2005,
                            JobPosition = "Administrative Assistant",
                            LastName = "Jones",
                            MonthlyWages = 3500.00m,
                            Pay = 1,
                            PayPeriod = 4,
                            PhoneNumber = "501-555-1212",
                            ReferredBy = "Human Resources"
                        },
                        new
                        {
                            CampusEmail = "prof.evans@hendrix.edu",
                            CampusAddress = "Ellis Hall, Room 305",
                            Classification = 5,
                            CurrentEmployer = "Hendrix College",
                            CurrentEmployerPhoneNumber = "501-450-1000",
                            EmEmail = "frank.evans@email.com",
                            EmFirstName = "Frank",
                            EmLastName = "Evans",
                            EmPhoneNumber = "501-222-3344",
                            EmRelationship = "Brother",
                            Email = "emily.evans@hendrix.edu",
                            FinAidStatement = "null",
                            FirstName = "Emily",
                            HendrixID = 3010,
                            JobPosition = "Professor of Biology",
                            LastName = "Evans",
                            MonthlyWages = 6000.00m,
                            Pay = 1,
                            PayPeriod = 6,
                            PhoneNumber = "501-333-9999",
                            ReferredBy = "Department Chair"
                        });
                });

            modelBuilder.Entity("SOSResources.Models.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CampusEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("NeedWithin24Hours")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProfileCampusEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Reason")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResourceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfileCampusEmail");

                    b.HasIndex("ResourceId");

                    b.ToTable("Requests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CampusEmail = "student1@hendrix.edu",
                            CreatedAt = new DateTime(2025, 4, 21, 15, 34, 34, 727, DateTimeKind.Local).AddTicks(160),
                            NeedWithin24Hours = true,
                            Reason = "Scraped my knee playing intramurals.",
                            ResourceId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            CampusEmail = "student1@hendrix.edu",
                            CreatedAt = new DateTime(2025, 4, 18, 15, 34, 34, 727, DateTimeKind.Local).AddTicks(170),
                            NeedWithin24Hours = false,
                            Reason = "Ran out of toothpaste.",
                            ResourceId = 5,
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            CampusEmail = "staff.jones@hendrix.edu",
                            CreatedAt = new DateTime(2025, 4, 22, 15, 34, 34, 727, DateTimeKind.Local).AddTicks(200),
                            NeedWithin24Hours = false,
                            Reason = "Dealing with a headache.",
                            ResourceId = 3,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            CampusEmail = "prof.evans@hendrix.edu",
                            CreatedAt = new DateTime(2025, 4, 16, 15, 34, 34, 727, DateTimeKind.Local).AddTicks(220),
                            NeedWithin24Hours = false,
                            Reason = "For my lab's first aid kit.",
                            ResourceId = 2,
                            Status = 1
                        });
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
                            Type = 4
                        },
                        new
                        {
                            ID = 2,
                            Description = "Alcohol-based antiseptic wipes",
                            Name = "Antiseptic Wipes",
                            Quantity = 200,
                            Type = 4
                        },
                        new
                        {
                            ID = 3,
                            Description = "Ibuprofen and acetaminophen",
                            Name = "Pain Relievers",
                            Quantity = 150,
                            Type = 4
                        },
                        new
                        {
                            ID = 4,
                            Description = "Cough suppressant syrup",
                            Name = "Cough Syrup",
                            Quantity = 50,
                            Type = 4
                        },
                        new
                        {
                            ID = 5,
                            Description = "Fluoride toothpaste",
                            Name = "Toothpaste",
                            Quantity = 75,
                            Type = 1
                        },
                        new
                        {
                            ID = 6,
                            Description = "Gentle shampoo for daily use",
                            Name = "Shampoo",
                            Quantity = 60,
                            Type = 1
                        },
                        new
                        {
                            ID = 7,
                            Description = "Antiperspirant deodorant",
                            Name = "Deodorant",
                            Quantity = 80,
                            Type = 1
                        },
                        new
                        {
                            ID = 8,
                            Description = "Moisturizing lotion",
                            Name = "Lotion",
                            Quantity = 90,
                            Type = 1
                        },
                        new
                        {
                            ID = 9,
                            Description = "Advanced calculus textbook",
                            Name = "Calculus Textbook",
                            Quantity = 30,
                            Type = 7
                        },
                        new
                        {
                            ID = 10,
                            Description = "Introductory biology textbook",
                            Name = "Biology Textbook",
                            Quantity = 40,
                            Type = 7
                        });
                });

            modelBuilder.Entity("SOSResources.Models.Request", b =>
                {
                    b.HasOne("SOSResources.Models.Profile", null)
                        .WithMany("Requests")
                        .HasForeignKey("ProfileCampusEmail");

                    b.HasOne("SOSResources.Models.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("SOSResources.Models.Profile", b =>
                {
                    b.Navigation("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}
