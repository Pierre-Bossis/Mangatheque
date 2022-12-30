﻿// <auto-generated />
using System;
using Mangatheque.Core.Infrastructure.Databases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mangatheque.Core.Infrastructure.Migrations
{
    [DbContext(typeof(MangaDbContext))]
    partial class MangaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mangatheque.Core.Models.Manga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Auteur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Couverture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("DatePublication")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<decimal>("stockId")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("stockId");

                    b.ToTable("Mangas");
                });

            modelBuilder.Entity("Mangatheque.Core.Models.Stock", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("Mangatheque.Core.Models.Manga", b =>
                {
                    b.HasOne("Mangatheque.Core.Models.Stock", "stock")
                        .WithMany()
                        .HasForeignKey("stockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("stock");
                });
#pragma warning restore 612, 618
        }
    }
}
