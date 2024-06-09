﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pet_mart_api.Data;

#nullable disable

namespace pet_mart_api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240608165721_AddUserAndPetRelationship")]
    partial class AddUserAndPetRelationship
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("pet_mart_api.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("pet_mart_api.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CustomerId")
                        .HasColumnType("text");

                    b.Property<int?>("CustomerId1")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId1");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("pet_mart_api.Models.OrderDetails", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("OrderId")
                        .HasColumnType("text");

                    b.Property<int>("OrderedCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("pet_mart_api.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("pet_mart_api.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryId")
                        .HasColumnType("text");

                    b.Property<string>("NameAr")
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .HasColumnType("text");

                    b.Property<string>("OrderDetailsId")
                        .HasColumnType("text");

                    b.Property<decimal>("StockQuantity")
                        .HasColumnType("numeric");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("numeric");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OrderDetailsId");

                    b.HasIndex("UserId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("pet_mart_api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("pet_mart_api.Models.Admin", b =>
                {
                    b.HasBaseType("pet_mart_api.Models.User");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("JobTitle")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<int?>("UserId1")
                        .HasColumnType("integer");

                    b.HasIndex("UserId1");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("pet_mart_api.Models.Customer", b =>
                {
                    b.HasBaseType("pet_mart_api.Models.User");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("Customer");
                });

            modelBuilder.Entity("pet_mart_api.Models.Order", b =>
                {
                    b.HasOne("pet_mart_api.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId1");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("pet_mart_api.Models.OrderDetails", b =>
                {
                    b.HasOne("pet_mart_api.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("pet_mart_api.Models.Pet", b =>
                {
                    b.HasOne("pet_mart_api.Models.User", "Owner")
                        .WithMany("Pets")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("pet_mart_api.Models.Product", b =>
                {
                    b.HasOne("pet_mart_api.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("pet_mart_api.Models.OrderDetails", null)
                        .WithMany("Products")
                        .HasForeignKey("OrderDetailsId");

                    b.HasOne("pet_mart_api.Models.User", null)
                        .WithMany("ShoppingCart")
                        .HasForeignKey("UserId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("pet_mart_api.Models.Admin", b =>
                {
                    b.HasOne("pet_mart_api.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("User");
                });

            modelBuilder.Entity("pet_mart_api.Models.OrderDetails", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("pet_mart_api.Models.User", b =>
                {
                    b.Navigation("Pets");

                    b.Navigation("ShoppingCart");
                });
#pragma warning restore 612, 618
        }
    }
}
