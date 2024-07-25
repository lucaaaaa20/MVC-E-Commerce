﻿// <auto-generated />
using System;
using MVCECommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCECommerce.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240718194158_fixedDiscountedPrice")]
    partial class fixedDiscountedPrice
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVCECommerce.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("LinkImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("GroupId");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("MVCECommerce.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("MVCECommerce.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ClientDataId")
                        .HasColumnType("int");

                    b.Property<Guid>("IdSession")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClientDataId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("MVCECommerce.Models.CartArticle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("VariantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("VariantId");

                    b.ToTable("CartArticle");
                });

            modelBuilder.Entity("MVCECommerce.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("MVCECommerce.Models.ClientData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasMaxLength(13)
                        .HasColumnType("int");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClientData");
                });

            modelBuilder.Entity("MVCECommerce.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("HexColor")
                        .HasMaxLength(6)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("MVCECommerce.Models.DeliveryStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeliveryStatus");
                });

            modelBuilder.Entity("MVCECommerce.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("MVCECommerce.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("DeliveryStatusId")
                        .HasColumnType("int");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("DeliveryStatusId");

                    b.HasIndex("OrderStatusId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("MVCECommerce.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("MVCECommerce.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("MVCECommerce.Models.Variant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<bool>("Discount")
                        .HasColumnType("bit");

                    b.Property<double>("DiscountPrice")
                        .HasColumnType("float");

                    b.Property<string>("LinkImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("SizeId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("BrandId");

                    b.HasIndex("ColorId");

                    b.HasIndex("SizeId");

                    b.ToTable("Variant");
                });

            modelBuilder.Entity("MVCECommerce.Models.Article", b =>
                {
                    b.HasOne("MVCECommerce.Models.Category", "Category")
                        .WithMany("Article")
                        .HasForeignKey("CategoryId");

                    b.HasOne("MVCECommerce.Models.Group", "Group")
                        .WithMany("Article")
                        .HasForeignKey("GroupId");

                    b.Navigation("Category");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("MVCECommerce.Models.Cart", b =>
                {
                    b.HasOne("MVCECommerce.Models.ClientData", "ClientData")
                        .WithMany("Cart")
                        .HasForeignKey("ClientDataId");

                    b.Navigation("ClientData");
                });

            modelBuilder.Entity("MVCECommerce.Models.CartArticle", b =>
                {
                    b.HasOne("MVCECommerce.Models.Cart", "Cart")
                        .WithMany("CartArticle")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCECommerce.Models.Variant", "Variant")
                        .WithMany("CartArticle")
                        .HasForeignKey("VariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("MVCECommerce.Models.Category", b =>
                {
                    b.HasOne("MVCECommerce.Models.Group", "Group")
                        .WithMany("Category")
                        .HasForeignKey("GroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("MVCECommerce.Models.Order", b =>
                {
                    b.HasOne("MVCECommerce.Models.Cart", "Cart")
                        .WithMany("Order")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCECommerce.Models.DeliveryStatus", "DeliveryStatus")
                        .WithMany("Order")
                        .HasForeignKey("DeliveryStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCECommerce.Models.OrderStatus", "OrderStatus")
                        .WithMany("Order")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("DeliveryStatus");

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("MVCECommerce.Models.Variant", b =>
                {
                    b.HasOne("MVCECommerce.Models.Article", "Article")
                        .WithMany("Variant")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCECommerce.Models.Brand", "Brand")
                        .WithMany("Variant")
                        .HasForeignKey("BrandId");

                    b.HasOne("MVCECommerce.Models.Color", "Color")
                        .WithMany("Variant")
                        .HasForeignKey("ColorId");

                    b.HasOne("MVCECommerce.Models.Size", "Size")
                        .WithMany("Variant")
                        .HasForeignKey("SizeId");

                    b.Navigation("Article");

                    b.Navigation("Brand");

                    b.Navigation("Color");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("MVCECommerce.Models.Article", b =>
                {
                    b.Navigation("Variant");
                });

            modelBuilder.Entity("MVCECommerce.Models.Brand", b =>
                {
                    b.Navigation("Variant");
                });

            modelBuilder.Entity("MVCECommerce.Models.Cart", b =>
                {
                    b.Navigation("CartArticle");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("MVCECommerce.Models.Category", b =>
                {
                    b.Navigation("Article");
                });

            modelBuilder.Entity("MVCECommerce.Models.ClientData", b =>
                {
                    b.Navigation("Cart");
                });

            modelBuilder.Entity("MVCECommerce.Models.Color", b =>
                {
                    b.Navigation("Variant");
                });

            modelBuilder.Entity("MVCECommerce.Models.DeliveryStatus", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("MVCECommerce.Models.Group", b =>
                {
                    b.Navigation("Article");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MVCECommerce.Models.OrderStatus", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("MVCECommerce.Models.Size", b =>
                {
                    b.Navigation("Variant");
                });

            modelBuilder.Entity("MVCECommerce.Models.Variant", b =>
                {
                    b.Navigation("CartArticle");
                });
#pragma warning restore 612, 618
        }
    }
}
