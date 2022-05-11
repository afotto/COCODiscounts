﻿// <auto-generated />
using System;
using DiscountAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DiscountAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DiscountAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Sodas"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Cleaning"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Food"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Bathroom"
                        });
                });

            modelBuilder.Entity("DiscountAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Cold Ice Tea",
                            Name = "Cold Ice Tea",
                            Price = 10.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Coffee flavoured milk",
                            Name = "Coffee flavoured milk",
                            Price = 12.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Nuke-Cola",
                            Name = "Nuke-Cola",
                            Price = 14.0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Sprute",
                            Name = "Sprute",
                            Price = 16.0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Slurm",
                            Name = "Slurm",
                            Price = 18.0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "Diet Slurm",
                            Name = "Diet Slurm",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Atlantis detergent",
                            Name = "Atlantis detergent",
                            Price = 22.0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "Virulanita",
                            Name = "Virulanita",
                            Price = 24.0
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = "Sponge, Bob",
                            Name = "Sponge, Bob",
                            Price = 26.0
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "Generic mop",
                            Name = "Generic mop",
                            Price = 28.0
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Salsa Cookies",
                            Name = "Salsa Cookies",
                            Price = 30.0
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Description = "Windmill Cookies",
                            Name = "Windmill Cookies",
                            Price = 32.0
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Description = "Garlic-o-bread 2000",
                            Name = "Garlic-o-bread 2000",
                            Price = 34.0
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Description = "LACTEL bread",
                            Name = "LACTEL bread",
                            Price = 36.0
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Description = "Ravioloches x12",
                            Name = "Ravioloches x12",
                            Price = 38.0
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            Description = "Ravioloches x48",
                            Name = "Ravioloches x48",
                            Price = 40.0
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 3,
                            Description = "Milanga ganga",
                            Name = "Milanga ganga",
                            Price = 42.0
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            Description = "Milanga ganga napo",
                            Name = "Milanga ganga napo",
                            Price = 44.0
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "Pure steel toilet paper",
                            Name = "Pure steel toilet paper",
                            Price = 46.0
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "Generic soap",
                            Name = "Generic soap",
                            Price = 48.0
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Description = "PANTONE shampoo",
                            Name = "PANTONE shampoo",
                            Price = 50.0
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Description = "Cabbagegate toothpaste",
                            Name = "Cabbagegate toothpaste",
                            Price = 52.0
                        });
                });

            modelBuilder.Entity("DiscountAPI.Models.Stock", b =>
                {
                    b.Property<int>("StoreStockId")
                        .HasColumnType("int");

                    b.Property<int>("ProductStockId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("StoreStockId", "ProductStockId");

                    b.HasIndex("ProductStockId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("DiscountAPI.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CloseTime")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpenTime")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Store");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CloseTime = 22,
                            Name = "COCO Downtown",
                            OpenTime = 9
                        },
                        new
                        {
                            Id = 2,
                            CloseTime = 22,
                            Name = "COCO Bay",
                            OpenTime = 9
                        },
                        new
                        {
                            Id = 3,
                            CloseTime = 22,
                            Name = "COCO Mall",
                            OpenTime = 9
                        });
                });

            modelBuilder.Entity("DiscountAPI.Models.Product", b =>
                {
                    b.HasOne("DiscountAPI.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DiscountAPI.Models.Stock", b =>
                {
                    b.HasOne("DiscountAPI.Models.Product", "ProductStock")
                        .WithMany()
                        .HasForeignKey("ProductStockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiscountAPI.Models.Store", "StoreStock")
                        .WithMany()
                        .HasForeignKey("StoreStockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductStock");

                    b.Navigation("StoreStock");
                });
#pragma warning restore 612, 618
        }
    }
}
