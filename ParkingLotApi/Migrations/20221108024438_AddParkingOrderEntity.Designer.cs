﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkingLotApi.Repository;

#nullable disable

namespace ParkingLotApi.Migrations
{
    [DbContext(typeof(ParkingLotContext))]
    [Migration("20221108024438_AddParkingOrderEntity")]
    partial class AddParkingOrderEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParkingLotApi.Models.ParkingLotEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Availibility")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ParkingLots");
                });

            modelBuilder.Entity("ParkingLotApi.Models.ParkingOrderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CarPlateNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CloseTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NameOfParkingLot")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<int?>("ParkingLotEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParkingLotEntityId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ParkingLotApi.Models.ParkingOrderEntity", b =>
                {
                    b.HasOne("ParkingLotApi.Models.ParkingLotEntity", null)
                        .WithMany("ParkingOrder")
                        .HasForeignKey("ParkingLotEntityId");
                });

            modelBuilder.Entity("ParkingLotApi.Models.ParkingLotEntity", b =>
                {
                    b.Navigation("ParkingOrder");
                });
#pragma warning restore 612, 618
        }
    }
}
