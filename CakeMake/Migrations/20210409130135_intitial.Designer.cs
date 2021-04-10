﻿// <auto-generated />
using System;
using CakeMake.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CakeMake.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210409130135_intitial")]
    partial class intitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CakeMake.Models.Cake", b =>
                {
                    b.Property<int>("CakeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CakeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Cakes");

                    b.HasData(
                        new
                        {
                            CakeId = 1,
                            CategoryId = 1,
                            Description = "Cake Description 1",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCake-small.jpg",
                            ImageUrl = "\\Images\\chocolateCake.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Chocolate Cake 1",
                            Price = 4.95m
                        },
                        new
                        {
                            CakeId = 2,
                            CategoryId = 1,
                            Description = "Cake Description 2",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCake2-small.jpg",
                            ImageUrl = "\\Images\\chocolateCake2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Chocolate Cake 2",
                            Price = 3.95m
                        },
                        new
                        {
                            CakeId = 3,
                            CategoryId = 1,
                            Description = "Cake Description 3",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCake3-small.jpg",
                            ImageUrl = "\\Images\\chocolateCake3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Chocolate Cake 3",
                            Price = 5.75m
                        },
                        new
                        {
                            CakeId = 4,
                            CategoryId = 2,
                            Description = "Fruit Cake Description 1",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCake-small.jpg",
                            ImageUrl = "\\Images\\fruitCake.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Fruit Cake 1",
                            Price = 3.95m
                        },
                        new
                        {
                            CakeId = 5,
                            CategoryId = 2,
                            Description = "Fruit Cake Description 2",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCake2-small.jpg",
                            ImageUrl = "\\Images\\fruitCake2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Fruit Cake 2",
                            Price = 7.00m
                        },
                        new
                        {
                            CakeId = 6,
                            CategoryId = 2,
                            Description = "Fruit Cake Description 3",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCake3-small.jpg",
                            ImageUrl = "\\Images\\fruitCake3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Fruit Cake 3",
                            Price = 11.25m
                        },
                        new
                        {
                            CakeId = 7,
                            CategoryId = 3,
                            Description = "Jelly Cake Description 1",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\JellyCake-small.jpg",
                            ImageUrl = "\\Images\\JellyCake.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Jelly Cake 1",
                            Price = 3.95m
                        },
                        new
                        {
                            CakeId = 8,
                            CategoryId = 3,
                            Description = "Jelly Cake Description 2",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\JellyCake2-small.jpg",
                            ImageUrl = "\\Images\\JellyCake2.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Jelly Cake 2",
                            Price = 1.95m
                        },
                        new
                        {
                            CakeId = 9,
                            CategoryId = 3,
                            Description = "Jelly Cake Description 3",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\JellyCake3-small.jpg",
                            ImageUrl = "\\Images\\JellyCake3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Jelly Cake 3",
                            Price = 13.95m
                        },
                        new
                        {
                            CakeId = 10,
                            CategoryId = 4,
                            Description = "DarkChocolate Description Cake 1",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\DarkChocolateCake-small.jpg",
                            ImageUrl = "\\Images\\DarkChocolateCake.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "DarkChocolate Cake 1",
                            Price = 1.95m
                        },
                        new
                        {
                            CakeId = 11,
                            CategoryId = 4,
                            Description = "DarkChocolate Description Cake 2",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\DarkChocolateCake2-small.jpg",
                            ImageUrl = "\\Images\\DarkChocolateCake2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "DarkChocolate Cake 2",
                            Price = 12.95m
                        },
                        new
                        {
                            CakeId = 12,
                            CategoryId = 4,
                            Description = "DarkChocolate Description Cake 3",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\DarkChocolateCake3-small.jpg",
                            ImageUrl = "\\Images\\DarkChocolateCake3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "DarkChocolate Cake 3",
                            Price = 21.95m
                        },
                        new
                        {
                            CakeId = 13,
                            CategoryId = 5,
                            Description = "Vanilla Cake Description 1",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\VanillaCake-small.jpg",
                            ImageUrl = "\\Images\\VanillaCake.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Vanilla Cake 1",
                            Price = 6.95m
                        },
                        new
                        {
                            CakeId = 14,
                            CategoryId = 5,
                            Description = "Vanilla Cake Description 2",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\VanillaCake2-small.jpg",
                            ImageUrl = "\\Images\\VanillaCake2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Vanilla Cake 2",
                            Price = 2.95m
                        },
                        new
                        {
                            CakeId = 15,
                            CategoryId = 5,
                            Description = "Vanilla Cake Description 3",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\VanillaCake3-small.jpg",
                            ImageUrl = "\\Images\\VanillaCake3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Vanilla Cake 3",
                            Price = 16.95m
                        });
                });

            modelBuilder.Entity("CakeMake.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Chocolate Cake"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Fruit Cake"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Jelly Cake"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "DarkChocolate Cake"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Vanilla Cake"
                        });
                });

            modelBuilder.Entity("CakeMake.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CakeMake.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CakeId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("CakeId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("CakeMake.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpireDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HolderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("CakeMake.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CakeId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("CakeId");

                    b.ToTable("ShopppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CakeMake.Models.Cake", b =>
                {
                    b.HasOne("CakeMake.Models.Category", "Category")
                        .WithMany("Cakes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CakeMake.Models.OrderDetail", b =>
                {
                    b.HasOne("CakeMake.Models.Cake", "Cake")
                        .WithMany()
                        .HasForeignKey("CakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CakeMake.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cake");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("CakeMake.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("CakeMake.Models.Cake", "Cake")
                        .WithMany()
                        .HasForeignKey("CakeId");

                    b.Navigation("Cake");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CakeMake.Models.Category", b =>
                {
                    b.Navigation("Cakes");
                });

            modelBuilder.Entity("CakeMake.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
