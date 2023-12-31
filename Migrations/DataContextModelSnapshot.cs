﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("WebApplication1.VCharacter", b =>
                {
                    b.Property<int>("VRegistrationNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("VImage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VModel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VQuantity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VYearOfManufacture")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Vcolor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VRegistrationNumber");

                    b.ToTable("VCharacters");
                });
#pragma warning restore 612, 618
        }
    }
}
