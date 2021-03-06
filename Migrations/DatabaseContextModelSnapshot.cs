﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vives_FrietShop.DataAccess;

namespace Vives_FrietShop.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Vives_FrietShop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Vives_FrietShop.Models.ShopItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Prijs")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ShopItems");
                });
            
            modelBuilder.Entity("Vives_FrietShop.Models.Orderline", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();

                b.Property<int>("OrderId")
                    .HasColumnType("int");

                b.Property<int>("ShopItemId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Orderlines");
            });

            modelBuilder.Entity("Vives_FrietShop.Models.Orderline", b =>
                {
                    b.HasOne("Vives_FrietShop.Models.Order", null)
                        .WithOne("OrderId")
                        .HasForeignKey("OrderId");

                    b.HasOne("Vives_FrietShop.Models.ShopItem", null)
                        .WithOne("ShopItemId")
                        .HasForeignKey("ShopItemId");
                });
            
#pragma warning restore 612, 618
        }
    }
}