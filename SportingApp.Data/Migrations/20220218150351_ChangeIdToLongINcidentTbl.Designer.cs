﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportingApp.Data;

#nullable disable

namespace SportingApp.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220218150351_ChangeIdToLongINcidentTbl")]
    partial class ChangeIdToLongINcidentTbl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SportingApp.Data.Domain.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pakistan"
                        },
                        new
                        {
                            Id = 2,
                            Name = "England"
                        });
                });

            modelBuilder.Entity("SportingApp.Data.Domain.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "ABC HouseSTREET",
                            City = "Rawalpindi",
                            CountryId = 1,
                            Email = "cust@cust.com",
                            FirstName = "Cust",
                            LastName = "One",
                            Phone = "3315681100",
                            PostalCode = "45544",
                            State = "Punjab"
                        },
                        new
                        {
                            Id = 2L,
                            Address = "ABC 34 street ",
                            City = "london",
                            CountryId = 1,
                            Email = "custtwo@cust.com",
                            FirstName = "Cust",
                            LastName = "two",
                            Phone = "3325233100",
                            PostalCode = "ABDE42",
                            State = "Wembley"
                        });
                });

            modelBuilder.Entity("SportingApp.Data.Domain.Incident", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOpened")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<long>("TechnicianId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TechnicianId");

                    b.ToTable("Incidents");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CustomerId = 1L,
                            DateOpened = new DateTime(2022, 2, 18, 15, 3, 50, 841, DateTimeKind.Utc).AddTicks(1964),
                            Description = "This is test incident one",
                            ProductId = 1L,
                            TechnicianId = 1L,
                            Title = "TestIncidentOne"
                        },
                        new
                        {
                            Id = 2L,
                            CustomerId = 2L,
                            DateOpened = new DateTime(2022, 2, 18, 15, 3, 50, 841, DateTimeKind.Utc).AddTicks(1967),
                            Description = "This is test incident two",
                            ProductId = 2L,
                            TechnicianId = 2L,
                            Title = "TestIncidentTwo"
                        });
                });

            modelBuilder.Entity("SportingApp.Data.Domain.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = "CD211",
                            Name = "TestProductOne",
                            Price = 22.199999999999999,
                            ReleaseDate = new DateTime(2022, 2, 18, 15, 3, 50, 841, DateTimeKind.Utc).AddTicks(1693)
                        },
                        new
                        {
                            Id = 2L,
                            Code = "XTY211",
                            Name = "TestProductTwo",
                            Price = 32.630000000000003,
                            ReleaseDate = new DateTime(2022, 2, 18, 15, 3, 50, 841, DateTimeKind.Utc).AddTicks(1694)
                        });
                });

            modelBuilder.Entity("SportingApp.Data.Domain.Registration", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<long?>("CustomerId1")
                        .HasColumnType("bigint");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<long?>("ProductId1")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId1");

                    b.HasIndex("ProductId1");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("SportingApp.Data.Domain.Technician", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Technicians");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "tech@tech.com",
                            FirstName = "TestTech",
                            LastName = "One",
                            Phone = "3315681100"
                        },
                        new
                        {
                            Id = 2L,
                            Email = "techtwo@tech.com",
                            FirstName = "TestTech",
                            LastName = "Two",
                            Phone = "3125337157"
                        });
                });

            modelBuilder.Entity("SportingApp.Data.Domain.Customer", b =>
                {
                    b.HasOne("SportingApp.Data.Domain.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("SportingApp.Data.Domain.Incident", b =>
                {
                    b.HasOne("SportingApp.Data.Domain.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportingApp.Data.Domain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportingApp.Data.Domain.Technician", "Technician")
                        .WithMany()
                        .HasForeignKey("TechnicianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Technician");
                });

            modelBuilder.Entity("SportingApp.Data.Domain.Registration", b =>
                {
                    b.HasOne("SportingApp.Data.Domain.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId1");

                    b.HasOne("SportingApp.Data.Domain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId1");

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
