﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Airport_Datalist", b =>
                {
                    b.Property<int>("ID_AIRPORT_DATALIST")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID_AIRPORT_DATALIST"));

                    b.Property<int>("CON_HOR_VISIBILITY")
                        .HasColumnType("integer");

                    b.Property<int>("CON_VER_VISIBILITY")
                        .HasColumnType("integer");

                    b.Property<string>("FUNCTION")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IATA_CODE")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ICAO_CODE")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PLANNED_RUNWAY")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("REQ_HOR_VISIBILITY")
                        .HasColumnType("integer");

                    b.Property<int>("REQ_VER_VISIBILITY")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("SUITABLE_PER_FROM")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("SUITABLE_PER_UNTIL")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID_AIRPORT_DATALIST");

                    b.ToTable("AIRPORT_DATALIST");
                });

            modelBuilder.Entity("Domain.Weight_Header", b =>
                {
                    b.Property<int>("ID_WEIGHT_HEADER")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID_WEIGHT_HEADER"));

                    b.Property<int>("DRY_OPERATING_WEIGHT")
                        .HasColumnType("integer");

                    b.Property<string>("DRY_OPERATING_WEIGHT_UNIT")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LANDING_EW")
                        .HasColumnType("integer");

                    b.Property<int>("LANDING_OL")
                        .HasColumnType("integer");

                    b.Property<int>("LANDING_SL")
                        .HasColumnType("integer");

                    b.Property<int>("LOAD")
                        .HasColumnType("integer");

                    b.Property<string>("LOAD_UNIT")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TAKEOFF_EW")
                        .HasColumnType("integer");

                    b.Property<int>("TAKEOFF_OL")
                        .HasColumnType("integer");

                    b.Property<string>("TAKEOFF_REASON")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TAKEOFF_SL")
                        .HasColumnType("integer");

                    b.Property<string>("WEIGHT_HEADER_EXTENSION")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ZERO_FUEL_WEIGHT_EW")
                        .HasColumnType("integer");

                    b.Property<int>("ZERO_FUEL_WEIGHT_SL")
                        .HasColumnType("integer");

                    b.HasKey("ID_WEIGHT_HEADER");

                    b.ToTable("WEIGHT_HEADER");
                });
#pragma warning restore 612, 618
        }
    }
}
