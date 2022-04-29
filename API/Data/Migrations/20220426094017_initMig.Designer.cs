﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220426094017_initMig")]
    partial class initMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            // modelBuilder.Entity("API.Entities.CardEntity", b =>
            //     {
            //         b.Property<int>("UserId")
            //             .ValueGeneratedOnAdd()
            //             .HasColumnType("INTEGER");

            //         b.Property<int>("CardCVV")
            //             .HasColumnType("INTEGER");

            //         b.Property<string>("CardDate")
            //             .HasColumnType("TEXT");

            //         b.Property<long>("CardNumber")
            //             .HasColumnType("INTEGER");

            //         b.Property<string>("FullName")
            //             .HasColumnType("TEXT");

            //         b.Property<int>("IdNumber")
            //             .HasColumnType("INTEGER");

            //         b.HasKey("UserId");

            //         b.ToTable("Cards");
            //     });

            modelBuilder.Entity("API.Entities.ProductEntity", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");


                    b.Property<string>("Name")
                        .HasColumnType("TEXT");


                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");


                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            // modelBuilder.Entity("API.Entities.UserEntity", b =>
            //     {
            //         b.Property<int>("Id")
            //             .ValueGeneratedOnAdd()
            //             .HasColumnType("INTEGER");

            //         b.Property<string>("Address")
            //             .HasColumnType("TEXT");

            //         b.Property<string>("City")
            //             .HasColumnType("TEXT");

            //         b.Property<string>("Country")
            //             .HasColumnType("TEXT");

            //         b.Property<DateTime>("Created")
            //             .HasColumnType("TEXT");

            //         b.Property<DateTime>("DateOfBirth")
            //             .HasColumnType("TEXT");

            //         b.Property<string>("Email")
            //             .HasColumnType("TEXT");

            //         b.Property<string>("FirstName")
            //             .HasColumnType("TEXT");

            //         b.Property<DateTime>("LastActive")
            //             .HasColumnType("TEXT");

            //         b.Property<string>("LastName")
            //             .HasColumnType("TEXT");

            //         b.Property<byte[]>("PasswordHash")
            //             .HasColumnType("BLOB");

            //         b.Property<byte[]>("PasswordSalt")
            //             .HasColumnType("BLOB");

            //         b.Property<int>("PhoneNumber")
            //             .HasColumnType("INTEGER");

            //         b.Property<string>("UserName")
            //             .HasColumnType("TEXT");

            //         b.HasKey("Id");

            //         b.ToTable("Users");
            //     });
#pragma warning restore 612, 618
        }
    }
}
