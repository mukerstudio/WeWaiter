﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WeWaiter.Data.Migrations;

namespace WeWaiter.Data.Migrations
{
    [DbContext(typeof(WeWaiterContext))]
    [Migration("20180806161301_InitailMigration")]
    partial class InitailMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("WeWaiter.Data.BuyItem", b =>
                {
                    b.Property<string>("BuyItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("GoodsID");

                    b.Property<string>("OrderID");

                    b.Property<int>("Total");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("BuyItemID");

                    b.ToTable("BuyItem");
                });

            modelBuilder.Entity("WeWaiter.Data.Goods", b =>
                {
                    b.Property<string>("GoodsID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BarCode");

                    b.Property<string>("Description");

                    b.Property<string>("FullName");

                    b.Property<decimal>("MinSellingPrice");

                    b.Property<string>("PictureURL");

                    b.Property<decimal>("PurchasePrice");

                    b.Property<string>("QRCode");

                    b.Property<decimal>("SellingPrice");

                    b.Property<string>("ShortName");

                    b.Property<int>("SoldOut");

                    b.Property<int>("Status");

                    b.Property<int>("Stock");

                    b.HasKey("GoodsID");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("WeWaiter.Data.Order", b =>
                {
                    b.Property<string>("OrderID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("ActPay");

                    b.Property<DateTime>("Create");

                    b.Property<string>("PayOrderID");

                    b.Property<string>("PayType");

                    b.Property<decimal>("Payable");

                    b.Property<string>("SellerID");

                    b.Property<int>("SellerOrderIndex");

                    b.Property<string>("UserID");

                    b.HasKey("OrderID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("WeWaiter.Data.Seller", b =>
                {
                    b.Property<string>("SellerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("FullName");

                    b.Property<string>("LogoURL");

                    b.Property<string>("MapURL");

                    b.Property<string>("OwnerIDNumber");

                    b.Property<string>("OwnerName");

                    b.Property<string>("OwnerPhone");

                    b.Property<string>("OwnerWeixinID");

                    b.Property<string>("ShortName");

                    b.HasKey("SellerID");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("WeWaiter.Data.User", b =>
                {
                    b.Property<string>("WeixinID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("JoinIn");

                    b.Property<DateTime>("LastActive");

                    b.Property<string>("NickName");

                    b.Property<string>("Phone");

                    b.HasKey("WeixinID");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
