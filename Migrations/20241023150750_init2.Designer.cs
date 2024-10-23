﻿// <auto-generated />
using GalleryProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GalleryProject.Migrations
{
    [DbContext(typeof(GalleryDbContext))]
    [Migration("20241023150750_init2")]
    partial class init2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GalleryProject.Models.Gallery", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ArtistAge")
                        .HasColumnType("int");

                    b.Property<bool>("ArtistAlive")
                        .HasColumnType("bit");

                    b.Property<string>("ArtistGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("GalleryProject.Models.WorkOfArt", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("MadeByArtist")
                        .HasColumnType("bit");

                    b.Property<int>("MadeByArtistID")
                        .HasColumnType("int");

                    b.Property<string>("MadeBySomoneElseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkOfArtGroup")
                        .HasColumnType("int");

                    b.Property<string>("WorkOfArtName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("WorksOfArt");
                });

            modelBuilder.Entity("GalleryProject.Models.WorkOfArtGroup", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Literature")
                        .HasColumnType("bit");

                    b.Property<bool>("Music")
                        .HasColumnType("bit");

                    b.Property<bool>("Painting")
                        .HasColumnType("bit");

                    b.Property<bool>("Sculpture")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("WorksOfArtGroups");
                });
#pragma warning restore 612, 618
        }
    }
}