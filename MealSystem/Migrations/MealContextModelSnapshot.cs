﻿// <auto-generated />
using System;
using MealSystem.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MealSystem.Migrations
{
    [DbContext(typeof(MealContext))]
    partial class MealContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MealSystem.Models.Ticket", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool?>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<string>("code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("compNm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("endDt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("mealType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("regDt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("startDt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Ticket");
                });
#pragma warning restore 612, 618
        }
    }
}
