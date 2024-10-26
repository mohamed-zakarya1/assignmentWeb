﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using web.data;

#nullable disable

namespace web.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("web.data.models.category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "19th-century art movement characterized by small, thin brush strokes and emphasis on light and movement.",
                            Name = "Impressionism"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A period in European history marking the revival of classical learning and wisdom.",
                            Name = "Renaissance"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Art that uses shapes, colors, forms, and gestural marks to achieve its effect rather than depicting objects.",
                            Name = "Abstract"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A broad category that reflects artistic work produced during the late 19th to mid-20th century.",
                            Name = "Modern"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Art from ancient civilizations, including Egyptian, Mesopotamian, and classical Greek.",
                            Name = "Ancient"
                        });
                });

            modelBuilder.Entity("web.data.models.loyaltyCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "10% Off",
                            Name = "Bronze"
                        },
                        new
                        {
                            Id = 2,
                            Description = "20% Off",
                            Name = "Silver"
                        },
                        new
                        {
                            Id = 3,
                            Description = "30% Off",
                            Name = "Gold"
                        },
                        new
                        {
                            Id = 4,
                            Description = "40% Off",
                            Name = "Platinum"
                        },
                        new
                        {
                            Id = 5,
                            Description = "50% Off",
                            Name = "Crystal"
                        });
                });

            modelBuilder.Entity("web.data.models.pieceOfArt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Publication_date")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("userId");

                    b.ToTable("Arts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Price = "100000",
                            Publication_date = new DateTime(1889, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Starry Night"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Price = "500000",
                            Publication_date = new DateTime(1503, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Mona Lisa"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Price = "120000",
                            Publication_date = new DateTime(1923, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Composition VIII"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            Price = "200000",
                            Publication_date = new DateTime(1931, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Persistence of Memory"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            Price = "150000",
                            Publication_date = new DateTime(2500, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Small Pyramid"
                        });
                });

            modelBuilder.Entity("web.data.models.user", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LoyaltyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("age")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoyaltyId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "johndoe@example.com",
                            LoyaltyId = 1,
                            Name = "John Doe",
                            age = 30
                        },
                        new
                        {
                            Id = 2,
                            Email = "janesmith@example.com",
                            LoyaltyId = 2,
                            Name = "Jane Smith",
                            age = 25
                        },
                        new
                        {
                            Id = 3,
                            Email = "michaelj@example.com",
                            LoyaltyId = 3,
                            Name = "Michael Johnson",
                            age = 35
                        },
                        new
                        {
                            Id = 4,
                            Email = "sarahc@example.com",
                            LoyaltyId = 4,
                            Name = "Sarah Connor",
                            age = 28
                        },
                        new
                        {
                            Id = 5,
                            Email = "tonystark@example.com",
                            LoyaltyId = 5,
                            Name = "Tony Stark",
                            age = 45
                        });
                });

            modelBuilder.Entity("web.data.models.pieceOfArt", b =>
                {
                    b.HasOne("web.data.models.category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("web.data.models.user", "User")
                        .WithMany()
                        .HasForeignKey("userId");

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("web.data.models.user", b =>
                {
                    b.HasOne("web.data.models.loyaltyCard", "Card")
                        .WithMany()
                        .HasForeignKey("LoyaltyId");

                    b.Navigation("Card");
                });
#pragma warning restore 612, 618
        }
    }
}
